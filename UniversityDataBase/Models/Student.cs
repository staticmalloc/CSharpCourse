using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataBase.Models
{
    public class Student
    {
        public Student()
        {
            Diplomas = new HashSet<Diploma>();
        }
        
        public int Id { get; set; }
        
        [Required]
        public string Name{ get; set; }
        [Required]
        public char Sex{ get; set; }
        [Required]
        public DateTime Birth{ get; set; }
        [Required]
        public int Age{ get; set; }
        [Required]
        public bool Child{ get; set; }
        [Required]
        public int Award{ get; set; }
        [Required]
        public int GroupNum { get; set; }
        
        
        public virtual Group Group{ get; set; }
        
        public virtual ICollection<Diploma> Diplomas { get; set; }
    }
}