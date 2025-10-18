namespace RestaDeFracciones;

struct Fraccion
{
    public long Num;
    public long Den;

    public Fraccion(long num, long den)
    {
        if (den == 0) throw new DivideByZeroException("Denominador no puede ser 0");
        if (den < 0) { num = -num; den = -den; }
        long g = Mcd(Math.Abs(num), Math.Abs(den));
        Num = num / g;
        Den = den / g;
    }

    public static Fraccion operator -(Fraccion a, Fraccion b)
    {
        return new Fraccion(a.Num * b.Den - b.Num * a.Den, a.Den * b.Den);
    }

    public override string ToString()
    {
        if (Den == 1) return Num.ToString();
        return $"{Num}/{Den}";
    }

    static long Mcd(long a, long b)
    {
        while (b != 0) { long t = a % b; a = b; b = t; }
        return Math.Abs(a);
    }
}

class RestaDeFracciones
{
    static void Main()
    {
        Console.Write("Calcular la diferencia entre 2 fracciones\n");
        Console.Write("Fracción 1  con esta estructuraa (a/b): ");
        Fraccion f1 = Leer(Console.ReadLine());
        Console.Write("Fracción 2 con esta estructura (a/b): ");
        Fraccion f2 = Leer(Console.ReadLine());

        Console.WriteLine(f1 - f2);
    }

    static Fraccion Leer(string? s)
    {
        var p = (s ?? "").Split('/', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (p.Length == 1) return new Fraccion(long.Parse(p[0]), 1);
        if (p.Length == 2) return new Fraccion(long.Parse(p[0]), long.Parse(p[1]));
        throw new FormatException("Formato inválido");
    }
}
