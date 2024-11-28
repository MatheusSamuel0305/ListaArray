using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        int maior = numeros[0];
        int menor = numeros[0];

        foreach (int numero in numeros)
        {
            if (numero > maior)
                maior = numero;
            if (numero < menor)
                menor = numero;
        }

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Menor valor: " + menor);
    }
}
