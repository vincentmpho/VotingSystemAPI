using VotingSystemAPI.Models;

namespace VotingSystemAPI.Repository.Interfaces
{
    public interface IVotingRepository
    {
        void AddVote(Vote vote);
        int GetVoteCount(string candidate);
        int GetBallotVoteCount(string candidate, string ballotType);
        IEnumerable<Vote> GetAllVotes();
        void AddBallotVote(BallotVote ballotVote);
    }
}