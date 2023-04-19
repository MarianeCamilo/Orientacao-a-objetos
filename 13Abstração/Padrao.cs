using System;

abstract  class Padrao
{
    // obrigadtório
    public abstract void taxaEmprestimo(double valor);

    // opcional
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
    }
}