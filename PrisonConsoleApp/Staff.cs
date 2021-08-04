using System;

namespace PrisonConsoleApp
{
    public class Staff : Person
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public Job Job { get; set; }

        public int DaysLeaveDue { get; set; }
    }
}
