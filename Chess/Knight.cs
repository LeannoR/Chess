using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Knight : Piece
    {
        public override bool CanMove(string from, string to)
        {
            return false;
        }
    }
}
