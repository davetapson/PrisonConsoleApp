using System;
using System.Linq;
using static PrisonConsoleApp.Common;

namespace PrisonConsoleApp
{
    internal class Batch
    {
        public Prison Prison { get; set; }

        public Batch()
        {
            // life is too short to have to add Prisoners / Staff each time you run the app, 
            // so just auto-generate some on start up.
            Prison = new Prison {
                Id = 1,
                Name = "Alcatraz",
                Prisoners = DataUtil.MakePrisonerData(),
                Staffs = DataUtil.MakeStaffData(),
            };
        }

        public int NumberOfPrisoners { 
            get {
                return Prison.Prisoners.Count;
            } 
        }

        public int NumberOfStaff
        {
            get
            {
                return Prison.Staffs.Count;
            }
        }

        public void AddPrisoner()
        {
            Prisoner prisoner = new Prisoner();

            prisoner.Id = Prison.Prisoners.Select(x => x.Id).Max() + 1;

            Console.WriteLine("Prisoner First Name?");
            prisoner.FirstName = Console.ReadLine();

            Console.WriteLine("Prisoner Last Name?");
            prisoner.LastName = Console.ReadLine();
            
            Console.WriteLine("Prisoner Date of Birth 'yyyy-mm-dd'?");
            prisoner.DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Prisoner Crime?\r\nMurder = 0\r\nRobber = 1\r\nFraudster = 2\r\nSheep Shagger = 3");
            prisoner.Crime = (Crime)Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("Prisoner Sentence Length in months?");
            prisoner.SentenceLength = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Prisoner Sentence Start Date 'yyyy-mm-dd'?");
            prisoner.SentenceStartDate = Convert.ToDateTime(Console.ReadLine());

            Prison.Prisoners.Add(prisoner);

            Console.WriteLine($"Prisoner Id: {prisoner.Id} Name: {prisoner.FirstName} {prisoner.LastName} added to prison.");
        }

        internal void CountPrisoners()
        {
            throw new NotImplementedException();
        }

        internal void StaffWithNextBirthday()
        {
            throw new NotImplementedException();
        }

        internal void PrisonersByReleaseDate()
        {
            throw new NotImplementedException();
        }

        internal void CountOfStaffByJobType()
        {
            throw new NotImplementedException();
        }

        internal void PrisonersWhoShouldBeLetFree()
        {
            throw new NotImplementedException();
        }

        internal void CalculateWageBill()
        {
            throw new NotImplementedException();
        }

        internal void CountStaff()
        {
            throw new NotImplementedException();
        }

        internal void ListStaff()
        {
            throw new NotImplementedException();
        }

        internal void RemoveStaff()
        {
            throw new NotImplementedException();
        }

        internal void AddStaff()
        {
            throw new NotImplementedException();
        }

        internal void ListPrisoners()
        {
            Console.WriteLine("");
            Console.WriteLine($"List of prisoners in {Prison.Name}:");
            Console.WriteLine("");

            foreach (var prisoner in Prison.Prisoners)
            {
                Console.WriteLine(prisoner.DisplayDetails);
            }

            Console.WriteLine("");
        }

        public void RemovePrisoner()
        {
            int id;
            
            Console.WriteLine("Id of prisoner to remove?");
            id = Convert.ToInt32(Console.ReadLine());

            var prisoner = Prison.Prisoners.Where(x => x.Id == id).FirstOrDefault();

            if (prisoner != null)
            {
                Prison.Prisoners.Remove(prisoner);
                Console.WriteLine($"Prisoner Id: {id} Name: {prisoner.FirstName} {prisoner.LastName} removed.");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"There is no prisoner with the id: {id}");
            }
        }
    }
}