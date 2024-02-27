using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade em anos: ");
            int Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua idade em meses, sem considerar os anos: ");
            int Meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua idade em dias, sem considerar os meses: ");
            int Dia = int.Parse(Console.ReadLine());

            int Idade = (Ano * 365) + (Meses * 30) + Dia;

            Console.WriteLine("A sua idade em dias é de: " + Idade);

            Console.ReadKey();
        }

    }
}
