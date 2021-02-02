using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {

        
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
            
            Assert.AreEqual(field_setter.Id, 1);
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
    }
}

