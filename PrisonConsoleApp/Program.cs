using System;

namespace PrisonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch batch = new();  // bad name.  Could be PrisonManager PrisonEngine...  something.

            Console.WriteLine("");
            Console.WriteLine("Welcome to Prison. You can check in, but you can never leave.");
            Console.WriteLine("");

            bool carryOn = true;

            string input;

            while (carryOn)
            {
                WriteInstructions();

                input = Console.ReadLine();

                switch (input)
                {
                    case "a":
                    case "Add P":
                        batch.AddPrisoner();
                        break;
                    case "b":
                    case "Remove P":
                        batch.RemovePrisoner();
                        break;
                    case "c":
                    case "Add S":
                        batch.AddStaff();
                        break;
                    case "d":
                    case "Remove S":
                        batch.RemoveStaff();
                        break;
                    case "e":
                    case "List P":
                        batch.ListPrisoners();
                        break;
                    case "f":
                    case "List S":
                        batch.ListStaff();
                        break;
                    case "g":
                    case "Number P":
                        batch.CountPrisoners();
                        break;
                    case "h":
                    case "Number S":
                        batch.CountStaff();
                        break;
                    case "i":
                    case "Calculate Wage Bill":
                        batch.CalculateWageBill();
                        break;
                    case "j":
                    case "Prisoners who should be set free":
                        batch.PrisonersWhoShouldBeLetFree();
                        break;
                    case "k":
                    case "Staff with next birthday":
                        batch.StaffWithNextBirthday();
                        break;
                    case "l":
                    case "Prisoner List sorted by release date":
                        batch.PrisonersByReleaseDate();
                        break;
                    case "m":
                    case "Count of staff by Job Type":
                        batch.CountOfStaffByJobType();
                        break;
                    case "x":
                        carryOn = false;
                        break;
                    default:
                        Console.WriteLine($"Instruction {input} is not recognised.");
                        Console.WriteLine("");
                        break;
                };
            }
        }

        private static void WriteInstructions()
        {
            // these can be extended to cover the above, but I'd not bother.
            Console.WriteLine("");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("To add prisoner, enter 'Add P'.");
            Console.WriteLine("To remove prisoner, enter 'Remove P'.");
            Console.WriteLine("To add prisoner, enter 'Add S'.");
            Console.WriteLine("To remove prisoner, enter 'Remove S'.");
            Console.WriteLine("");
            Console.WriteLine("To display prisoners, enter 'List P'.");
            Console.WriteLine("To display staff, enter 'List S'.");
            Console.WriteLine("");
            Console.WriteLine("Enter 'x' to exit.");
            Console.WriteLine("_______________________________________");
            Console.WriteLine("");
        }
    }
}
