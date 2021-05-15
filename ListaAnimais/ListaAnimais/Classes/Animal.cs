using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAnimais.Classes
{
    class Animal //classe pai que passa o atributo nome como herança
    {
        internal Mamifero qtdeMamas;

        public string Nome { get; set; }
    }
    class Mamifero : Animal //os dois pontos dizem que mamifero é classe filha de animal
    {
        public int qtdeMamas { get; set; }
    }

    class Reptil : Animal
    {
        public bool ControlaTemperaturaCorpo { get; set; } = false;
    }

    class Ave : Animal
    {
        public bool TemPena { get; set; } = true;
    }

    class Peixe : Animal
    {
        public int qtdeNadadeiras { get; set; }
    }
}
