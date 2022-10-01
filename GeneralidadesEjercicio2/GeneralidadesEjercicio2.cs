using System;

public class GeneralidadesEjercicio2

{
    public static void Main()
    {
        cutString("avanzada");
    }
    public static String cutString(String a)
    {
        String myString = a;
        Console.WriteLine("Cadena cortada: " + myString.Remove(4, 4));
        return a;
    }
}

