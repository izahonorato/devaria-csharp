using System;

namespace TesteVariávelConstante
{
    class Program
    {
        static void Main(string[] args)
        {
        //comentario de linha
        /*comentario varias linhas*/
            const string constante = "uma constante que não muda";

            if(args.Length == 0)
            {
                Console.WriteLine("Favor informar um número inteiro");
                return;
            }

            int inteiro;
            bool teste = int.TryParse(args[0], out inteiro);

            if(teste == false)
            {
                Console.WriteLine("O argumento informado não é um inteiro");
                return;
            }

            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi o: " + inteiro);
        }
    }
}
