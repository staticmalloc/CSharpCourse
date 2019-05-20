using System.ComponentModel.DataAnnotations;

namespace AppFour.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        
        [Required]
        public string ProjectName { get; set; }
        
        [Required]
        public int Award { get; set; }
        
        [Required]
        public int WorkerId { get; set; }
        
        public virtual Worker Worker { get; set; }
    }
}