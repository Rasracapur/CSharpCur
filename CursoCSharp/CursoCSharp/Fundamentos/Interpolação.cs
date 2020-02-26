using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolação
    {
        public static void Executar()
        {
            string name = "Notebook Gamer";
            string marca = "Dell";
            double preço = 12_000.58;

            Console.WriteLine("O " + name + " da marca " + marca + " custa R$" + preço);
            Console.WriteLine("O {0} da marca {1} custa R${2}", name, marca, preço);
            Console.WriteLine($"O {name} da marca {marca} custa R${preço}");
            Console.WriteLine($"A {marca} é legal!");
            Console.WriteLine($"1 + 1 = {1 + 1}");//Interpolção

        }
    }
}
