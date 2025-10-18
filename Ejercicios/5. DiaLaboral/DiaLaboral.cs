namespace DiaLaboral;

class DiaLaboral
{
    static void Main()
    {
        Console.Write("Calcular del 1 al 7 que dia es un dia laboral o no\n");
         Console.Write("Ingrese un numero: ");
        int n = int.Parse(Console.ReadLine()!);

        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
        if (n >= 1 && n <= 5) Console.WriteLine(dias[n - 1]);
        else Console.WriteLine("Número fuera del rango para calcular el dia laboral");
    }
}
