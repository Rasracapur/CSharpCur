using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotaçãoPonto
    {
        public static void Executar() 
        {
            string saudação = "olá".ToUpper().Insert(3, " World!!!").Replace("World", "Mundo");
            Console.WriteLine(saudação.ToUpper());
            Console.WriteLine(saudação.Length);
            Console.WriteLine();

            string valorInportante = null;
            Console.WriteLine(valorInportante?.Length);

            
        }
    }
}
