using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Bankacılık
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankamıza hoşgeldiniz lütfen yapmak istediğiniz işlemi seçiniz");
            Operations O = new Operations();
            List<string> usernames = new List<string>();
            string username = "";
            int number = 0;
            Loop:
            number = O.Menu1();
                if (number == 1)
                {
                    username = O.Signup();
                    usernames.Add(username);
                    goto Loop;
                }
                else if (number == 2)
                {
                    bool control = usernames.Any(i => i == O.Login());
                    if (control == true)
                    {
                        Console.WriteLine("Giriş başarılı");
                        Console.WriteLine("1- Para Yatırma");
                        Console.WriteLine("2- Para Çekme");
                        string strnumber = Console.ReadLine();
                        int number1 = Convert.ToInt32(strnumber);
                    if(1 == number1)
                    {

                    }
                    else if(2 == number1)
                    {

                    }
                    }
                    else
                    {
                        Console.WriteLine("Giriş yapamadınız");
                    goto Loop;
                    }
                }
                else if (number == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Bankamızı kullandığınız için teşekkür ederiz, yine bekleriz");
                }
                Console.ReadLine();
        }
    }
}
