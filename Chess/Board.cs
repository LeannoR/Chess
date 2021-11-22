using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {
        public Piece[] _squares = new Piece[64];
       
        public Board()
        {
            _squares[0] = new Rook(PieceColor.White);
            _squares[1] = new Knight(PieceColor.White);
            _squares[2] = new Bishop(PieceColor.White);
            _squares[3] = new Queen(PieceColor.White);
            _squares[4] = new King(PieceColor.White);
            _squares[5] = new Bishop(PieceColor.White);
            _squares[6] = new Knight(PieceColor.White);
            _squares[7] = new Rook(PieceColor.White);
            _squares[8] = new Pawn(PieceColor.White);
            _squares[9] = new Pawn(PieceColor.White);
            _squares[10] = new Pawn(PieceColor.White);
            _squares[11] = new Pawn(PieceColor.White);
            _squares[12] = new Pawn(PieceColor.White);
            _squares[13] = new Pawn(PieceColor.White);
            _squares[14] = new Pawn(PieceColor.White);
            _squares[15] = new Pawn(PieceColor.White);
            _squares[48] = new Pawn(PieceColor.Black);
            _squares[49] = new Pawn(PieceColor.Black);
            _squares[50] = new Pawn(PieceColor.Black);
            _squares[51] = new Pawn(PieceColor.Black);
            _squares[52] = new Pawn(PieceColor.Black);
            _squares[53] = new Pawn(PieceColor.Black);
            _squares[54] = new Pawn(PieceColor.Black);
            _squares[55] = new Pawn(PieceColor.Black);
            _squares[56] = new Rook(PieceColor.Black);
            _squares[57] = new Knight(PieceColor.Black);
            _squares[58] = new Bishop(PieceColor.Black);
            _squares[59] = new Queen(PieceColor.Black);
            _squares[60] = new King(PieceColor.Black);
            _squares[61] = new Bishop(PieceColor.Black);
            _squares[62] = new Knight(PieceColor.Black);
            _squares[63] = new Rook(PieceColor.Black);


        }

        public void Update()
        {
            _squares[0].CanMove("A3", "B2");
            _squares[1].CanMove("A3", "B2");
            _squares[2].CanMove("A3", "B2");
        }
        
    }
}
