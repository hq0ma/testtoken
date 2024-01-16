using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NotificationMessage.Backend.Model;
using NotificationMessage.Backend.Service;
using NotificationMessage.Backend.Service.UserDtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NotificationMessage.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly UserService _userService;
        public UserController(IConfiguration config, UserService userService)
        {
            _config = config;
            _userService = userService;
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> RegeisterUser([FromBody]AddUserDto addUserDto)
        {
            var result = await _userService.Register(addUserDto);
            var token = GenerateToken(result);
            return Ok(token);
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDto userLogin)
        {
            var user = await _userService.GetPhone(userLogin.PhoneNumber);
            if (user == null || user.Password != userLogin.Password)
            {
                return Unauthorized(new { Message = "بيانات غير صحيحة" });
            }
            else
            {
                var token = GenerateToken(user);
                return Ok(new { Token = token, UserId = user.Id });
            }
        }



























        // To generate token
        private string GenerateToken(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.PhoneNumber),
                new Claim(ClaimTypes.Role,user.Role.ToString())
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
