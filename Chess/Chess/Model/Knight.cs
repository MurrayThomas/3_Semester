using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Model
{
    public class Knight : Piece
    {
        public Knight(bool isWhite) : base(isWhite) { }

        public override void MoveTo(Position position)
        {
            Position = position;
            HasMoved = true;
        }

        public override List<Move> GetLegalMoves(Board board, int x, int y)
        {
            var moves = new List<Move>();
            // Knight moves in L-shape: 2 squares in one direction, 1 in perpendicular
            int[][] knightMoves = new int[][]
            {
                new int[] { 2, 1 }, new int[] { 2, -1 },
                new int[] { -2, 1 }, new int[] { -2, -1 },
                new int[] { 1, 2 }, new int[] { 1, -2 },
                new int[] { -1, 2 }, new int[] { -1, -2 }
            };

            foreach (var move in knightMoves)
            {
                int newX = x + move[0];
                int newY = y + move[1];

                if (IsWithinBounds(newX, newY))
                {
                    var targetPiece = board.GetPieceAt(newX, newY);
                    if (targetPiece == null || targetPiece.IsWhite != IsWhite)
                        moves.Add(new Move(board, this, x, y, newX, newY));
                }
            }

            return moves;
        }

        private bool IsWithinBounds(int x, int y)
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }
    }
}
