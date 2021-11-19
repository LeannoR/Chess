using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {
        private Piece[] _squares = new Piece[64];

        public Board()
        {
            _squares[0] = new Rook();
            _squares[1] = new Knight();
            _squares[2] = new Bishop();
            _squares[3] = new Queen();
            _squares[4] = new King(PieceColor.Black);
            _squares[5] = new Bishop();
            _squares[6] = new Knight();
            _squares[7] = new Rook();
            _squares[8] = new Pawn();
            _squares[9] = new Pawn();
            _squares[10] = new Pawn();
            _squares[11] = new Pawn();
            _squares[12] = new Pawn();
            _squares[13] = new Pawn();
            _squares[14] = new Pawn();
            _squares[15] = new Pawn();
            _squares[16] = new Pawn();
            _squares[17] = new Pawn();
        }

        public void Update()
        {
            _squares[0].CanMove("A3", "B2");
            _squares[1].CanMove("A3", "B2");
            _squares[2].CanMove("A3", "B2");
        }
    }
}
