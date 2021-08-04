using System;

namespace PrisonConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Batch batch = new();

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
                    case "Add P":
                        batch.AddPrisoner();
                        break;
                    case "Remove P":
                        batch.RemovePrisoner();
                        break;
                    case "Add S":
                        batch.AddStaff();
                        break;
                    case "Remove S":
                        batch.RemoveStaff();
                        break;
                    case "List P":
                        batch.ListPrisoners();
                        break;
                    case "List S":
                        batch.ListStaff();
                        break;
                    case "Number P":
                        batch.ListStaff();
                        break;
                    case "Number S":
                        batch.CountStaff();
                        break;
                    case "Calculate Wage Bill":
                        batch.CalculateWageBill();
                        break;
                    case "Prisoners who should be set free":
                        batch.PrisonersWhoShouldBeLetFree();
                        break;
                    case "Staff with next birthday":
                        batch.StaffWithNextBirthday();
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
