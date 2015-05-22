namespace BowlingKata
{
    public class Game
    {
        private int _score = 0;

        public int Score()
        {
            return _score;
        }

        public void Roll(int pins)
        {
            _score += pins;
        }
    }
}
