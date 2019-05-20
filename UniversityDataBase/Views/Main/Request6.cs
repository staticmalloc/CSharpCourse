using System;

namespace UniversityDataBase.Views.Main
{
    public class Request6
    {
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Type3 { get; set; }
        
        public int Group { get; set; } = -1;

        public int Faculty { get; set; } = -1;

        public int Course { get; set; } = -1;

        public int Semester { get; set; } = -1;
        
        public DateTime Begin { get; set; }
        
        public DateTime End { get; set; }
    }
}