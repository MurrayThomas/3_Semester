using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public class Pawn : Piece
    {
        public Pawn(bool isWhite) : base(isWhite) { }
        public override void MoveTo(Position position)
        {
            Position = position;
            HasMoved = true;
        }
        public override List<Move> GetLegalMoves(Board board, int x, int y)
        {
            var moves = new List<Move>();
            int direction = IsWhite ? -1 : 1;
            // Move forward
            if (IsValidMove(board, x, y + direction))
                moves.Add(new Move(board, this, x, y, x, y + direction));
            // First move can be two squares
            if (!HasMoved && IsValidMove(board, x, y + 2 * direction))
                moves.Add(new Move(board, this, x, y, x, y + 2 * direction));
            // Capture diagonally
            if (IsValidCapture(board, x - 1, y + direction))
                moves.Add(new Move(board, this, x, y, x - 1, y + direction));
            if (IsValidCapture(board, x + 1, y + direction))
                moves.Add(new Move(board, this, x, y, x + 1, y + direction));
            return moves;
        }
        private bool IsValidMove(Board board, int x, int y)
        {
            // Check if the move is within bounds and the target square is empty
            return IsWithinBounds(x, y) && board.GetPieceAt(x, y) == null;
        }
        private bool IsValidCapture(Board board, int x, int y)
        {
            // Check if the move is within bounds and the target square has an opponent's piece
            var targetPiece = board.GetPieceAt(x, y);
            return IsWithinBounds(x, y) && targetPiece != null && targetPiece.IsWhite != IsWhite;
        }
        private bool IsWithinBounds(int x, int y)
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }
    }
}
