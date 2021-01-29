using System;
namespace TechJobsOO
{
    public class Employer
    {
        public int Id { get; }
        // Declares nextId as a static field that is not stored within any Employer object
        private static int nextId = 1;
        public string Value { get; set; }

        // Accepts no arguments and assigns the value of nextId to the Id field. It then increments nextId.
        // Thus, every new Employer object will get a different Id number
        public Employer()
        {
            Id = nextId;
            nextId++;
        }

        // Assigns the value field. It ALSO initiliazes Id for the object by calling the first constructor
        // statement with the : this() syntax. Including : this() in any Employer constructor makes initializing
        // Id a default behavior. This is known as constructor chaining.
        public Employer(string value) : this()
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
