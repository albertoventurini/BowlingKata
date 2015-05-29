namespace BowlingKata
{
    public class Turn
    {
        private int _numberOfRolls;
        private readonly int[] _rolls;
        private int _score;

        public Turn()
        {
            _rolls = new int[2];
        }

        public int Score()
        {
            return _score;
        }

        public void Update(int pins)
        {
            if (!IsFinished())
            {
                _rolls[_numberOfRolls] = pins;
            }

            if (IsUpdateable())
            {
                _score += pins;
            }
            _numberOfRolls++;
            
        }

        private bool IsUpdateable()
        {
            return !IsFinished() || ((IsSpare() || IsStrike()) && _numberOfRolls < 3);
        }

        private bool IsSpare()
        {
            return !IsStrike() && (_rolls[0] + _rolls[1] == 10);
        }


        public bool IsFinished()
        {
            return _numberOfRolls >= 2 || IsStrike();
        }

        private bool IsStrike()
        {
            return _rolls[0] == 10;
        }
    }
}
