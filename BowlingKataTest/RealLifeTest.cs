using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BowlingKataTest
{
    public class RealLifeTest : BaseGameTest
    {
        [Test]
        public void ScoreIs270AfterTenStrikes()
        {
            for (int i = 0; i < 10; i++)
            {
                _game.Roll(10);
            }
            Assert.AreEqual(270, _game.Score());
        }

        [Test]
        public void ScoreIs290AfterElevenStrikes()
        {
            for (int i = 0; i < 11; i++)
            {
                _game.Roll(10);
            }
            Assert.AreEqual(290, _game.Score());
        }

        [Test]
        public void ThePerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                _game.Roll(10);
            }
            Assert.AreEqual(300, _game.Score());
        }

        [Test]
        public void ThePerfectGameAndMore()
        {
            for (int i = 0; i < 20; i++)
            {
                _game.Roll(10);
            }
            Assert.AreEqual(300, _game.Score());
        }

        [Test]
        public void ScoreIs240AfterNineStrikes()
        {
            for (int i = 0; i < 9; i++)
            {
                _game.Roll(10);
            }
            Assert.AreEqual(240, _game.Score());
        }
    }
}
