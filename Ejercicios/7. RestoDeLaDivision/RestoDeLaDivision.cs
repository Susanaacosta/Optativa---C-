namespace RestoDeLaDivision;

class RestoDeLaDivision
{
    static void Main()
    {
        Console.Write("Calcule el residuo de la division del primero entre el segundo\n");
        Console.Write("Ingrese un numero que corresponderá al dividendo: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Ingrese un numero que correspondera al divisor: ");
        int b = int.Parse(Console.ReadLine()!);

        if (b == 0) Console.WriteLine("El divisor no puede ser 0");
        else Console.WriteLine(a % b);
    }
}
