using System;
class Program
{
    static void Main()
    {
        int acertos = 0;
        acertos += FazerPergunta("Qual a capital do Brasil?", "brasilia");
        Console.WriteLine("\nPróxima pergunta...\n");
        acertos += FazerPergunta("Qual a capital do Chile?", "santiago");
        Console.WriteLine($"\nVocê acertou {acertos} de 2 perguntas.");
    }
    static int FazerPergunta(string pergunta, string respostaCorreta)
    {
        Console.WriteLine(pergunta);
        Console.Write("Digite sua resposta: ");
        string resposta = Console.ReadLine().Trim().ToLower();
        if (resposta == respostaCorreta.ToLower())
        {
            Console.WriteLine("Você acertou!");
            return 1;
        }
        else
        {
            Console.WriteLine($"Você errou! A resposta correta é: {respostaCorreta}");
            return 0;
        }
    }
}