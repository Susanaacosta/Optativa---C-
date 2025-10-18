namespace Factorial;

class Factorial
{
    static void Main()
    {
        Console.Write("Calcular el valor de un numero factorial \n");
        Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n < 0) { Console.WriteLine("Inválido"); return; }

        long f = 1;
        for (int i = 2; i <= n; i++) f *= i;

        Console.WriteLine(f);
    }
}
