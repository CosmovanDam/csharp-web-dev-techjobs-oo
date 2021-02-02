using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        // Code a constructor to initialize the id field with a unique value
        public Job ()
        {
            Id = nextId;
            nextId++;
        }

        // Code a second constructor that takes 5 parameters and assigns values to name, employerName, 
        // employerLocation, jobType, and jobCoreCompetency
        public Job (string name, Employer employerName, Location employerLocation, PositionType jobType,
            CoreCompetency jobCoreCompetency) : this()
        {
            
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;

        }

        // TODO: Generate Equals() and GetHashCode() methods

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Use TDD to create this ToString method properly

        // The first test only checks if the returned string starts and ends with a blank line, make that happen
        // The second test the string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line
        // If a field is empty, the method should add, “Data not available” after the label
        // If else 

        public override string ToString()
        {
            if (Name == null || Name == "")
            {
                Name = "Data is not available.";
            }
            
            if (EmployerName.Value == null || EmployerName.Value == "")
            {
                EmployerName.Value = "Data is not available.";
            } 
            
            if (EmployerLocation.Value == null || EmployerLocation.Value == "")
            {
                EmployerLocation.Value = "Data is not available.";
            }
            
            if (JobType.Value == null || JobType.Value == "")
            {
                JobType.Value = "Data is not available";
            }
            
            if (JobCoreCompetency.Value == null || JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = "Data is not available";
            }

            return $"\nId: {Id} \n" +
                $"Name: {Name} \n" +
                $"Employer: {EmployerName.Value} \n" +
                $"Location: {EmployerLocation.Value} \n" +
                $"Position type: {JobType.Value} \n" +
                $"Core competency: {JobCoreCompetency.Value} \n"; ;
        }


    }
}
