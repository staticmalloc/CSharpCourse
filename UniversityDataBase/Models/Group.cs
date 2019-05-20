using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDataBase.Models
{
    public class Group
    
    {
        public Group()
        {
            Students = new HashSet<Student>();
            GroupsDisciplines = new HashSet<GroupsDisciplines>();
        }
        [Key]
        public int GroupNum { get; set; }
        [Required]
        public int Stage { get; set; }
        [Required]
        public int FacultyId { get; set; }
        [Required]
        public DateTime BeginYear { get; set; }
        
        public virtual Faculty Faculty { get; set; }
        
        public virtual ICollection<Student> Students { get; set; }
        
        public virtual ICollection<GroupsDisciplines> GroupsDisciplines { get; set; }
    }
}