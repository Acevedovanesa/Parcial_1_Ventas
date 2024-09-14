public class Program
{
    private static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese los coeficientes

        Console.Write("Ingrese el coeficiente a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el coeficiente b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Evaluaando el tipo de solución
        if (a == 0)
        {
            if (b == 0)
            {
                // La ecuación es 0 = 0, lo que significa que cualquier valor de x es solución
                Console.WriteLine("La ecuación tiene infinitas soluciones.");
            }
            else
            {
                // La ecuación es b = 0, lo que no tiene solución
                Console.WriteLine("La ecuación no tiene solución.");
            }
        }
        else
        {
            // Calcular la solución única
            double x = -b / a;
            Console.WriteLine($"La solución de la ecuación es: x = {x}");
        }


    }
}
    
