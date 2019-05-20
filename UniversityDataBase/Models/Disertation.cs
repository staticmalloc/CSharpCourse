using System.ComponentModel.DataAnnotations;

namespace UniversityDataBase.Models
{
    public class Disertation
    {
        public int Id { get; set; }
        [Required]
        public string Theme { get; set; }
        [Required]
        public int TeacherId { get; set; }
        
        public virtual Teacher Teacher { get; set; }
    }
}