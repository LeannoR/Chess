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
            string Move;
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
                    Console.WriteLine("Lütfen hamlenizi yazınız");
                    Move = Console.ReadLine();
                    string[] Moves = Move.Split(' ');
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
