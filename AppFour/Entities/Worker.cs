using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppFour.Entities
{
    public class Worker
    {
        public Worker()
        {
            Projects = new HashSet<Project>();
        }
        
        public int WorkerId { get; set; }
        [Required]
        
        public string Name { get; set; }
        
        public int Age { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}