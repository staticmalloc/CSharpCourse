using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityDataBase.Models
{
    public class Diploma
    {
        public int Id { get; set; }
        [Required]
        public string Theme { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
        
    }
}