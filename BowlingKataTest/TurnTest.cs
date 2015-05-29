using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingKata;
using NUnit.Framework;

namespace BowlingKataTest
{

    public class TurnTest
    {
        [Test]
        public void ScoreForNewTurnIsZero()
        {
            Assert.AreEqual(0, new Turn().Score());
        }

        [Test]
        public void ScoreAfterSingleRollIsTheNumberOfPins()
        {
            Turn turn = new Turn();
            turn.Update(7);
            Assert.AreEqual(7, turn.Score());
        }

        [Test]
        public void ScoreAfterTwoRollsIsTheSum()
        {
            Turn turn = new Turn();
            turn.Update(7);
            turn.Update(2);
            Assert.AreEqual(9, turn.Score());
        }

        [Test]
        public void TurnAfterOneRollIsNotFinished()
        {
            Turn turn = new Turn();
            turn.Update(2);
            Assert.IsFalse(turn.IsFinished());
        }

        [Test]
        public void TurnAfterTwoRollIsFinished()
        {
            Turn turn = new Turn();
            turn.Update(2);
            turn.Update(6);
            Assert.IsTrue(turn.IsFinished());
        }

        [Test]
        public void TurnAfterStrikeIsFinished()
        {
            Turn turn = new Turn();
            turn.Update(10);
            Assert.IsTrue(turn.IsFinished());
        }
    }
}
