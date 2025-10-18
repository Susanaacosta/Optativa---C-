using System.Globalization;

namespace RaizOCuadrado;

class RaizOCuadrado
{
    static void Main()
    {
        Console.Write("Soliicte un # si es positivo obtendras su raiz de lo contrario su cuadrado\n");
        Console.Write("Ingrese un número: ");
        double n = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        if (n > 0) Console.WriteLine(Math.Sqrt(n).ToString("0.##", CultureInfo.InvariantCulture));
        else if (n == 0) Console.WriteLine("0");
        else Console.WriteLine((n * n).ToString("0.##", CultureInfo.InvariantCulture));
    }
}
