using VotingSystemAPI.Data;
using VotingSystemAPI.Models;
using VotingSystemAPI.Repository.Interfaces;

namespace VotingSystemAPI.Repository
{
    public class VotingRepository : IVotingRepository
    {
        private readonly VotingContext _context;

        public VotingRepository(VotingContext context)
        {
            _context = context;
        }

        public void AddVote(Vote vote)
        {
            _context.Votes.Add(vote);
            _context.SaveChanges();
        }

        public void AddBallotVote(BallotVote ballotVote)
        {
            _context.BallotVotes.Add(ballotVote);
            _context.SaveChanges();
        }

        public int GetVoteCount(string candidate)
        {
            return _context.Votes.Count(v => v.Candidate == candidate);
        }

        public int GetBallotVoteCount(string candidate, string ballotType)
        {
            return _context.BallotVotes.Count(bv => bv.Candidate == candidate && bv.BallotType == ballotType);
        }

        public IEnumerable<Vote> GetAllVotes()
        {
            return _context.Votes.ToList();
        }
    }
}
