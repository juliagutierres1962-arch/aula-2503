using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO9
{
    internal class Program
    {
        static void Main(string[] args)
        { int n1, n2, n3, media;
            Console.WriteLine("escolha um valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escolha um valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("escolha um valor: ");
            n3 = int.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("a media do aluno é: " + media);


        }
    }
}
