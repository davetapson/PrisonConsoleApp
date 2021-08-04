using System;
using static PrisonConsoleApp.Common;

namespace PrisonConsoleApp
{
    public class Prisoner : Person
    {
        public Crime Crime { get; set; }
        public int SentenceLength { get; set; }
        public DateTime SentenceStartDate {  get; set; }
        
        public string DisplayDetails {
            get 
            {
                return $"{Id} {FirstName} {LastName} {Crime.ToString()}";
            }
        }
    }
}