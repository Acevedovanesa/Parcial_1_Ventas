using System;
using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        // Declaración variables

       const decimal sueldoBase = 800000; // Sueldo base, se puede asignar cualquier valor
       const decimal porcentajeComi = 0.10m; // Porcentaje 10% de comisión por cada venta
        const decimal ObjetivoMes = 1000000;
       

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

        //Calculo de ventas
        decimal TotalVentas = venta1 + venta2 + venta3;

        // Beneficio extra
        decimal BonoExtra = (TotalVentas >= ObjetivoMes) ? 1000000 : 0;
        
        
        if (BonoExtra < 1000000)
        {
            BonoExtra = 0;
        }

       else if (BonoExtra >= 1000000)
        {
            BonoExtra = 100000;
        }

        decimal Beneficio = devengado + BonoExtra;


        Console.WriteLine("Resumen Total Ganado:");

        Console.WriteLine($"Total de Comisiones: {TotalComision:C}");

        Console.WriteLine($"Total recibido en el mes (sueldo base + comisiones): {devengado:C}");

        Console.WriteLine($"Promedio de las comisiones: {comisiones:C}");

        Console.WriteLine($"Beneficio extra obtenido: {(BonoExtra < ObjetivoMes ? BonoExtra.ToString("C") : "No")}");

        Console.WriteLine($"Total con beneficio extra: {Beneficio:C}");





    }
}