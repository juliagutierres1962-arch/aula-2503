using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("digite seu numero: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 > 0)  { Console.WriteLine("seu numero é positivo. "); }
            else if (num1 < 0) 
            { Console.WriteLine("seu numero é negativo. "); }
            else { Console.WriteLine("seu numero é 0. "); }

        }
    }
}
