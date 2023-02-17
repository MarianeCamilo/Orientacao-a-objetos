using System;

class Colaborador : Pessoa
{
    // atributos
    private double salario;

    //construtor
    public Colaborador(string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // método para a função
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: " + salario);
    }
}