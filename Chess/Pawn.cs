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
            int piecePath = fromIndex;

            if (Color == PieceColor.White)
            {
                while (toIndex > fromIndex)
                {
                    if (toIndex - fromIndex == 8 && board.Squares[toIndex] == null)
                    {
                        return true;
                    }
                    else if (toIndex - fromIndex == 16 && board.Squares[toIndex] == null && fromIndex <= 15 && fromIndex >= 8)
                    {
                        piecePath += 8;

                        if (toIndex == piecePath)
                        {
                            return true;
                        }
                        else if (piecePath < toIndex && board.Squares[piecePath] == null)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (toIndex - fromIndex == 9)
                    {
                        if (fromIndex % 8 == 7)
                        {
                            return false;
                        }
                        else if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.White)
                        {
                            return false;
                        }
                        else if (board.Squares[toIndex].Color == PieceColor.Black)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (toIndex - fromIndex == 7)
                    {
                        if (fromIndex % 8 == 0)
                        {
                            return false;
                        }
                        else if(board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.White)
                        {
                            return false;
                        }
                        else if (board.Squares[toIndex].Color == PieceColor.Black)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            if (Color == PieceColor.Black)
            {
                while (fromIndex > toIndex)
                {
                    if (fromIndex - toIndex == 8 && board.Squares[toIndex] == null)
                    {
                        return true;
                    }
                    else if (fromIndex - toIndex == 16 && board.Squares[toIndex] == null && fromIndex <= 55 && fromIndex >= 48)
                    {
                        piecePath -= 8;

                        if (toIndex == piecePath)
                        {
                            return true;
                        }
                        else if (piecePath > toIndex && board.Squares[piecePath] == null)
                        {
                            continue;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (fromIndex - toIndex == 9)
                    {
                        if (fromIndex % 8 == 0)
                        {
                            return false;
                        }
                        else if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.Black)
                        {
                            return false;
                        }
                        else if (board.Squares[toIndex].Color == PieceColor.White)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (fromIndex - toIndex == 7)
                    {
                        if (fromIndex % 8 == 7)
                        {
                            return false;
                        }
                        else if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.Black)
                        {
                            return false;
                        }
                        else if (board.Squares[toIndex].Color == PieceColor.White)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return false;
            }
            return false;
        }
    }
}
