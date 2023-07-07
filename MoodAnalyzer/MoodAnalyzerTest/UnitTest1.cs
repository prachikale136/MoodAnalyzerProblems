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
            string result = moodAnalyzer.AnalyzeMood(expected);
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GivenMood_should_Return_HAppy()
        {
            //expected string will be happy
            string expected = "Happy";
            //create a object of cass moodanalyzer with i am happy
            MoodAnalyze moodAnalyzer = new MoodAnalyze("I am Happy");
            string result = moodAnalyzer.AnalyzeMood(expected);
            //assertion is a boolean expression at a specific point in a program 
            Assert.AreEqual(expected, result);
        }
        public void GivenNullMoodShouldReturnHappy()
        {
            try
            {
                //expected string will be happy
                string expected = "Happy";
                //create a object of cass moodanalyzer with Null value
                MoodAnalyze moodAnalyzer = new MoodAnalyze(null);
                //assertion is a boolean expression at a specific point in a program 
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual(MoodAnalyzerCustomException.ExceptionsType.NULL_MESSAGE, e.type);
            }
        }
        [TestMethod]
        // [DataRow(" ")]
        public void GivenEmptyMood_ShouldThrow_MoodAnalysisEmptyTypeException()
        {
            try
            {
                string expected = "Happy";
                string message = "";
                MoodAnalyze moodAnalyzer = new MoodAnalyze(message);
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Message should not be Empty", e.Message);
            }
        }
        [TestMethod]
        // [DataRow(null)]
        public void GivenNullMood_ShouldThrow_MoodAnalysisEmptyTypeException()
        {
            try
            {
                string expected = "Happy";
                string message = null;
                MoodAnalyze moodAnalyzer = new MoodAnalyze(message);
                Assert.AreEqual(expected, moodAnalyzer.AnalyzeMood());
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Message should not be Null", e.Message);
            }
        }

        public void GivenMoodClassNAme-ShouldReturn_MoodObject()
        {
            object expected = new MoodAnalyze();
            object result = MoodAnalyzerFactory.CreateMoodAnalyzer("MoodAnalyzer.Mood");
            expected.Equals(result);

        }
    }
}