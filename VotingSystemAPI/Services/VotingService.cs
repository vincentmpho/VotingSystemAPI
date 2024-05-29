using VotingSystemAPI.Mappers;
using VotingSystemAPI.Models;
using VotingSystemAPI.Repository.Interfaces;

namespace VotingSystemAPI.Services
{
    public class VotingService : IVotingService
    {
        private readonly IVotingRepository _votingRepository;
        private readonly IVoteMapper _voteMapper;

        public VotingService(IVotingRepository votingRepository, IVoteMapper voteMapper)
        {
            _votingRepository = votingRepository;
            _voteMapper = voteMapper;
        }

        public void Vote(string voterName, string candidate, string ballotType)
        {
            var vote = new Vote
            {
                VoterName = voterName,
                Candidate = candidate
            };
            _votingRepository.AddVote(vote);

            var ballotVote = new BallotVote
            {
                VoterName = voterName,
                BallotType = ballotType,
                Candidate = candidate
            };
            _votingRepository.AddBallotVote(ballotVote);
        }

        public int GetVoteCount(string candidate)
        {
            return _votingRepository.GetVoteCount(candidate);
        }

        public int GetBallotVoteCount(string candidate, string ballotType)
        {
            return _votingRepository.GetBallotVoteCount(candidate, ballotType);
        }

        public IEnumerable<Vote> GetAllVotes()
        {
            return _votingRepository.GetAllVotes();
        }
    }
}
