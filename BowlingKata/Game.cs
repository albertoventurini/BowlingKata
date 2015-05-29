using System.Collections.Generic;
using System.Linq;

namespace BowlingKata
{
    public class Game
    {
        private Turn _currentTurn;
        private readonly List<Turn> _turns;

        public Game()
        {
            _currentTurn = new Turn();
            _turns = new List<Turn> {_currentTurn};
        }

        public int Score()
        {
            return _turns.Sum(x => x.Score());
        }

        public void Roll(int pins)
        {
            _turns.ForEach(x => x.Update(pins));
            if (_currentTurn.IsFinished())
            {
                if (_turns.Count() < 10)
                {
                    _currentTurn = new Turn();
                    _turns.Add(_currentTurn);
                }
            }
        }
    }
}
