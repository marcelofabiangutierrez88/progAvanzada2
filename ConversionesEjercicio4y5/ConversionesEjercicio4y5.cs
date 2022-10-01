using System;
public class ConversionesEjercicio4y5
{
    public static void Main()
    {
        int a = 9;
        validateNumber(a);
    }

    public static String validateNumber(int number)
    {
        String message = "";
        if (number> 10)
        {
            Console.WriteLine("Es mayor que 10");
            message = "Es mayor que 10";
        }
        else
        {
            Console.WriteLine("No es mayor que 10");
            message = "No es mayor que 10";
        }
        return message;  
    }

}