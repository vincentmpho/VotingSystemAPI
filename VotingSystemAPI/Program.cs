using Microsoft.Extensions.Configuration;
using VotingSystemAPI.Data;
using VotingSystemAPI.Mappers;
using VotingSystemAPI.Repository.Interfaces;
using VotingSystemAPI.Repository;
using VotingSystemAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace VotingSystemAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //add new
            builder.Services.AddScoped<IVotingService, VotingService>();
            builder.Services.AddScoped<IVotingRepository, VotingRepository>();
            builder.Services.AddScoped<IVoteMapper, VoteMapper>();
            builder.Services.AddScoped<PartyService>();
            //inject connection string

            builder.Services.AddDbContext<VotingContext>(Options =>
            Options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
