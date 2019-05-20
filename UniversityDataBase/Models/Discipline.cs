using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDataBase.Models
{
    public class Discipline
    {
        public Discipline()
        {
            GroupsDisciplines = new HashSet<GroupsDisciplines>();
            Journals = new HashSet<Journal>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Stage { get; set; }
        [Required]
        public int Semester { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public int Hours { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int CafedraId { get; set; }
        
        public virtual Teacher Teacher { get; set; }
        
        public virtual Cafedra Cafedra { get; set; }
        public virtual ICollection<GroupsDisciplines> GroupsDisciplines { get; set; }
        
        public virtual ICollection<Journal> Journals { get; set; }
    }
}