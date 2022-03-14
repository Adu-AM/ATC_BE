using ATC_BE.Data;
using ATC_BE.Data.Enums;
using ATC_BE.Helpers;
using ATC_BE.Models;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        [Route("register-user")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> RegisterUser(UserRegisterModel registerModel)
        {
            // Search for user if exists already
            var userExists = await _userManager.FindByNameAsync(registerModel.Email);
            if (userExists != null)
                return BadRequest(new Response { Status = "Error", Message = "User already exists" });

            // Validate details
            if (ValidateUser.ValidateUserDetails(registerModel) == false)
                return BadRequest(new Response { Status = "Error", Message = "User data is incorrect" });

            // Verify if role exists in Db
            if (!await _roleManager.RoleExistsAsync(registerModel.Role.ToString()))
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User role doesn't exist" });

            IdentityUser user = new()
            {
                UserName = registerModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
            };

            // Creating object for the user details table
            UserModel userDetails = new UserModel
            {
                AccountId = user.Id,
                FirstName = NameFormating.UpperCaseFirst(registerModel.FirstName),
                LastName = NameFormating.UpperCaseFirst(registerModel.LastName),
                Email = registerModel.Email,
                Role = registerModel.Role,
                Gender = registerModel.Gender,
                BirthDate = registerModel.BirthDate,
                AccountStatus = AccountStatus.Active,
                Nationality = registerModel.Nationality
            };

            // Storing the "account" in DB
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check the password" });

            // Register the role in DB
            var roleResult = await _userManager.AddToRoleAsync(user, registerModel.Role.ToString());
            if (!roleResult.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! There was a problem with the role assigning" });
            
            // Save details about the user in DB
            _dbContext.UserDetails.Add(userDetails);
            await _dbContext.SaveChangesAsync();

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [HttpGet]
        [Route("get-user/{email}")]
        //[Authorize]
        public async Task<IActionResult> GetUser(string email)
        {
            var user = await _dbContext.UserDetails.FindAsync(email);
            if (user == null)
                return NotFound(new Response { Status = "Error", Message = "User not found" });

            return Ok(user);
        }

        [HttpGet]
        [Route("get-users")]
        //[Authorize]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _dbContext.UserDetails.ToListAsync();

            return Ok(users);
        }

        [HttpPut]
        [Route("update-user")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> UpdateUser(UserModel request)
        {
            try
            {
                var user = await _dbContext.UserDetails.FindAsync(request.Email);

                if (user == null)
                    return NotFound(new Response { Status = "Error", Message = "User not found" });

                // Account
                user.Role = request.Role;
                user.RemotePercentage = request.RemotePercentage;

                // Details
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.Gender = request.Gender;

                // Optionals
                user.BirthDate = request.BirthDate;
                user.Nationality = request.Nationality;

                // Save data
                _dbContext.UserDetails.Update(user);
                await _dbContext.SaveChangesAsync();

                return Ok(new Response { Status="Succes", Message="User has been updated"});

            }
            catch (Exception)
            {
                return BadRequest(new Response { Status = "Error", Message = "There was a problem" } );
            }
        }


        [HttpPut]
        [Route("update-activate-user/{email}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AccountActivate(string email)
        {
            try
            {
                var user = await _dbContext.UserDetails.FindAsync(email);
                if(user == null)
                    return NotFound(new Response { Status = "Error", Message = "User not found" });

                // If account is already activated there should be a problem
                if (user.AccountStatus == AccountStatus.Active)
                    return BadRequest(new Response { Status = "Error", Message = "Account is already active" });

                // Update account status
                user.AccountStatus = AccountStatus.Active;

                // Save data
                _dbContext.Update(user);
                await _dbContext.SaveChangesAsync();

                return Ok(new Response { Status = "Succes", Message = "User has been activated" });
            }
            catch (Exception)
            {
                return BadRequest(new Response { Status = "Error", Message = "There was a problem" });
            }
        }

        [HttpPut]
        [Route("update-deactivate-user/{email}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> AccountDeactivate(string email)
        {
            try
            {
                var user = await _dbContext.UserDetails.FindAsync(email);
                if (user == null)
                    return NotFound(new Response { Status = "Error", Message = "User not found" });

                // An administrator cannot deactivate his own account.
                // WIP


                // If account is already activated there should be a problem
                if (user.AccountStatus == AccountStatus.Inactive)
                    return BadRequest(new Response { Status = "Error", Message = "Account is already inactive" });

                // Update account status
                user.AccountStatus = AccountStatus.Inactive;

                // Save data
                _dbContext.Update(user);
                await _dbContext.SaveChangesAsync();

                return Ok(new Response { Status = "Succes", Message = "User has been deactivated" });
            }
            catch (Exception)
            {
                return BadRequest(new Response { Status = "Error", Message = "There was a problem"});
            }
        }

    }
} 
