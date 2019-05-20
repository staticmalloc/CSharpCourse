

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataBase.Models
{
    public class FacultyCafedra
    {
        public int CafedraId { get; set; }
        public int FacultyId { get; set; }

        public virtual Cafedra Cafedra { get; set; }
        
        public virtual Faculty Faculty { get; set; }
    }
}