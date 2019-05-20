using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDataBase.Models
{
    public class Teacher
    {
        public Teacher()
        {
            Disciplines = new HashSet<Discipline>();
            Disertations = new HashSet<Disertation>();
            Diplomas = new HashSet<Diploma>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public char Sex { get; set; }
        [Required]
        public DateTime Birth { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Childs { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int CafedraId { get; set; }
        [Required]
        public int FacultyId { get; set; }

        public virtual Cafedra Cafedra { get; set; }
        
        public virtual Faculty Faculty { get; set; }
        
        public virtual ICollection<Disertation> Disertations { get; set; }
        
        public virtual ICollection<Discipline> Disciplines { get; set; }
        
        public virtual ICollection<Diploma> Diplomas { get; set; }
        
    }
}