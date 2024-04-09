namespace Mist452FinalProject.Models
{
    public class Survey
    {
        public int SurveyId { get; set; } // Unique identifier for the survey

        // Participant Information
        public string ParticipantName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        // Survey Questions
        public TeamSatisfaction TeamSatisfaction { get; set; } // Changed to enum type
        public string FavoritePlayer { get; set; }
        public string LeastFavoritePlayer { get; set; }
        public string FavoriteMatch { get; set; } // Could be a text input or a selection if you have a list of matches

        // Open-ended feedback
        public string SuggestionsForImprovement { get; set; }
        public bool IsInterestedInVolunteering { get; set; } // Yes/No question

        // Additional properties can be added here based on the survey needs
    }

    // Define the TeamSatisfaction enumeration
    public enum TeamSatisfaction
    {
        VeryDissatisfied = 1,
        Dissatisfied = 2,
        Neutral = 3,
        Satisfied = 4,
        VerySatisfied = 5
    }
}

