using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITProject_Battleships.Models;
using ITProject_Battleships.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;

namespace ITProject_Battleships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : GenericController<Admin, AdminRepository>
    {
        private readonly AdminRepository _repository;
        private IConfiguration _config;
        public AdminsController(AdminRepository repository, IConfiguration config) : base(repository)
        {
            _repository = repository;
            _config = config;
        }
        // Login
        [HttpPost("login")]
        public ActionResult Login([FromBody] UserModel login)
        {
            var result = _repository.Login(login);

            if (result != null)
            {
                var tokenString = GenerateJSONWebToken(login);
                return Ok(new { token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }

        // Register
        [HttpPost("register")]
        public ActionResult Register([FromBody] UserModel user)
        {
            if (user != null)
            {
                _repository.Register(user);
                _repository.SaveChanges();
                var tokenString = GenerateJSONWebToken(user);
                return Ok(new { token = tokenString });
            }
            else
            {
                return BadRequest("Username or password invalid");
            }
        }

        // Generate JWT
        private string GenerateJSONWebToken(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var Claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                Claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);

        }

    }
}
