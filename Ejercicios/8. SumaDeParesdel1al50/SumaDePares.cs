namespace SumaDePares;

class SumaDePares
{
    //Sumar todos los pares que hay entre el 1 y el 50
    static void Main()
    {
        int suma = 0;
        for (int i = 2; i <= 50; i += 2)
            suma += i;

        Console.WriteLine(suma); // 650
    }
}
