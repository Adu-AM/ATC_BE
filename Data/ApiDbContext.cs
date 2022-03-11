using ATC_BE.Data.Enums;
using ATC_BE.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ATC_BE.Data
{
    public class ApiDbContext: IdentityDbContext<IdentityUser>
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            InitializeRoles(builder);
            InitializeAdmin(builder);
            InitializeAdminRole(builder, "1", "1");
        }

        public DbSet<UserModel> UserDetails { get; set; }

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

            string admin = "admin";

            builder.Entity<UserModel>().HasData(new UserModel
            {
                AccountId = "1",
                FirstName = admin,
                LastName = admin,
                Email = "admin@example.com",
                Role = 0,
                Gender = Gender.Other,
                BirthDate = new DateTime(2022, 1, 1),
                AccountStatus = AccountStatus.Active,
                Nationality = Nationality.Romanian,
                RemotePercentage = 100
            });

        }

        private void InitializeAdminRole(ModelBuilder builder, string userID, string roleId)
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

        //building
        public DbSet<BuildingModel> BuildingModels { get; set; }
        //office
        public DbSet<OfficeModel> OfficeModels { get; set; }
        //desk
    }
}
