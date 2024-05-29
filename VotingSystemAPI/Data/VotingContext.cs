using Microsoft.EntityFrameworkCore;
using VotingSystemAPI.Models;

namespace VotingSystemAPI.Data
{
    public class VotingContext : DbContext
    {
        public VotingContext(DbContextOptions<VotingContext> options) : base(options)
        {

        }

        public DbSet<Vote> Votes { get; set; }
        public DbSet<BallotVote> BallotVotes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vote>()
                .HasKey(v => v.Id);

            modelBuilder.Entity<BallotVote>()
                .HasKey(bv => new { bv.VoterName, bv.BallotType });
        }
    }
}
