using BowlingKata;
using NUnit.Framework;

namespace BowlingKataTest
{
    public class GameTest
    {
        [Test]
        public void Score_NewGame_Returns0()
        {
            var game = new Game();

            var score = game.Score();

            Assert.AreEqual(0, score);
        }


        [Test]
        public void ScoreIsNumberOfPinsAfterFirstRoll()
        {
            Game game = new Game();

            const int numberOfPins = 9;
            game.Roll(numberOfPins);
            int score = game.Score();

            Assert.AreEqual(numberOfPins, score);
        }
    }
}
