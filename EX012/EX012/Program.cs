using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 ==0) { Console.WriteLine("o numero é par: "); }
            else { Console.WriteLine("o numero é impar: "); }

        }
    }
}
