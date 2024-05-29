using VotingSystemAPI.Models;

namespace VotingSystemAPI.Mappers
{
    public class VoteMapper : IVoteMapper
    {
        public Vote Map(Vote vote)
        {
            return vote;
        }

        public BallotVote Map(BallotVote ballotVote)
        {
            return new BallotVote
            {
                VoterName = ballotVote.VoterName,
                BallotType = ballotVote.BallotType,
                Candidate = ballotVote.Candidate
            };
        }
    }
}
