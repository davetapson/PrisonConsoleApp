using System.Collections.Generic;

namespace PrisonConsoleApp
{
    public class Prison
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Prisoner> Prisoners { get; set; }
        public List<Staff> Staffs { get; set; }
    }
}