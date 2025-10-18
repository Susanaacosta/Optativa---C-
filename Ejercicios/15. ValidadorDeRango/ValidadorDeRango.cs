namespace ValidadorDeRango;

class ValidadorDeRango
{
    static void Main()

    {
        Console.Write("Calcular que un numero este en el rango de 2 numeros \n");
        int a = LeerEntero("Límite inferior: ");
        int b = LeerEntero("Límite superior: ");
        if (a > b) (a, b) = (b, a); // por si los invierten

        int n = LeerEntero("Ingrese el numero: ");

        if (n >= a && n <= b) Console.WriteLine("Está en el rango");
        else Console.WriteLine("Fuera del rango");
    }

    static int LeerEntero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string? s = Console.ReadLine();
            if (int.TryParse(s, out int x)) return x;
            Console.WriteLine("Entrada inválida, intenta de nuevo.");
        }
    }
}
