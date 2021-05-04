using System;

namespace estruturas_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0) //se for igual a 0 significa que a pessoa não digitou nada pois o tamanho dos argumentos é 0
            {
                Console.WriteLine("Favor, informar palavras no argumento!");
                    return;
            }
            //for
            for (var indice = 0; indice < args.Length; indice++)
            {
                Console.WriteLine($"Estrutura for, índice e valor: {indice}, {args[indice]}");
            }

            //while loop
            var argsLidos = 0;
            while (argsLidos < args.Length)
            {
                Console.WriteLine($"Estrutura while, argumentos lidos e valor lido: {argsLidos}, {args[argsLidos]}");
                argsLidos++;
            }

            //do while loop
            var loopsEfetuados = 0;
            do
            {
                Console.WriteLine($"Estrutura do while, loopsEfetuados e valor lido: {loopsEfetuados}, {args[loopsEfetuados]}");
                loopsEfetuados++;
            } while (loopsEfetuados < args.Length);

            //foreach
            foreach (var argumento in args)
            {
                Console.WriteLine($"Estrutura foreach, valor lido: {argumento}");
            }
        }
    }
}
