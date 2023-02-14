// See https://aka.ms/new-console-template for more information
using System;

namespace _03Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar objeto da classe aluno
            Aluno a = new Aluno();
            a.nome = "João";
            a.nota1 = 7;
            a.nota2 = 9;
            a.nota3 = 8;
            a.mensagem();
        }
    }
}

