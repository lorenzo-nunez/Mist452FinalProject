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


        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<HealthSurvey> HealthSurveys { get; set; }






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
            modelBuilder.Entity<Game>().HasData(
       new Game
       {
           GameID = 1,
           gameDate = "2023-04-10",
           opponent = "Team A",
           score = "2-1",
           posessionStat = 54,
           shotsStat = 15,
           SavesStat = 5,
           foulsStat = 8,
           filmURL = "http://example.com/game1film"
       },
       new Game
       {
           GameID = 2,
           gameDate = "2023-04-17",
           opponent = "Team B",
           score = "1-1",
           posessionStat = 60,
           shotsStat = 20,
           SavesStat = 7,
           foulsStat = 11,
           filmURL = "http://example.com/game2film"
       },
       new Game
       {
           GameID = 3,
           gameDate = "2023-04-24",
           opponent = "Team C",
           score = "0-3",
           posessionStat = 48,
           shotsStat = 12,
           SavesStat = 3,
           foulsStat = 14,
           filmURL = "http://example.com/game3film"
       }
      
   );
            modelBuilder.Entity<HealthSurvey>().HasData(
               new HealthSurvey
               {
                   HSurveyId = 1,
                   ParticipantName = "John Doe",
                   Weight = 185,
                   HeightFeet = 5,
                   HeightInches = 10,
                   Age = 34,
                   AppointmentDate = new DateTime(2023, 12, 15),  // Future date for appointment
                   ReasonForCheckUp = "Annual Physical",
                   IsSmoker = false
               },
               new HealthSurvey
               {
                   HSurveyId = 2,
                   ParticipantName = "Jane Smith",
                   Weight = 150,
                   HeightFeet = 5,
                   HeightInches = 5,
                   Age = 29,
                   AppointmentDate = new DateTime(2023, 12, 20),  // Future date for appointment
                   ReasonForCheckUp = "General Consultation",
                   IsSmoker = true
               }
           );

        }
    }
}
