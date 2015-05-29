using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BowlingKata;
using NUnit.Framework;

namespace BowlingKataTest
{
    public  class BaseGameTest
    {
        protected Game _game;

        [SetUp]
        public void initNewGame()
        {
            _game = new Game();
        }
    }
}
