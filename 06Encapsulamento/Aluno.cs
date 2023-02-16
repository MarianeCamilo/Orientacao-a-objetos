using System;

class Aluno
{
    // atributos
    private double nota1, nota2;

    // media
    private double media()
    {
        return (nota1 + nota2)/2;
    }

    // mensagem
    public void mensagem()
    {
        // double obterMedia = media();

        Console.WriteLine("Informe a primeira nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Informe a segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A média é " + media());
    }
}