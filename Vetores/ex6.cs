using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
        };

        Console.WriteLine("Propriedades disponíveis para busca: Nome, Espécie, Idade, Peso");
        Console.Write("Digite a propriedade pela qual deseja buscar: ");
        string propriedade = Console.ReadLine()?.ToLower();

        int coluna;
        switch (propriedade)
        {
            case "nome":
                coluna = 0;
                break;
            case "espécie":
            case "especie":
                coluna = 1;
                break;
            case "idade":
                coluna = 2;
                break;
            case "peso":
                coluna = 3;
                break;
            default:
                Console.WriteLine("Propriedade inválida.");
                return;
        }

        Console.Write("Digite o valor para buscar: ");
        string valorBusca = Console.ReadLine();

        Console.WriteLine("\nResultados da busca:");
        bool encontrado = false;

        for (int i = 0; i < animais.GetLength(0); i++)
        {
            if (animais[i, coluna].Equals(valorBusca, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Nome: {animais[i, 0]}, Espécie: {animais[i, 1]}, Idade: {animais[i, 2]}, Peso: {animais[i, 3]}");
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Nenhum animal encontrado com o valor informado.");
        }
    }
}
