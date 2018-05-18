namespace TicTacToe
{
    public class BestMove
    {
        public int Score;
        public string Space;

        public BestMove(int bestScore, string bestPosition)
        {
            this.Score = bestScore;
            this.Space = bestPosition;
        }
    }
}