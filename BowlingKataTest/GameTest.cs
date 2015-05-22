using BowlingKata;
using NUnit.Framework;

namespace BowlingKataTest
{
    public class GameTest
    {
        private Game _game;

        [SetUp]
        public void initNewGame()
        {
            _game = new Game();
        }

        [Test]
        public void Score_NewGame_Returns0()
        {
            var score = _game.Score();

            Assert.AreEqual(0, score);
        }

        [Test]
        public void ScoreIsNumberOfPinsAfterFirstRoll()
        {
            const int numberOfPins = 9;
            _game.Roll(numberOfPins);
            int score = _game.Score();

            Assert.AreEqual(numberOfPins, score);
        }

        [Test]
        public void ScoreIsSumOfPinsAfterTwoRolls()
        {
            const int numberOfPins1 = 9;
            const int numberOfPins2 = 7;

            _game.Roll(numberOfPins1);
            _game.Roll(numberOfPins2);
            int score = _game.Score();

            Assert.AreEqual(numberOfPins1 + numberOfPins2, score);
        }
    }
}
