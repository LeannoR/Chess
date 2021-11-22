using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public abstract class Piece
    {
        public PieceColor Color { get; }

        public Piece(PieceColor color)
        {
            this.Color = color;
        }

        public abstract bool CanMove(string from, string to);
    }
}
