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

                UserModel userDetails = await _dbContext.UserDetails.FindAsync(user.UserName);
                if (userDetails == null)
                    return Unauthorized();

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                var token = GetToken(authClaims);

                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo,
                    AccountId = user.Id,
                    Email = user.UserName,
                    FirstName = userDetails.FirstName,
                    LastName = userDetails.LastName,
                    Role = userRole[0],
                    Gender = userDetails.Gender.ToString(),
                    BirthDate = userDetails.BirthDate.ToString(),
                    Nationality = userDetails.Nationality.ToString(),
                    AccountStatus = userDetails.AccountStatus.ToString(),
                    RemotePercentage = userDetails.RemotePercentage
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
