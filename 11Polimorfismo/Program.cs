using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar estagiário
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(500);
            objetoE.valeTransporte(300);
            Console.WriteLine("__________________");

            // instanciar gerente
            Imposto objetoG = new Gerente();
            objetoG.valeAlimentacao(2500);
            objetoG.valeTransporte(800);
            Console.WriteLine("__________________");

            // instanciar atendente
            Imposto objetoA = new Atendente();
            objetoA.valeAlimentacao(1500);
            objetoA.valeTransporte(500);
            Console.WriteLine("__________________");

        }
    }
}