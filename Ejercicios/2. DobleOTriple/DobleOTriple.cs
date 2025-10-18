namespace DobleOTriple;

class DobleOTriple
{
    static void Main()
    {

          Console.Write("Calcular de dos numeros si el 1ro es > calcule su doble si no el triple del segundo \n");
        Console.Write("Ingrese el primer número: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese el segundo número: ");
        int b = int.Parse(Console.ReadLine()!);

        if (a > b) Console.WriteLine(2 * a);
        else Console.WriteLine(3 * b);
    }
}
