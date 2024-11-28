using System;

class Program
{
    static void Main(string[] args)
    {
        int[] vetor1 = { 1, 2, 3, 4, 5 };
        int[] vetor2 = { 5, 4, 3, 2, 1 };
        int[] vetorSoma = new int[vetor1.Length];

        for (int i = 0; i < vetor1.Length; i++)
        {
            vetorSoma[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("Vetor resultante da soma:");
        foreach (int valor in vetorSoma)
        {
            Console.WriteLine(valor);
        }
    }
}
