using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in SAD Mood";
            MoodAnalize mood = new MoodAnalize(message);

            // Act
            string mood1 = mood.AnalizeMood();

            //Assert
            Assert.AreEqual(expected, mood1);
        }
    }
}