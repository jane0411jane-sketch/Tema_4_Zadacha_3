using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_4_Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine()); ;
            int c = Convert.ToInt32(Console.ReadLine()); ;
            int i = 0;
            int j = 0;
            if ((a < c) || (b < c))
                Console.WriteLine(0);
            else
            {

                while ((a > 0) || (b > 0))
                {
                    if (a - c >= 0)
                    { i++; }
                    a = a - c;
                    if (b - c >= 0)
                    { j++; }
                    b = b - c;
                }
                int k = 0;
                while (j > 0)
                {
                    k = k + i;
                    j = j - 1;
                }
                Console.WriteLine(k);
            }
            Console.ReadKey();

        }
    }
}
