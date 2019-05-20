using System;
using System.Collections.Generic;

namespace UniversityDataBase.Models
{
    public class Session
    {
        public Session()
        {
            Journals = new HashSet<Journal>();
        }
        
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        
        public virtual ICollection<Journal> Journals { get; set; }
    }
}