using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ITProject_Battleships.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITProject_Battleships.Controllers
{
    [Route ( "api/[controller]" )]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IConfiguration _config;
 
        public AccountController(IConfiguration config )
        {
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login( [FromBody] UserModel login )
        {
            IActionResult response = Unauthorized ();
            var user = AuthenticateUser (login);

            if(user != null)
            {
                var tokenString = GenerateJSONWebToken ( user );
                response = Ok ( new { token = tokenString } );

            }
            return response;
        }

        private string GenerateJSONWebToken ( UserModel userInfo )
        {
            var securityKey = new SymmetricSecurityKey ( Encoding.UTF8.GetBytes ( _config["Jwt:Key"] ) );
            var credentials = new SigningCredentials ( securityKey, SecurityAlgorithms.HmacSha256 );


            var Claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };


            var token = new JwtSecurityToken ( 
                _config["Jwt:Issuer"],
                _config["Jwt:Issuer"],
                Claims,
                expires: DateTime.Now.AddMinutes ( 120 ),
                signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler ().WriteToken ( token );
        }

        private UserModel AuthenticateUser ( UserModel login )
        {
            UserModel user = null;

            //Validate User credentials

            if(login.Email == "battle")
            {
                user = new UserModel
                {
                    Email = "battle",
                    Password = "xecretKeywqejane"
                };
            }
            return user;
        }

 
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get ( )
        {
            return new string[] { "Value 1", "Value 2", "Value 3", };
        }
       
    }
}
