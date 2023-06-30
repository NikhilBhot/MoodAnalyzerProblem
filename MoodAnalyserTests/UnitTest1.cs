using MoodAnalyzer;

namespace MoodAnalyserTests
{
    /*Given a Message, ability
to analyse and respond
Happy or Sad Mood - Create MoodAnalyser Object - Call analyseMood function with message as
parameter and return Happy or Sad Mood
 */
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood_WithHappyMessage_ReturnsHappyMood()
        {
            // Arrange
            string message = "I am feeling happy";
            MoodAnalyser analyser = new MoodAnalyser(message);

            // Act
            string mood = analyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Happy Mood", mood);
        }

        [TestMethod]
        public void AnalyseMood_WithSadMessage_ReturnsSadMood()
        {
            // Arrange
            string message = "I am feeling sad";
            MoodAnalyser analyser = new MoodAnalyser(message);

            // Act
            string mood = analyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Sad Mood", mood);
        }

        [TestMethod]
        public void AnalyseMood_WithUnknownMessage_ReturnsUnknownMood()
        {
            // Arrange
            string message = "I am feeling excited";
            MoodAnalyser analyser = new MoodAnalyser(message);

            // Act
            string mood = analyser.AnalyseMood();

            // Assert
            Assert.AreEqual("Unknown Mood", mood);
        }
    }
}