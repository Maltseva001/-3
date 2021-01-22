using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;
            Console.WriteLine("введите число N");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int a = 1 ; a < N ; ++a)
            {
                v = 2*1/a;
                Console.WriteLine("2*1/" + a + "=" + v);
            }
            v = 2 * 1 / N;
            Console.WriteLine("2*1/" + N + "=" + v);
            Console.ReadKey();
        }
    }
}
