using ATC_BE.Data.Enums;
using ATC_BE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ATC_BE.Data
{
    public class ApiDbContext: IdentityDbContext<IdentityUser>
    {
        // Users
        public DbSet<UserModel> UserDetails { get; set; }
        // Building
        public DbSet<BuildingModel> BuildingModels { get; set; }

        // Office
        public DbSet<OfficeModel> OfficeModels { get; set; }

        // Desk
        public DbSet<DeskModel> DeskModels { get; set; }



        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            InitializeRoles(builder);

            InitializeAdmin(builder);
            InitializeOfficeAdmin(builder);
            InitializeEmployee(builder);

            InitializeAccountRole(builder, "1", "1");
            InitializeAccountRole(builder, "2", "2");
            InitializeAccountRole(builder, "3", "3");

            builder.Entity<UserModel>()
                .HasOne(a => a.Desk)
                .WithOne(b => b.User)
                .HasForeignKey<DeskModel>(b => b.UserEmail);
        }

     

        private void InitializeRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(createRole("1", UserRole.Administrator));
            builder.Entity<IdentityRole>().HasData(createRole("2", UserRole.OfficeAdministrator));
            builder.Entity<IdentityRole>().HasData(createRole("3", UserRole.Employee));
        }

        private void InitializeAdmin(ModelBuilder builder)
        {

            IdentityUser user = new IdentityUser
            {
                Id = "1",
                UserName = "admin@example.com",
                NormalizedUserName = "ADMIN@EXAMPLE.COM",
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            user.PasswordHash = ph.HashPassword(user, "string");

            builder.Entity<IdentityUser>().HasData(user);

            builder.Entity<UserModel>().HasData(new UserModel
            {
                AccountId = "1",
                FirstName = "Corina",
                LastName = "Popescu",
                Email = "admin@example.com",
                Role = UserRole.Administrator,
                Gender = Gender.Female,
                BirthDate = new DateTime(1990, 1, 5),
                AccountStatus = AccountStatus.Active,
                Nationality = Nationality.Romanian,
                RemotePercentage = 0
            });
        }


        private void InitializeOfficeAdmin(ModelBuilder builder)
        {

            IdentityUser user = new IdentityUser
            {
                Id = "2",
                UserName = "office@example.com",
                NormalizedUserName = "OFFICE@EXAMPLE.COM",
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            user.PasswordHash = ph.HashPassword(user, "string1");

            builder.Entity<IdentityUser>().HasData(user);

            builder.Entity<UserModel>().HasData(new UserModel
            {
                AccountId = "2",
                FirstName = "Matei",
                LastName = "Ionescu",
                Email = "office@example.com",
                Role = UserRole.OfficeAdministrator,
                Gender = Gender.Male,
                BirthDate = new DateTime(1985, 7, 10),
                AccountStatus = AccountStatus.Active,
                Nationality = Nationality.British,
                RemotePercentage = 0
            });
        }

        private void InitializeEmployee(ModelBuilder builder)
        {

            IdentityUser user = new IdentityUser
            {
                Id = "3",
                UserName = "employee@example.com",
                NormalizedUserName = "EMPLOYEE@EXAMPLE.COM",
            };

            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();
            user.PasswordHash = ph.HashPassword(user, "string11");

            builder.Entity<IdentityUser>().HasData(user);

            builder.Entity<UserModel>().HasData(new UserModel
            {
                AccountId = "3",
                FirstName = "Mirela",
                LastName = "Pavaliuc",
                Email = "employee@example.com",
                Role = UserRole.Employee,
                Gender = Gender.Female,
                BirthDate = new DateTime(1995, 11, 15),
                AccountStatus = AccountStatus.Active,
                Nationality = Nationality.Romanian,
                RemotePercentage = 0
            });
        }

        private void InitializeAccountRole(ModelBuilder builder, string userID, string roleId)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = userID,
                RoleId = roleId
            });

        }

        private IdentityRole createRole(string id, UserRole role)
        {
            return new IdentityRole
            {
                Id = id,
                Name = role.ToString(),
                NormalizedName = role.ToString().ToUpper(),
            };
        }
   

        
    }
}
