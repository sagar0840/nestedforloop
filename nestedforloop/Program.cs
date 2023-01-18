using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedforloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5; j++) // column
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            }
        }
}
