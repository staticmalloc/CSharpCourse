using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityDataBase.Models
{
    public class Cafedra
    {
        public Cafedra()
        {
            Disciplines = new HashSet<Discipline>();
            Teachers = new HashSet<Teacher>();
            FacultyCafedras= new HashSet<FacultyCafedra>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Discipline> Disciplines { get; set; }
        
        public virtual ICollection<Teacher> Teachers { get; set; }
        
        public virtual ICollection<FacultyCafedra> FacultyCafedras { get; set; }
    }
}