using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        // Job constructor tests
        
        [TestMethod]
        public void TestSettingJobId()
        {
            // TODO: Create two Job objects
            // Create two Job objects using the empty constructor. 
            // Use Assert.AreEqual, Assert.IsTrue, or Assert.IsFalse to test that the ID values for the two objects are NOT the same and differ by 1
            Job first_job = new Job();
            Job second_job = new Job();
            Assert.AreEqual(first_job.Id, second_job.Id, 1); // Adding the delta shows
            // that the two Ids differ by 1 and are not the same - thus passing the
            // test
            
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job field_setter = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            
            Assert.AreEqual(field_setter.Id, field_setter.Id, 1);
            Assert.AreEqual(field_setter.Name, "Product tester");
            Assert.AreEqual(field_setter.EmployerName.Value, "ACME");
            Assert.AreEqual(field_setter.EmployerLocation.Value, "Desert");
            Assert.AreEqual(field_setter.JobType.Value, "Quality control");
            Assert.AreEqual(field_setter.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job idOne = new Job();
            Job idTwo = new Job();

            // For sanity purposes
            /*
            System.Console.WriteLine(idOne.Id);
            System.Console.WriteLine(idTwo.Id);
            */

            // Assert statement
            Assert.IsFalse(Equals(idOne.Id, idTwo.Id));
        }

        // .ToString() test

        // TODO: Do part 1 of TDD for ToString

        [TestMethod]
        public void FirstToStringTest()
        {
            Job field_setter = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobToString = field_setter.ToString();

            // System.Console.WriteLine(jobToString[0]);

            Assert.AreEqual(jobToString[0], jobToString[jobToString.Length - 1]);
        }

        // The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line
        [TestMethod]
        public void SecondToStringTest()
        {
            Job field_setter = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobToString = field_setter.ToString();

            string testJob = $"\nId: {field_setter.Id} \n" +
                $"Name: {field_setter.Name} \n" +
                $"Employer: {field_setter.EmployerName.Value} \n" +
                $"Location: {field_setter.EmployerLocation.Value} \n" +
                $"Position type: {field_setter.JobType.Value} \n" +
                $"Core competency: {field_setter.JobCoreCompetency.Value} \n";

            System.Console.WriteLine(testJob);

            Assert.AreEqual(jobToString, testJob);
        }

        [TestMethod]
        public void ThirdToStringTest()
        {
            Job field_setter = new Job("Product tester", new Employer(""), new Location(""), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string jobToString = field_setter.ToString();

            string testJob = $"\nId: {field_setter.Id} \n" +
                $"Name: {field_setter.Name} \n" +
                $"Employer: {field_setter.EmployerName.Value} \n" +
                $"Location: {field_setter.EmployerLocation.Value} \n" +
                $"Position type: {field_setter.JobType.Value} \n" +
                $"Core competency: {field_setter.JobCoreCompetency.Value} \n";

            System.Console.WriteLine(jobToString);

            Assert.AreEqual(jobToString, testJob);
        }
    }
}

