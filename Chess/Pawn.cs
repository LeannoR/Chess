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
        {
            // TODO: İlk hareketinde pawn 2 kere gidebilmeli
            // Piyon çaprazında taş varsa oraya gidebilmeli
            // Piyonun önünde taş varsa gitmemeli
            if(Color == PieceColor.White)
            {
                if(toIndex - fromIndex == 8)
                {
                    return true;
                }
            }
            else
            {
                if(fromIndex - toIndex == 8)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
