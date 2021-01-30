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
    }
}
