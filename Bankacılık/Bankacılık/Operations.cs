using System;
using System.Collections.Generic;
using System.Text;

namespace Bankacılık
{
    public class Operations
    {
        public int Menu1()
        {
            Console.WriteLine("Lütfen seçiniz");
            Console.WriteLine("1- Yeni kayıt oluşturma");
            Console.WriteLine("2- Giriş yapma");
            Console.WriteLine("3- Çıkış");
            string strnumber = Console.ReadLine();
            int number = Convert.ToInt32(strnumber);
            return number;
        }
        public string Signup()
        {
            string username = "";
            string name = "";
            string surname = "";
            Console.Clear();
            Console.Write("Kullanıcı adı : ");
            username = Console.ReadLine();
            Console.Write("İsim : ");
            name = Console.ReadLine();
            Console.Write("Soyisim : ");
            surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Kaydınız oluşturulmuştur " + name + " " + surname);
            return username;

        }
        public string Login()
        {
            Console.Clear();
            Console.WriteLine("Kullanıcı adı : ");
            return Console.ReadLine();
        }
    }
}

  
