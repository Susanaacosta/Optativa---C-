using System.Globalization;

namespace CalculadoraDeImpuestos;

class CalculadoraDeImpuestos
{
    static void Main()
    {
         Console.Write("Acorde al salario si este excede los 12000, muestra el impuesto a pagar que es el 15% del excedente\n");
        
        Console.Write("Ingrese su salario anual: ");
        double salario = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        if (salario > 12000)
        {
            double imp = (salario - 12000) * 0.15;
            Console.WriteLine(imp.ToString("0.##", CultureInfo.InvariantCulture));
        }
        else Console.WriteLine("No debe impuestos actualmente");
    }
}
