public class ConversionesEjercicio3
{
    public static void Main()
    {
        String color = "blanco";
        selectColor(color);
    }

    public static String selectColor(String color)
    {
        switch (color)
        {
            case "blanco":
                Console.WriteLine("El color es blanco");
                break;
            case "azul":
                Console.WriteLine("El color es azul");
                break;
            case "negro":
                Console.WriteLine("El color es negro");
                break;
        }
        return color;
    }
}
