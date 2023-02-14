using System;

class Pessoa
{   
    // atributos
    public double peso, altura;

    // método para retornar IMC
    public double calculo()
    {
        return (peso / (altura * altura));
    }

    public string situacao(double imc)
    {
        string retorno;

        if(imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if(imc < 25)
        {
            retorno = "Peso normal";
        }
        else if(imc < 30)
        {
            retorno = "Acima do peso";
        }
        else if(imc < 35)
        {
            retorno = "Obesidade I";
        }
        else if(imc < 40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }

        return retorno;
    }

    public void mensagem()
    {
        double obterCalculo = calculo();

        string obterSituacao = situacao(obterCalculo);

        Console.WriteLine("Você está com o IMC " + obterCalculo);
        Console.WriteLine("Sua situaçõ é de " + obterSituacao);
    }

}