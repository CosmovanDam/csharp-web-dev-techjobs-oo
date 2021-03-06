﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {

        public CoreCompetency(string value) : base(value)
        {
            Value = value;
        }

        // Unrefactored code
        /*
        private int id;
        public int Id // Turned into an auto-implemented property using { get; set; }
        {
            get { return id; }
            internal set { id = Id; }
        }
        private static int nextId = 1;
        private readonly string value;
        public string Value // Turned into an auto-implemented property using { get; set; }
        {
            get { return value; }
            internal set { Value = value; }
        }

        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            id = nextId;
            nextId++;
        }

        public CoreCompetency(string v) : this()
        {
            value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   id == competency.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }

        public override string ToString()
        {
            return value;
        }
        */
    }
}
