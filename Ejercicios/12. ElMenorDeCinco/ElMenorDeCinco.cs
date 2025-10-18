namespace ElMenorDeCinco;

class ElMenorDeCinco
{
    static void Main()
    {
        int menor = int.MaxValue;
        Console.Write("Calcular el numero menor de 5 numeros \n");


        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Número {i}: ");
            int v = int.Parse(Console.ReadLine()!);
            if (v < menor) menor = v;
        }

        Console.WriteLine(menor);
    }
}
