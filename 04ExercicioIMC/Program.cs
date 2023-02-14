using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static public void Main(string[] args)
        {
            // instanciar o objeto da classe pessoa
            Pessoa p = new Pessoa();
            p.altura = 1.70;
            p.peso = 53;
            p.mensagem();
        }
    }
}