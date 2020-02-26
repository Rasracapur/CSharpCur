using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentario.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência de tipos - Fundamentos", Inferencia.Executar},
                {"Interpolação de Strings - Fundamentos", Interpolação.Executar},
                {"Notação Ponto - Fundamentos", NotaçãoPonto.Executar},
                {"Lendo Dados no Console - Fundamentos", LendoDados.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}