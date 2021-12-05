using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Board
    {
        public Piece[] Squares = new Piece[64];
       
        public Board()
        {
            Squares[0] = new Rook(PieceColor.White);
            Squares[1] = new Knight(PieceColor.White);
            Squares[2] = new Bishop(PieceColor.White);
            Squares[3] = new Queen(PieceColor.White);
            Squares[4] = new King(PieceColor.White);
            Squares[5] = new Bishop(PieceColor.White);
            Squares[6] = new Knight(PieceColor.White);
            Squares[7] = new Rook(PieceColor.White);
            Squares[8] = new Pawn(PieceColor.White);
            Squares[9] = new Pawn(PieceColor.White);
            Squares[10] = new Pawn(PieceColor.White);
            Squares[11] = new Pawn(PieceColor.White);
            Squares[12] = new Pawn(PieceColor.White);
            Squares[13] = new Pawn(PieceColor.White);
            Squares[14] = new Pawn(PieceColor.White);
            Squares[15] = new Pawn(PieceColor.White);
            Squares[48] = new Pawn(PieceColor.Black);
            Squares[49] = new Pawn(PieceColor.Black);
            Squares[50] = new Pawn(PieceColor.Black);
            Squares[51] = new Pawn(PieceColor.Black);
            Squares[52] = new Pawn(PieceColor.Black);
            Squares[53] = new Pawn(PieceColor.Black);
            Squares[54] = new Pawn(PieceColor.Black);
            Squares[55] = new Pawn(PieceColor.Black);
            Squares[56] = new Rook(PieceColor.Black);
            Squares[57] = new Knight(PieceColor.Black);
            Squares[58] = new Bishop(PieceColor.Black);
            Squares[59] = new Queen(PieceColor.Black);
            Squares[60] = new King(PieceColor.Black);
            Squares[61] = new Bishop(PieceColor.Black);
            Squares[62] = new Knight(PieceColor.Black);
            Squares[63] = new Rook(PieceColor.Black);


        }

        public int GetIndex(string value)
        {
            int row = 0;
            int column = int.Parse(value[1].ToString());
            if(value[0] == 'A')
            {
                row = 0;
            }
            else if (value[0] == 'B')
            {
                row = 1;
            }
            else if (value[0] == 'C')
            {
                row = 2;
            }
            else if (value[0] == 'D')
            {
                row = 3;
            }
            else if (value[0] == 'E')
            {
                row = 4;
            }
            else if (value[0] == 'F')
            {
                row = 5;
            }
            else if (value[0] == 'G')
            {
                row = 6;
            }
            else if (value[0] == 'H')
            {
                row = 7;
            }
            int square = (column - 1) * 8 + row;
            
            return square;
        }

        public bool FindColor(int square, int x)
        {
            // Null araştır
            if(Squares[square] != null)
            {
                if (Squares[square].Color == PieceColor.White && x == 1)
                {
                    return true;
                }
                else if (Squares[square].Color == PieceColor.Black && x == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
