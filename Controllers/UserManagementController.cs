using ATC_BE.Data;
using ATC_BE.Data.DefaultData;
using ATC_BE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;


namespace ATC_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly ApiDbContext _dbContext;

        public UserManagementController(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            ApiDbContext dbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _dbContext = dbContext;

        }

        // autorizare doar admin
        [HttpPost]
        [Route("register-user")]
        public async Task<IActionResult> RegisterUser(UserRegisterModel registerModel)
        {
            var userExists = await _userManager.FindByNameAsync(registerModel.Email);
            if(userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });

            IdentityUser user = new()
            {
                UserName = registerModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            // Looking in DB if roles are there, if not put them there
            if (!await _roleManager.RoleExistsAsync(UserRole.Administrator))
                await _roleManager.CreateAsync(new IdentityRole(UserRole.Administrator));

            if (!await _roleManager.RoleExistsAsync(UserRole.AdministratorOffice))
                await _roleManager.CreateAsync(new IdentityRole(UserRole.AdministratorOffice));

            if (!await _roleManager.RoleExistsAsync(UserRole.Employee))
                await _roleManager.CreateAsync(new IdentityRole(UserRole.Employee));

            if (!await _roleManager.RoleExistsAsync(registerModel.Role))
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User role doesn't exist in Db" });
            }

            // Storing the "account" in DB
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            // Register the role
            var roleResult = await _userManager.AddToRoleAsync(user, registerModel.Role);
            if(!roleResult.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            // Adding the details of the user in DB
            UserModel userDetails = new UserModel
            {
                AccountId = user.Id,
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                Role = registerModel.Role,
                Gender = registerModel.Gender,
                BirthDate = registerModel.BirthDate,
                AccountStatus = AccountStatus.Ative,
                Nationality = registerModel.Nationality
            };

            _dbContext.UserDetails.Add(userDetails);
            await _dbContext.SaveChangesAsync();

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }



        [HttpGet]
        [Route("get-users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _dbContext.UserDetails.ToListAsync();
            var jsonString = JsonSerializer.Serialize(users);

            return Ok(jsonString);
        }

    }
} 
