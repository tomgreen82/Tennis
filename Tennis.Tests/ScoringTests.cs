using NUnit.Framework;

namespace Tennis.Tests
{
    public class Tests
    {
        private Scoring _scoring;
        [SetUp]
        public void Setup()
        {
            _scoring = new Scoring();
        }

        [Test]
        public void PrintScore_WhenBothPlayersHaveZero_ReturnLoveLove()
        {
            // Arrange
            var expectedResult = "love : love";
            var playerOneScore = 0;
            var playerTwoScore = 0;

            // Act
            var result = _scoring.PrintScore(playerOneScore, playerTwoScore);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}