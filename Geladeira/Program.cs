using System;
using Geladeira.Classes;

namespace Geladeira
{
    class Program
    {
        static void Main(string[] args)
        {
            Prest p1 = new Prest();

            Console.WriteLine("Qual o produto desejado?");
            p1.name = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto desejado?");
            p1.preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade de prestações que deseja pagar?");
            p1.prest = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"\nO seu produto é: {p1.name}");
            Console.WriteLine($"\nO preço real dele é {p1.preco}");
            Console.WriteLine($"\nVocê escolheu pagar em {p1.prest} prestações");

            float vp = p1.preco/p1.prest;
            Console.WriteLine($"Cada prestação terá o preço de {vp}");

            Console.WriteLine($"\nCada prestação terá o acréscimo de 5%");

            double acre = (float) (vp * (0.05 * (p1.prest - 1)));
            Console.WriteLine($"Cada acréscimo terá o valor de: R${acre}");

            Console.WriteLine($"Você pagará por mês R$ {vp} + ({acre})");

            double total = (float)((vp + acre) * p1.prest);
            Console.WriteLine($"Você pagará ao todo o total de: R$ {total}");

        }
    }
}
