using System.ComponentModel.DataAnnotations;

namespace VotingSystemAPI.Models.DTOs
{
    public class VoteRequestDto
    {
        public string VoterName { get; set; }
        public string Candidate { get; set; }
        public string BallotType { get; set; }
    }
}
