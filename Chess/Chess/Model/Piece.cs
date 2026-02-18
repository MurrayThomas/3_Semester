using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public abstract class Piece
    {
        public Piece(bool isWhite)
        {
            IsWhite = isWhite;
            HasMoved = false;
        }
        public bool IsWhite { get; set; }
        public bool HasMoved { get; set; }
        public Position Position { get; set; }
        public abstract void MoveTo(Position position);

        public abstract List<Move> GetLegalMoves(Board board, int x, int y);

        
    }
}
