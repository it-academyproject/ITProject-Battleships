using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITProject_Battleships.Data.Repositories;
using ITProject_Battleships.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITProject_Battleships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : GenericController<Challenge, ChallengeRepository>
    {
        public ChallengeController(ChallengeRepository repository) : base(repository)
        {

        }
    }
}
