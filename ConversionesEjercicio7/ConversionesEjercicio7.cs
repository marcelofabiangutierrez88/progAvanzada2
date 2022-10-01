using System;
public class ConversionesEjercicio7
{
    public static void Main()
    {
        int numero = 0;
        cycleNumber(numero);
    }

    public static int cycleNumber(int number)
    {
        while (number < 50)
        {
            number += 5;
            Console.WriteLine(number);

        }
        return number;  
    }
}