using Mist452FinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Mist452FinalProject.Data
{
    public class ProjectDBContext : IdentityDbContext<IdentityUser>
    {
        public ProjectDBContext(DbContextOptions<ProjectDBContext> options) : base(options)
        {
        }

        public DbSet<Survey> Surveys { get; set; }   //corresponds to the swl table that will be created in the database. Each row in this table will be a category. ANd the table will be called Categories 

        public DbSet<Game> Games { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Survey>().HasData(
                new Survey
                {
                    SurveyId = 1,
                    ParticipantName = "Alex Smith",
                    Email = "alex.smith@example.com",
                    Age = 30,
                    TeamSatisfaction = TeamSatisfaction.VerySatisfied, // Use enum value
                    FavoritePlayer = "Player A",
                    LeastFavoritePlayer = "Player B",
                    FavoriteMatch = "Match 1",
                    SuggestionsForImprovement = "More community events",
                    IsInterestedInVolunteering = true
                },
                new Survey
                {
                    SurveyId = 2,
                    ParticipantName = "Jamie Doe",
                    Email = "jamie.doe@example.com",
                    Age = 25,
                    TeamSatisfaction = TeamSatisfaction.Satisfied, // Use enum value
                    FavoritePlayer = "Player C",
                    LeastFavoritePlayer = "Player D",
                    FavoriteMatch = "Match 3",
                    SuggestionsForImprovement = "Better merchandise options",
                    IsInterestedInVolunteering = false
                },
                new Survey
                {
                    SurveyId = 3,
                    ParticipantName = "Chris Lee",
                    Email = "chris.lee@example.com",
                    Age = 28,
                    TeamSatisfaction = TeamSatisfaction.Neutral, // Use enum value
                    FavoritePlayer = "Player E",
                    LeastFavoritePlayer = "Player F",
                    FavoriteMatch = "Match 5",
                    SuggestionsForImprovement = "Improved stadium facilities",
                    IsInterestedInVolunteering = true
                }
            );


        }
    }
}
