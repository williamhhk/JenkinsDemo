

using NUnit.Framework;

namespace JenkinsDemo.Test
{


    [TestFixture]
    public class TestJenkins
    {
        [Test]
        public void TestCase_One()
        {
            // Arrange
            var one = 1;
            var two = 2;
            var sum = 3;

            //  Act
            var result = one + two;

            //  Assert
            Assert.AreEqual(result, sum);
        }
    }
}
