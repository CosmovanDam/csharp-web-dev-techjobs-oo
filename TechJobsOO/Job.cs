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
        public Job (string name, string employerName, string employerLocation, string jobType,
            string jobCoreCompetency) : this()
        {
            name = Name;
            employerName = EmployerName.Value;
            employerLocation = EmployerLocation.Value;
            jobType = JobType.Value;
            jobCoreCompetency = JobCoreCompetency.Value;
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

        .

    }
}
