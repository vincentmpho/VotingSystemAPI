using VotingSystemAPI.Models;

namespace VotingSystemAPI.Mappers
{
    public interface IVoteMapper
    {

        Vote Map(Vote request);
      
    }
}
