using ListaProdutosMercadoClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaProdutosMercadoClasses
{
    class Program
    {
        static void Main(string[] argumentos)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.90 });
            produtosDisponiveis.Add(new Produto() { Nome = "Azeite", Preco = 14.50 });
            produtosDisponiveis.Add(new Produto() { Nome = "Refrigerante", Preco = 6.25 });
            produtosDisponiveis.Add(new Produto() { Nome = "Queijo", Preco = 12.75 });
            produtosDisponiveis.Add(new Produto() { Nome = "Carne", Preco = 25.99 });

            if (argumentos.Length == 0)
            {
                Console.WriteLine("Você não passou os produtos que deseja comprar");
                return;
            }

            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(produto => argumentos.Any(argumento => 
            produto.Nome.ToUpper() == argumento.ToUpper()));

            foreach(var produto in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nós temos: {produto.ExibirDadosProduto()}");
            }

            var produtosSelecionadosNaoDisponiveis = argumentos.Where(argumento => !produtosDisponiveis.Any(produto =>
            produto.Nome.ToUpper() == argumento.ToUpper()));

            foreach(var produtoNaoDisponivel in produtosSelecionadosNaoDisponiveis)
            {
                Console.WriteLine($"Este produto nós não temos: {produtoNaoDisponivel}");
            }

            var produtosOrdenados = produtosDisponiveis.OrderBy(produto => produto.Nome).ToList();

            Console.WriteLine("Confira nossos produtos disponíveis: ");

            foreach(var produtoOrdenado in produtosOrdenados)
            {
                Console.WriteLine(produtoOrdenado.ExibirDadosProduto());
            }


        }
    }
}
