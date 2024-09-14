using System;

public class Program
{
    private static void Main(string[] args)
    {
        // Declaración variables

       const decimal sueldoBase = 80000; // 
        const decimal porcentajeComi = 0.10m; // Porcentaje 10% de comisión por cada venta
       

        // Solicitud de datos por pantalla
        Console.Write("Ingrese el valor de la venta1: ");
        decimal venta1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el valor de la venta2: ");
        decimal venta2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese el valor de la venta3: ");
        decimal venta3 = Convert.ToDecimal(Console.ReadLine());

        // Calculo de cada comisión por venta
        decimal comision1 = venta1 * porcentajeComi;
        decimal comision2 = venta2 * porcentajeComi;
        decimal comision3 = venta3 * porcentajeComi;

        // Calculo del total de las comisiones
        decimal TotalComision = comision1 + comision2 + comision3;

        // Total de dinero recibido en el mes
        decimal devengado = sueldoBase + TotalComision;

        // Promedio de comisiones
        decimal comisiones = (TotalComision / 3);







    }
}