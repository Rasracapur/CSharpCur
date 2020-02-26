using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Inferencia
    {
        public static void Executar()
        {
            var name = "Ulisses";
            //name = 123;
            Console.WriteLine(name);

            //int = 15
            var age = 15;
            Console.WriteLine("A idade é de " + age + " anos");

            int a;//Declarando a váriavel
            a = 25;//Inicializando a váriavel

            int b = 78;//Declarando e inicalizando a váriavel
            Console.WriteLine(a + b);
        }
    }
}
