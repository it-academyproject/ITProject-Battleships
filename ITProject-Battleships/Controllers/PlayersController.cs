using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ITProject_Battleships.Models;
using ITProject_Battleships.Data.Repositories;

namespace ITProject_Battleships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : GenericController<Player, PlayerRepository>
    {

        public PlayersController(PlayerRepository repository) : base(repository)
        {

        }
    }
}
