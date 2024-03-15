using API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BowlingLeagueController : ControllerBase
    {
        private IBowlerRepository _teamBowlerRepository;

        public BowlingLeagueController(IBowlerRepository teamBowlerRepository)
        {
            _teamBowlerRepository = teamBowlerRepository;
        }

        [HttpGet("GetTeamBowlers")]
        public IEnumerable<Bowler> GetTeamBowlers()
        {
            var teamBowlers = _teamBowlerRepository.GetTeamBowlers().
                Where(b => b.TeamName == "Marlins" || b.TeamName == "Sharks");

            return teamBowlers;
        }
    }

}
