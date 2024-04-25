using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Mist452FinalProject.Models
{
    public class HealthSurvey
    {
        [Key]
         public int HSurveyId { get; set; } // Unique identifier for the survey

        [Required, Display(Name = "Participant Name")]
        public string ParticipantName { get; set; }

        [Required, Range(1, 1000, ErrorMessage = "Weight must be between 1 and 1000 pounds.")]
        public int Weight { get; set; }

        // Separate height into feet and inches
        [Required, Range(1, 8, ErrorMessage = "Height must be between 1 and 8 feet.")]
        public int HeightFeet { get; set; }

        [Required, Range(0, 11, ErrorMessage = "Inches must be between 0 and 11.")]
        public int HeightInches { get; set; }

        [Required, Range(1, 120, ErrorMessage = "Age must be between 1 and 120 years.")]
        public int Age { get; set; }

        [Required, DataType(DataType.Date), Display(Name = "Appointment Date Request")]
        [CustomValidation(typeof(HealthSurvey), nameof(ValidateDate))]
        public DateTime AppointmentDate { get; set; }

        [Display(Name = "Reason for Check-Up")]
        public string ReasonForCheckUp { get; set; }

        [Display(Name = "Smoking Status")]
        public bool IsSmoker { get; set; }

        public static ValidationResult ValidateDate(DateTime date, ValidationContext context)
        {
            if (date < DateTime.Now.Date)
                return new ValidationResult("Appointment date must be in the future.");
            return ValidationResult.Success;
        }
    }
}


