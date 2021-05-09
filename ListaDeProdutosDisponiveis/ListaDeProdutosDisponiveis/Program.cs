using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            //lista de produtos que o mercado tem
            List<string> produtosDisponiveis = new List<string>()
            {
                "pão", "leite", "manteiga", "requeijão", "arroz", "alface", "tomate" , "frango", "refrigerante", "doce"
            };

            //validar se os argumentos foram preenchidos
            try
            {
                //listar quais produtos informados do argumento tem no mercado
                var produtosSelecionados = produtosDisponiveis.Where(produto => argumentos.Contains(produto)).ToList();
                foreach(var produtoSelecionado in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nós temos: {produtoSelecionado}");
                }

                var produtosNaoDisponiveis = argumentos.Where(argumento => !produtosDisponiveis.Contains(argumento)).ToList();
                foreach(var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nós não temos: {produtoNaoDisponivel}");
                }
            }catch(Exception)
            {
                Console.WriteLine("Argumentos inválidos");
            }
          
        }
    }
}
