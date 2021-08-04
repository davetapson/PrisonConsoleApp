using static PrisonConsoleApp.Common;

namespace PrisonConsoleApp
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public JobType Type { get; set; }
        public decimal Salary {  get; set; }
    }
}