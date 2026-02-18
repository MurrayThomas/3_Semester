namespace Chess.Model
{
    public class Move
    {
        public Move() { }
        public Move(Board board, Piece piece, int fromX, int fromY, int toX, int toY)
        {
            Board = board;
            Piece = piece;
            FromX = fromX;
            FromY = fromY;
            ToX = toX;
            ToY = toY;
        }

        public int Id { get; set; }
        public Board Board { get; set; }
        public Piece Piece { get; set; }
        public int FromX { get; set; }
        public int FromY { get; set; }
        public int ToX { get; set; }
        public int ToY { get; set; }
    }
}