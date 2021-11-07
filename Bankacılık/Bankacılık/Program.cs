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
            List<user> userinfo = new List<user>();
            //string username = "";
            int number = 0;
            Loop:
            number = O.Menu1();
                if (number == 1)
                {
                userinfo.Add(new user()
                {
                    money = 0,
                    usernames = O.Signup()
                });
                    goto Loop;
                }
                else if (number == 2)
                {
                    bool control = userinfo.Any(user => user.usernames == O.Login());
                    if (control == true)
                    {
                        Console.WriteLine("Giriş başarılı");
                        Console.WriteLine("1- Para Yatırma");
                        Console.WriteLine("2- Para Çekme");
                        string strnumber = Console.ReadLine();
                        int number1 = Convert.ToInt32(strnumber);
                    if(1 == number1)
                    {
                        foreach (user item in userinfo)
                        {
                            Console.WriteLine("Bakiyeniz : " + item.money);
                        }
                        Console.WriteLine("Yatırmak istediğiniz miktarı giriniz");
                        string addstr = Console.ReadLine();
                        int add = Convert.ToInt32(addstr);
                        userinfo.Where(user => user.money == user.money).ToList().ForEach(user => user.money = user.money + add);
                        foreach (user item in userinfo)
                        {
                            Console.WriteLine("Yeni bakiyeniz : " + item.money);
                        }
                        goto Loop;
                    }
                    else if(2 == number1)
                    {
                        foreach (user item in userinfo)
                        {
                            Console.WriteLine("Bakiyeniz : " + item.money);
                        }
                        Console.WriteLine("Çekmek istediğiniz miktarı giriniz");
                        string addstr = Console.ReadLine();
                        int add = Convert.ToInt32(addstr);
                        userinfo.Where(user => user.money == user.money).ToList().ForEach(user => user.money = user.money - add);
                        foreach (user item in userinfo)
                        {
                            Console.WriteLine("Yeni bakiyeniz : " + item.money);
                        }
                        goto Loop;
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
