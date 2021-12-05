using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Bishop : Piece
    {
        public Bishop(PieceColor color) : base(color)
        {

        }
        public override bool CanMove(int fromIndex , int toIndex , Board board)
        {
            int piecePath = fromIndex;

            if (Color == PieceColor.White)
            {
                while (toIndex > fromIndex)
                {
                    if ((toIndex - fromIndex) % 7 == 0)
                    {
                        piecePath += 7;

                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if(piecePath < toIndex)
                        {
                            if(board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if(board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((toIndex - fromIndex) % 9 == 0)
                    {
                        piecePath += 9;
                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (piecePath < toIndex)
                        {
                            if (board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if (board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                while (fromIndex > toIndex)
                {
                    if ((fromIndex - toIndex) % 7 == 0)
                    {
                        piecePath -= 7;

                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (toIndex < piecePath)
                        {
                            if (board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if (board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((fromIndex - toIndex) % 9 == 0)
                    {
                        piecePath -= 9;
                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (toIndex < piecePath)
                        {
                            if (board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if (board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if (Color == PieceColor.Black)
            {
                while (toIndex > fromIndex)
                {
                    if ((toIndex - fromIndex) % 7 == 0)
                    {
                        piecePath += 7;

                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (piecePath < toIndex)
                        {
                            if (board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if (board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((toIndex - fromIndex) % 9 == 0)
                    {
                        piecePath += 9;
                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (piecePath < toIndex)
                        {
                            if (board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if (board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                while (fromIndex > toIndex)
                {
                    if ((fromIndex - toIndex) % 7 == 0)
                    {
                        piecePath -= 7;

                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (toIndex < piecePath)
                        {
                            if (board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if (board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((fromIndex - toIndex) % 9 == 0)
                    {
                        piecePath -= 9;
                        if (piecePath == toIndex)
                        {
                            if (board.Squares[toIndex] == null || board.Squares[toIndex].Color == PieceColor.White)
                            {
                                return true;
                            }
                            else if (board.Squares[toIndex].Color == PieceColor.Black)
                            {
                                return false;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else if (toIndex < piecePath)
                        {
                            if (board.Squares[piecePath] == null)
                            {
                                continue;
                            }
                            else if (board.Squares[piecePath].Color == PieceColor.White || board.Squares[piecePath].Color == PieceColor.Black || piecePath % 8 == 0 || piecePath % 8 == 7)
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        return false;
        }
    }
}
