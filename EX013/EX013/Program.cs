using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("digite um numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite outro numero: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 > n2) { Console.WriteLine("o numero maior é: "+ n1); }
            else { Console.WriteLine("o maior numero é: " + n2); }
        }
    }
}
