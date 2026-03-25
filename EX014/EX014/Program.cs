using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Digite o primeiro numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3){ Console.WriteLine("O maior numero é: " + n1); }
            else if (n2 > n1 && n2 > n3){ Console.WriteLine("O maior numero é: " + n2); }
            else if (n3 > n1 && n3>n2) { Console.WriteLine("O maior numero é: "+ n3); }
        }
    }
}
