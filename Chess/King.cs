using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class King : Piece
    {
        public string Name { get; }

        public King(PieceColor color) : base(color)
        {
            Name = "King";
        }

        public override bool CanMove(int fromIndex, int toIndex, Board board)
        {
            return false;
        }
    }
}
