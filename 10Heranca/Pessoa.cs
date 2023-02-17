using System;

class Pessoa
{
    // atributos para a classe pessoa
    protected string nome;
    protected int idade;

    // método
    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}