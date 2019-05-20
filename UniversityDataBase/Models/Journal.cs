using System.ComponentModel.DataAnnotations;

namespace UniversityDataBase.Models
{
    public class Journal
    {
        public int Id { get; set; }
        [Required]
        public int Mark { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int DisciplineId { get; set; }
        
        [Required]
        public int SessionId { get; set; }
        
        public virtual Teacher Teacher { get; set; }
        
        public virtual Student Student { get; set; }
        
        public virtual Discipline Discipline { get; set; }
        
        public virtual Session Session { get; set; }
    }
}