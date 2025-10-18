namespace ContadorDeVocales;

class ContadorDeVocales
{
    static void Main()
    {
        Console.Write("Contador de vocales en una palabra \n");
        Console.Write("Ingresa una palabra: ");
        string s = (Console.ReadLine() ?? "").ToLowerInvariant();
        int c = 0;

        foreach (char ch in s)
        {
            if ("aeiouáéíóúü".IndexOf(ch) >= 0) c++;
        }

        Console.WriteLine(c);
    }
}
