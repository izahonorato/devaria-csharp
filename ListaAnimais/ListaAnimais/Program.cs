using ListaAnimais.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaAnimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor digitar o nome do animal para compararmos com a nossa base:");
            var nomeAnimal = Console.ReadLine();
            if(string.IsNullOrEmpty(nomeAnimal) || string.IsNullOrWhiteSpace(nomeAnimal))
            {
                Console.WriteLine("Favor passar um nome de animal vertebrado válido!");
                return;
            }

            var listaAnimais = new List<Animal>();
            listaAnimais.Add(new Mamifero() { Nome = "Vaca", qtdeMamas = 4 });
            listaAnimais.Add(new Reptil() { Nome = "Cobra" });
            listaAnimais.Add(new Ave() { Nome = "Gavião" });
            listaAnimais.Add(new Peixe() { Nome = "Tubarão", qtdeNadadeiras = 2 });

            var animalSelecionado = listaAnimais.FirstOrDefault(animal => animal.Nome.ToUpper() == nomeAnimal.ToUpper());

            if(animalSelecionado == null)
            {
                Console.WriteLine("Animal informado não está na nossa lista");
                return;
            }

            if(animalSelecionado is Mamifero)
            {
                Console.WriteLine($"O animal encontrado é um mamífero com nome {animalSelecionado.Nome} e quantidade de mamas = {((Mamifero)animalSelecionado).qtdeMamas}");
            }else if(animalSelecionado is Reptil)
            {
                Console.WriteLine($"O animal encontrado é um réptil com nome {animalSelecionado.Nome} e não controla sua temperatura = {((Reptil)animalSelecionado).ControlaTemperaturaCorpo}");
            }else if(animalSelecionado is Ave)
            {
                Console.WriteLine($"O animal encontrado é uma ave com nome {animalSelecionado.Nome} e tem penas = {((Ave)animalSelecionado).TemPena}");
            }else if(animalSelecionado is Peixe)
            {
                Console.WriteLine($"O animal encontrado é um peixe com nome {animalSelecionado.Nome} e tem nadadeiras = {((Peixe)animalSelecionado).qtdeNadadeiras}");
            }
            else
            {
                Console.WriteLine($"O animal encontrado é um animal e tem nome " + $"{animalSelecionado}");
            }
        }
    }
}
