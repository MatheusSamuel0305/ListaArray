using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Elementos do vetor:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
