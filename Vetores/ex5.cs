using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[4, 4];
        Random random = new Random();
        int maior = int.MinValue;

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = random.Next(1, 101);
                if (matriz[i, j] > maior)
                    maior = matriz[i, j];
            }
        }

        Console.WriteLine("Matriz gerada:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Maior valor na matriz: " + maior);
    }
}
