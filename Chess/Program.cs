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

            while (true)
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
                if (board.IsOver)
                {
                    return;
                }
                //TODO: Siyah sırası
                if (board.IsOver)
                {
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
