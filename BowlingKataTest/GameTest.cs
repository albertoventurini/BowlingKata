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


    }
}
