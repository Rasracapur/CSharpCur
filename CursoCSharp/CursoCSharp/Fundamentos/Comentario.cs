using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Comentario
    {
        static double Division(int a, double b)
        {
            double d = 0;
            d = a / b;
            return d;
        }

        /// <summary>
        /// 
        /// </summary>
        public static void Executar()
        {   //Cuidado com comentários desnessessauros
            Console.WriteLine("Código Claro é sempre melhor!");

            Console.WriteLine("o c# tem o xml coments");
            /*
             *Esse é um comentário
             * de 
             * múltiplas linhas
             */
            double d = Division(8, 3.141592);
            Console.WriteLine(d);
        }
    }
}
