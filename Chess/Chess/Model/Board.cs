namespace Chess.Model
{
    public class Board
    {
        public Board() 
        {
            string PieceSet = whiteSet + blackSet;
        }
        public Board(int id) { }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


    }
}