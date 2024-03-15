using API.Controllers;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueDatabaseContext _context;

        public EFBowlerRepository(BowlingLeagueDatabaseContext temp)
        {
            _context = temp;
        }

        public IEnumerable<Bowler> Bowlers => _context.Bowlers;
        public IEnumerable<Team> Teams => _context.Teams;

        public IEnumerable<Bowler> GetTeamBowlers()
        {
            var teamBowlers = from team in _context.Teams
                              join bowler in _context.Bowlers on team.TeamID equals bowler.TeamID
                              select new Bowler
                              {
                                  TeamName = team.TeamName,
                                  BowlerFirstName = bowler.BowlerFirstName,
                                  BowlerLastName = bowler.BowlerLastName,
                                  BowlerAddress = bowler.BowlerAddress,
                                  BowlerCity = bowler.BowlerCity,
                                  BowlerState = bowler.BowlerState,
                                  BowlerZip = bowler.BowlerZip,
                                  BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                              };

            return teamBowlers.ToList();
        }
    }
}