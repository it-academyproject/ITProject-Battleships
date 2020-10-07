
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using ITProject_Battleships.Models;
using Microsoft.Extensions.Configuration;

namespace ITProject_Battleships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly BattleContext _context;
        private IConfiguration _config;

        public LoginController(BattleContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<Admin>> Login([FromBody]Admin login)
        {
            _context.Admins.Add(login);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdmin", new { id = login.AdminId }, login);
        }

     
    }
}
