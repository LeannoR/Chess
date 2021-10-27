using System;
using System.Collections.Generic;
using System.Text;

namespace Bankacılık
{
    public class Operations
    {
        public void Menu()
        {
            int number = 0;
            Console.Clear();
            Console.WriteLine("Lütfen seçiniz");
            Console.WriteLine("1- Yeni kayıt oluşturma");
            Console.WriteLine("2- Giriş yapma");
            Console.WriteLine("3- Çıkış");

            switch (number)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Kullanıcı adı : ");
                    Console.WriteLine("İsim : ");
                    Console.WriteLine("Soyisim : ");
                    break;
                
                case 2:
                    Console.Clear();
                    Console.WriteLine("Kullanıcı adı : ");
                    Console.WriteLine("Ne islem yapmak istersiniz?");
                    Console.WriteLine("Para yatırma");
                    Console.WriteLine("Para çekme");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Bankamızı kullandığınız için teşekkür ederiz, yine bekleriz");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Bankamızı kullandığınız için teşekkür ederiz, yine bekleriz");
                    break;

            }
        }
    }
}
