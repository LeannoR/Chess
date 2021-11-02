using System;
using System.Collections.Generic;

namespace Bankacılık
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankamıza hoşgeldiniz lütfen yapmak istediğiniz işlemi seçiniz");
            Operations O = new Operations();
            for (; ; )
            {
                O.Menu1();
                if (O.Menu1() == 1)
                {
                    O.Signup();
                }
                if (O.Menu1() == 2)
                {
                    O.Login();
                }
                if (O.Menu1() == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Bankamızı kullandığınız için teşekkür ederiz, yine bekleriz");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
