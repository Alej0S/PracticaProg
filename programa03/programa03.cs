namespace Programa03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- ESTACIÓN DE SERVICIO ---");

        // Volumen (double)
        double litrosCargados = 45.8;
        Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + litrosCargados + " litros");

        // Dinero (decimal)
        decimal totalPagar = 55200.75m;
        Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("   Valor guardado: $" + totalPagar);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}