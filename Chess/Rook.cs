using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Rook : Piece
    {
        public Rook(PieceColor color) : base(color)
        {

        }
        public override bool CanMove(int fromIndex, int toIndex, Board board)
        {
            return true;
        }
        
    }
}
