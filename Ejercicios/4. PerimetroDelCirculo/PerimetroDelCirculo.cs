using System.Globalization;

namespace PerimetroDelCirculo;

class PerimetroDelCirculo
{
    static void Main()
    {
        Console.Write("Calcular el radio de un círculo y calcula su perímetro \n");
        Console.Write("Ingrese el valor del radio: ");
        double r = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double per = 2 * Math.PI * r;
        Console.WriteLine(per.ToString("0.00", CultureInfo.InvariantCulture));
    }
}
