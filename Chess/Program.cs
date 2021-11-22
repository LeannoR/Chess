using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            int x = 1;
            while (x <= 2)
            {
                //Pseudo Code

                //TODO: Beyaz sırası
                //Hamleyi sor 
                //Hamlenin yazısını al 
                //Hangi pozisyondan hangi pozisyona gideceğini bul (metod)
                //Board ilk pozisyondaki piece'i al
                //o piece 'e hedefe gidip gidemeyeceğini sor (parametre olarak: board + hedef konum)
                //eğer bir sıkıntı yoksa hareketi yap
                //eğer hedefteki taşı kırdıysan o taşı destroy et 
                if (x == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Lütfen hamlenizi yazınız");
                        var move = Console.ReadLine();
                        string[] moves = move.Split(' ');
                        string fromString = moves[0];
                        string toString = moves[1];
                        int fromIndex = board.GetIndex(fromString);
                        int toIndex = board.GetIndex(toString);
                        if (board.FindColor(fromIndex) == false)
                        {
                            Console.WriteLine("Yanlış hamle yaptınız");
                        }
                        else
                        {
                            var fromPiece = board.Squares[fromIndex];
                            fromPiece.CanMove(fromIndex, toIndex, board);
                            break;
                        }
                    }


                    x = 2;
                    return;
                }
                //TODO: Siyah sırası
                if (x == 2)
                {
                    Console.WriteLine("Lütfen hamlenizi yazınız");
                    x = 1;
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
