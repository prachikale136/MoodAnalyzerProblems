using MoodAnalyzer;
namespace MoodAnalyzerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodReturn_Sad()
        {
            string expected = "Sad";
            //create a object of cass moodanalyzer with i am sad
            MoodAnalyze moodAnalyzer = new MoodAnalyze("I am Sad");
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }

        [TestMethod]
        public void GivenMood_should_Return_HAppy()
        {
            //expected string will be happy
            string expected = "Happy";
            //create a object of cass moodanalyzer with i am happy
            MoodAnalyze moodAnalyzer = new MoodAnalyze("I am Happy");
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
        }
    }
}