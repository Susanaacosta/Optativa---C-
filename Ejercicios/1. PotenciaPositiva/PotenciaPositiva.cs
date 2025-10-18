namespace PotenciaPositiva;

class PotenciaPositiva
{
    static void Main()
    {
        
      
        Console.Write("Solicitar un número y eleva este número al cuadrado \n");
        Console.Write("Ingresa un numero: ");
        int n = int.Parse(Console.ReadLine()!);

        if (n > 0) Console.WriteLine(n * n);
        else if (n == 0) Console.WriteLine(0);
        else Console.WriteLine("Es un Número negativo");
    }
}
