using System;
using System.Collections.Generic;

namespace PrisonConsoleApp
{
    internal static class DataUtil
    {
        internal static List<Staff> MakeStaffData() {

            var staff = new List<Staff> {
                    new Staff {
                        // Person properties    
                        Id = 1,
                        FirstName = "Bob",
                        LastName = "Smith",
                        DateOfBirth = new DateTime(1970, 2, 3),
                        // Staff properties
                        DaysLeaveDue = 0,
                        StartDate = new DateTime(2000, 1, 1),
                        EndDate = null,
                        Job = new Job {
                            Id = 1,
                            Name = "Chief Warden",
                            Type = Common.JobType.Manager,
                            Salary = 1000000
                        }
                    },
                    new Staff {
                        // Person properties    
                        Id = 2,
                        FirstName = "Jim",
                        LastName = "Brown",
                        DateOfBirth = new DateTime(1977, 7, 7),
                        // Staff properties
                        DaysLeaveDue = 0,
                        StartDate = new DateTime(2016, 3, 7),
                        EndDate = null,
                        Job = new Job {
                            Id = 2,
                            Name = "High Security Guard",
                            Type = Common.JobType.Guard,
                            Salary = 200000
                        }
                    },
                    new Staff {
                        // Person properties    
                        Id = 3,
                        FirstName = "Daniel",
                        LastName = "Boon",
                        DateOfBirth = new DateTime(1969, 6, 9),
                        // Staff properties
                        DaysLeaveDue = 0,
                        StartDate = new DateTime(1975, 7, 5),
                        EndDate = null,
                        Job = new Job {
                            Id = 3,
                            Name = "Chief Warden",
                            Type = Common.JobType.Hangman,
                            Salary = 900000
                        }
                    },
                                        new Staff {
                        // Person properties    
                        Id = 4,
                        FirstName = "Philemon",
                        LastName = "Dlamini",
                        DateOfBirth = new DateTime(1981, 1, 2),
                        // Staff properties
                        DaysLeaveDue = 0,
                        StartDate = new DateTime(2011, 1, 1),
                        EndDate = null,
                        Job = new Job {
                            Id = 4,
                            Name = "Cleaner",
                            Type = Common.JobType.Cleaner,
                            Salary = 10000
                        }
                    }
            };

            return staff;
        }

        internal static List<Prisoner> MakePrisonerData()
        {
            var prisoners = new List<Prisoner> 
            { 
                new Prisoner{
                    // Person properties    
                    Id = 5,
                    FirstName = "Jack",
                    LastName = "Ripper",
                    DateOfBirth = new DateTime(1991, 1, 2),
                    // Prisoner properties
                    Crime = Common.Crime.Fraudster,
                    SentenceLength = 100,
                    SentenceStartDate = new DateTime(2020, 2 , 3)
                 },
                new Prisoner{
                    // Person properties    
                    Id = 6,
                    FirstName = "Jeffey",
                    LastName = "Dhamer",
                    DateOfBirth = new DateTime(1982, 2, 8),
                    // Prisoner properties
                    Crime = Common.Crime.Murderer,
                    SentenceLength = 1000,
                    SentenceStartDate = new DateTime(2019, 8 , 4)
                 },
                new Prisoner{
                    // Person properties    
                    Id = 7,
                    FirstName = "Jim",
                    LastName = "West",
                    DateOfBirth = new DateTime(1999, 9, 2),
                    // Prisoner properties
                    Crime = Common.Crime.Robber,
                    SentenceLength = 99
                 },
                new Prisoner{
                    // Person properties    
                    Id = 8,
                    FirstName = "Hansie",
                    LastName = "Cronje",
                    DateOfBirth = new DateTime(1981, 10, 20),
                    // Prisoner properties
                    Crime = Common.Crime.SheepShagger,
                    SentenceLength = 99
                 },
                new Prisoner{
                    // Person properties    
                    Id = 9,
                    FirstName = "Shane",
                    LastName = "Warne",
                    DateOfBirth = new DateTime(1986, 10, 20),
                    // Prisoner properties
                    Crime = Common.Crime.SheepShagger,
                    SentenceLength = 999
                 },
                new Prisoner{
                    // Person properties    
                    Id = 8,
                    FirstName = "Hansie",
                    LastName = "Cronje",
                    DateOfBirth = new DateTime(1981, 10, 20),
                    // Prisoner properties
                    Crime = Common.Crime.SheepShagger,
                    SentenceLength = 99
                 },
            };

            return prisoners;
        }
    }
}
