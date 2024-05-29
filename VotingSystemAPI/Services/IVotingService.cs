using VotingSystemAPI.Models;

namespace VotingSystemAPI.Services
{
    public interface IVotingService
    {
        void Vote(string voterName, string candidate, string ballotType);
        int GetVoteCount(string candidate);
        int GetBallotVoteCount(string candidate, string ballotType);
        IEnumerable<Vote> GetAllVotes();
    }
}