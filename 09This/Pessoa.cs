using System;

class Pessoa
{
    // atributo
    private string nome = "João";

    // construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome); //o This está relacionado ao atributo
    }


}