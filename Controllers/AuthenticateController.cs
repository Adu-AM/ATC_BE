using ATC_BE.Data;
using ATC_BE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace ATC_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ApiDbContext _dbContext;

        public AuthenticateController(UserManager<IdentityUser> userManager,
                                      IConfiguration configuration,
                                      ApiDbContext dbContext)
        {
            _userManager = userManager;
            _configuration = configuration;
            _dbContext = dbContext;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            var user = await _userManager.FindByNameAsync(loginModel.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                // This returns a list of roles but the accounts should have just 1 role
                var userRole = await _userManager.GetRolesAsync(user);


                // WIP
                UserModel userDetails = await _dbContext.UserDetails.FindAsync(user.UserName);
                if (userDetails == null)
                    return Unauthorized();

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName), // Email
                    //new Claim(ClaimTypes.GivenName, userDetails.FirstName),
                    //new Claim(ClaimTypes.Surname, userDetails.LastName),
                    //new Claim(ClaimTypes.Role, userRole[0]),
                    //new Claim(ClaimTypes.Gender, userDetails.Gender),
                    //new Claim(ClaimTypes.DateOfBirth, userDetails.BirthDate.ToString()),
                    //new Claim("Nationality", userDetails.Nationality.Value.ToString()),
                    //new Claim("Status", userDetails.AccountStatus.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var token = GetToken(authClaims);

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    email = user.UserName,
                    firstName = userDetails.FirstName,
                    lastName = userDetails.LastName,
                    role = userRole[0],
                    gender = userDetails.Gender,
                    birthDate = userDetails.BirthDate.ToString(),
                    nationality = userDetails.Nationality.ToString(),
                    accountStatus = userDetails.AccountStatus.ToString(),
                    remotePercentage = userDetails.RemotePercentage
                });
            }
            return Unauthorized();
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                _configuration["JWT:Issuer"],
                _configuration["JWT:Audience"],
                expires: DateTime.Now.AddMinutes(15),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return token;
        }


    }
}
