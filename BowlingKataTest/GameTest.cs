using System.Linq;
using BowlingKata;
using NUnit.Framework;

namespace BowlingKataTest
{
    public class GameTest : BaseGameTest
    {
        [Test]
        public void Score_NewGame_Returns0()
        {
            AssertScoreIsCorrectAfterSequence(0);
        }

        [Test]
        public void ScoreIsNumberOfPinsAfterFirstRoll()
        {
            const int numberOfPins = 9;

            AssertScoreIsCorrectAfterSequence(numberOfPins, numberOfPins);
        }

        [Test]
        public void ScoreIsSumOfPinsAfterTwoRolls()
        {
            const int numberOfPins1 = 2;
            const int numberOfPins2 = 7;

            AssertScoreIsCorrectAfterSequence(numberOfPins1 + numberOfPins2, numberOfPins1, numberOfPins2);
        }

        [Test]
        public void ScoreIsCorrectAfterSpareAndRoll()
        {
            const int numberOfPins11 = 9;
            const int numberOfPins12 = 1;
            const int numberOfPins2 = 5;
            const int firstTurnScore = numberOfPins11 + numberOfPins12 + numberOfPins2;

            AssertScoreIsCorrectAfterSequence(firstTurnScore + numberOfPins2, numberOfPins11, numberOfPins12, numberOfPins2);
        }

        [Test]
        public void SparesAreOnlyRollsInSameTurn()
        {
            AssertScoreIsCorrectAfterSequence(16, 1, 8, 2, 5);
        }

        [Test]
        public void ScoreIsCorrectAfterStrikeAndRoll()
        {
            AssertScoreIsCorrectAfterSequence(20, 10, 5);
        }


        private void AssertScoreIsCorrectAfterSequence(int expected, params int[] rolls)
        {
            rolls.ToList().ForEach(_game.Roll);
            int score = _game.Score();
            Assert.AreEqual(expected, score);
        }
    }
}
