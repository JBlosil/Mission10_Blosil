namespace API.Models
{
    public interface IBowlerRepository
    {
        public IEnumerable<Bowler> Bowlers { get; }
        public IEnumerable<Team> Teams { get; }

        public IEnumerable<Bowler> GetTeamBowlers();
    }
}
