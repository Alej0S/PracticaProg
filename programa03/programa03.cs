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

            //----------------------------------------------------------------------

        // ejercicio 2
        Console.WriteLine("\n--- REGISTRO DE PERSONAJE ---");

        // Volumen (double)
        double alturaPersonaje = 1.85;
        Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + alturaPersonaje + " metros");

        // Dinero (decimal)
        decimal puntosExperiencia = 12500.50m;
        Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("   Valor guardado: " + puntosExperiencia + " XP");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //----------------------------------------------------------------------
        // ejercicio 3

        Console.WriteLine("\n--- REGISTRO DE LIBRO ---");   

        // Volumen (double)
        double pesoLibro = 0.75;
        Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + pesoLibro + " kg");

        // Dinero (decimal)
        decimal precioLibro = 350.99m;
        Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("   Valor guardado: $" + precioLibro);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //----------------------------------------------------------------------

        // ejercicio 4
        Console.WriteLine("\n--- REGISTRO DE PELÍCULA ---");
        // Volumen (double)
        double duracionPelicula = 120.5;
        Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + duracionPelicula + " minutos");

        // Dinero (decimal)
        decimal presupuestoPelicula = 15000000.00m;
        Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("   Valor guardado: $" + presupuestoPelicula);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //----------------------------------------------------------------------

        // ejercicio 5
        Console.WriteLine("\n--- REGISTRO DE CIUDAD ---");
        // Volumen (double)
        double areaCiudad = 500.75;
        Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Valor guardado: " + areaCiudad + " km²");

        // Dinero (decimal)
        decimal presupuestoCiudad = 250000000.00m;
        Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("   Valor guardado: $" + presupuestoCiudad);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}