namespace LongitudDeLaPalabra;

class LongitudDeLaPalabra
{
    static void Main()
    {
        Console.Write("Ingrese la palabra que vamos a contar las letras: ");
        string? s = Console.ReadLine();
        Console.WriteLine(s == null ? 0 : s.Length);
    }
}
