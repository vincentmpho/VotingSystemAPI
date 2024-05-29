namespace VotingSystemAPI.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public string VoterName { get; set; }
        public string Candidate { get; set; }
    }
}
