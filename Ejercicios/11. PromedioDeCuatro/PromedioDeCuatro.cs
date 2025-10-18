using System.Globalization;

namespace PromedioDeCuatro;

class PromedioDeCuatro
{
    static void Main()
    {
        double a, b, c, d;
        Console.Write("Calcular el promedio de 4 numeros \n");
        Console.Write("Ingrese el primer numero: ");
        a = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Ingrese el segundo numero: ");
        b = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Ingrese el tercer numero: ");
        c = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        Console.Write("Ingrese el cuarto numero: ");
        d = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double prom = (a + b + c + d) / 4.0;
        Console.WriteLine(prom.ToString("0.##", CultureInfo.InvariantCulture));
    }
}
