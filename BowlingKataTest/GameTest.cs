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
    }
}
