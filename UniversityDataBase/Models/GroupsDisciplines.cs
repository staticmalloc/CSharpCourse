namespace UniversityDataBase.Models
{
    public class GroupsDisciplines
    {
        public int GroupId { get; set; }
        
        public int DisciplineId { get; set; }

        public virtual Group Group { get; set; }
        
        public virtual Discipline Discipline { get; set; }
    }
}