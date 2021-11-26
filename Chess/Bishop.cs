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
            if (Color == PieceColor.White)
            {
                while (toIndex > fromIndex)
                {
                    if ((toIndex - fromIndex) % 8 == 7)
                    {
                        fromIndex += 7;

                        if (fromIndex == toIndex)
                        {
                            if((board.Squares[toIndex].Color == PieceColor.Black) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if(fromIndex < toIndex)
                        {
                            if(board.Squares[fromIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((toIndex - fromIndex) % 8 == 1)
                    {
                        fromIndex += 9;
                        if (fromIndex == toIndex)
                        {
                            if ((board.Squares[toIndex].Color == PieceColor.Black) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if (fromIndex < toIndex)
                        {
                            if (board.Squares[fromIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                }
                while (fromIndex > toIndex)
                {
                    if ((fromIndex - toIndex) % 8 == 7)
                    {
                        toIndex += 7;

                        if (fromIndex == toIndex)
                        {
                            if ((board.Squares[toIndex].Color == PieceColor.Black) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if (toIndex < fromIndex)
                        {
                            if (board.Squares[toIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((fromIndex - toIndex) % 8 == 1)
                    {
                        toIndex += 9;
                        if (fromIndex == toIndex)
                        {
                            if ((board.Squares[toIndex].Color == PieceColor.Black) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if (toIndex < fromIndex)
                        {
                            if (board.Squares[toIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            if (Color == PieceColor.Black)
            {
                while (toIndex > fromIndex)
                {
                    if ((toIndex - fromIndex) % 8 == 7)
                    {
                        fromIndex += 7;

                        if (fromIndex == toIndex)
                        {
                            if ((board.Squares[toIndex].Color == PieceColor.White) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if (fromIndex < toIndex)
                        {
                            if (board.Squares[fromIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((toIndex - fromIndex) % 8 == 1)
                    {
                        fromIndex += 9;
                        if (fromIndex == toIndex)
                        {
                            if ((board.Squares[toIndex].Color == PieceColor.White) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if (fromIndex < toIndex)
                        {
                            if (board.Squares[fromIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                }
                while (fromIndex > toIndex)
                {
                    if ((fromIndex - toIndex) % 8 == 7)
                    {
                        toIndex += 7;

                        if (fromIndex == toIndex)
                        {
                            if ((board.Squares[toIndex].Color == PieceColor.White) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if (toIndex < fromIndex)
                        {
                            if (board.Squares[toIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                    else if ((fromIndex - toIndex) % 8 == 1)
                    {
                        toIndex += 9;
                        if (fromIndex == toIndex)
                        {
                            if ((board.Squares[toIndex].Color == PieceColor.White) || board.Squares[toIndex] == null)
                            {
                                return true;
                            }
                        }
                        else if (toIndex < fromIndex)
                        {
                            if (board.Squares[toIndex] != null)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
        return false;
        }
    }
}
