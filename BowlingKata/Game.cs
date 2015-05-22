﻿using System;

namespace BowlingKata
{
    public class Game
    {
        private int _score = 0;
        private int _lastRoll;
        private Boolean _lastTurnWasSpare = false;

        public int Score()
        {
            return _score;
        }

        public void Roll(int pins)
        {
            _score += pins;
            if (_lastTurnWasSpare)
            {
                _score += pins;
                _lastTurnWasSpare = false;
            }
            if (pins + _lastRoll == 10)
            {
                _lastTurnWasSpare = true;
            }
            _lastRoll = pins;
        }
    }
}
