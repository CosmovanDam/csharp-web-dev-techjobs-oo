using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        // What fields do ALL FOUR of the classes have in common?
        // Id, nextId, and Value
        // Which constructors are the same in ALL FOUR classes?
        // Both
        // Which custom methods are identical in ALL of the classes?
        // 1 of them

        // The 3 fields common amongst the classes
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        // The 1 constructor common amongst the classes
        public JobField()
        {
            Id = nextId;
            nextId++;
        }

        public JobField(string value) : this()
        {
            Value = value;
        }

        // The 3 method overrides common amongst the classes
        public override bool Equals(object obj)
        {
            return obj is JobField field &&
                   Id == field.Id;
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
