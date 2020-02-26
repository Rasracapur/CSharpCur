using System;
using System.Globalization;//Para usar o "." ao invés da "," na parte decimal

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar() 
        {
            Console.WriteLine("Qual é o seu nome?");
            //Console.ReadLine lê os dados de entrada, são sempre strings
            var name = Console.ReadLine();
            Console.WriteLine("Qual é a sua idade?");
            //int.Parse converte uma string em um int, para pegar valores inteiros
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu salário?");
            //double.Parse converte uma string em um double, para pegar valores reais
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{name}, {age}, R${sal}");
        }
    }
}
