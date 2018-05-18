namespace TicTacToe
{
    public class BoardSpace
    {
        public Owner owner;
        public string position;

        public BoardSpace(Space space)
        {
            this.owner = BoardState.GetOwner(space.owner);
            this.position = space.SpaceName;
        }
    }
}