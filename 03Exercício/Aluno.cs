using System;

class Aluno
{
    // Atributos
    public string nome;
    public double nota1, nota2, nota3;

    // Média
    public double media()
    {
        return (nota1 + nota2 + nota3)/3;
    }

    // Situação
    public string situacao(double media)
    {
        return media >= 7 ? "aprovado" : "reprovado";
    }

    // Mensagem
    public void mensagem ()
    {   // obter média
        double obterMedia = media();

        // obter situação
        string obterSituacao = situacao(obterMedia);

        // Mensagem
        Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
    }
}