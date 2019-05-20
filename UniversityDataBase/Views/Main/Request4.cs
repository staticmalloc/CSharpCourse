using System;

namespace UniversityDataBase.Views.Main
{
    public class Request4
    {
        public int Group { get; set; } = -1;

        public int Faculty { get; set; } = -1;

        public int Course { get; set; } = -1;

        public int Semester { get; set; } = -1;
        
        public DateTime Begin { get; set; }
        
        public DateTime End { get; set; }
    }
}