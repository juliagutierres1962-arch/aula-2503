using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeatual, idadefuturo;
            Console.WriteLine("coloque aqui a sua idade atual: ");
            idadeatual = int.Parse(Console.ReadLine());
            idadefuturo = idadeatual + 10;
            Console.WriteLine("daqui dez anos voce tera: " + idadefuturo);

        }
    }
}
