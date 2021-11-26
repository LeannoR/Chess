using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Pawn : Piece
    {
        public Pawn(PieceColor color) : base(color)
        {

        }
        public override bool CanMove(int fromIndex , int toIndex , Board board)
        {   //Geçerken alma kuralını uygula
            // Piyonun önünde taş varsa gitmemeli
            if(Color == PieceColor.White)
            {
                if(toIndex - fromIndex == 8 || ((toIndex <= 15 && toIndex >= 8) && (toIndex - fromIndex == 16)))
                {
                    return true;
                }
                if((toIndex - fromIndex == 9 || toIndex - fromIndex == 7) && (board.Squares[toIndex].Color == PieceColor.Black) && (fromIndex % 8 == 0 || fromIndex % 8 == 7))
                {
                    return true;
                }
            }
            else
            {
                if(fromIndex - toIndex == 8 || ((fromIndex >= 48 && fromIndex <= 55) && (fromIndex - toIndex == 16)))
                {
                    return true;
                }
                if ((fromIndex - toIndex == 9 || fromIndex - toIndex == 7) && (board.Squares[toIndex].Color == PieceColor.White) && (fromIndex % 8 == 0 || fromIndex % 8 == 7))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
