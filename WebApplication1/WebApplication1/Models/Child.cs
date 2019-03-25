using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Child
    {
        private string[] _subjectChoices_Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        public int ChildID { get; set; } = 0;

        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"\S{2,}", ErrorMessage = "First Name must be at least two characters")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "First Name")]
        [RegularExpression(@"\S{2,}", ErrorMessage = "First Name must be at least two characters")]
        public string Surename { get; set; } = "";

        [Required]
        [StringLength(8)]
        public string PPS { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Gender { get; set; } = "";

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public int DayOfWeek { get; set; }

        public bool[] SubjectPicet_Days { get; set; } = { false, false, false, false, false, };

        [BindNever]
        public string[] SubjectChoices_Days { get => _subjectChoices_Days; set => _subjectChoices_Days = value; }
    }
}