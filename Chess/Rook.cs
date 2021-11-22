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
        public override bool CanMove(string from, string to)
        {
            return true;
        }
        
    }
}
