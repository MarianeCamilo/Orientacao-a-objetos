using System;

namespace _08GetSet
{
    class GetSet
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            // p.Nome; -> GET, obter informação
            // p.Nome = "Mari"; -> SET, enviando informação

            p.Nome = "Mari";
            Console.WriteLine(p.Nome);

        }
    }
}