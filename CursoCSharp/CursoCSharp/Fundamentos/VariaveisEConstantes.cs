using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            //Área da Circunferencia
            double raio = 4.5;//valores decimais
            const double PI = 3.141592_653589_793238_462643_383279;//constante, não muda seu valor ao decorrer do programa

            raio = 5.5;
            //PI = 3.141592;

            double area = PI * (raio * raio);
            Console.WriteLine(area);
            Console.WriteLine("A área é igual a " + (area + 1000));

            Console.WriteLine();

            /*
             * Tipos Internos
             * 
             */

            //Tipos booleanos

            bool estaChovendo = true;//tipo booleano => true or false
            Console.WriteLine("Está chovendo?\n" + estaChovendo);

            //Tipos Inteiros

            byte idade = 15;//tipo de inteiro com o menor valor
            Console.WriteLine("A idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;//tipo de inteiro de menor valor com sinal
            Console.WriteLine(saldoDeGols);

            short salario = short.MaxValue;//segundo menor tipo inteiro
            Console.WriteLine("O salário é de " + salario);

            int menorValInt = int.MinValue;//Mais usado dos inteiros
            Console.WriteLine("O menor valor dos inteiros é " + menorValInt);

            uint popBrasil = 207_600_000;//Inteiro sem sinal
            Console.WriteLine("A população brasileira é de " + popBrasil + " pessoas");

            long menorLong = long.MinValue;
            Console.WriteLine("O long é " + menorLong);

            ulong mundoPop = 7_766_657_700;
            Console.WriteLine("A população mundial é de " + mundoPop);

            //Tipos Reais
            float preçoDoComputador = 2512.98f;
            Console.WriteLine("O preço do computador é de " + preçoDoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.0000_123;//Mais usado dos reais
            Console.WriteLine("O valor de mercado da apple é de " + valorDeMercadoDaApple);

            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("A distância entre duas estrelas é de " + distanciaEntreAsEstrelas);

            //Textos
            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string texto = "Seja bem vindo ao curso C#";
            Console.WriteLine(texto);
        }
    }
}
