using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        // OR ||   and &&

        string TextoAdicional;
        
        if (acompanhado == true) 
        {
            Console.WriteLine("João está acompanhado");
        }
        else 
        {
        Console.WriteLine("João nâo está acompanhado");
        }


        if (idadeJoao >= 18 || acompanhado)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
