using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int limit = 7;

            for (int i = 1; i < limit; i++)
            {
                num = num * i;
                Console.WriteLine("num = {0} and i = {1}", num, i);
            }
        }
    }
}
