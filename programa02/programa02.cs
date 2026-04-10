namespace Programa02;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine("--- BLOQUE: STOCK DE PRODUCTO ---");

            // Declaración de un entero
            int cantidadBotellas = 45;

            Console.WriteLine("1. TIPO ENTERO (int):");
            Console.WriteLine("   Para contar objetos físicos en un almacén.");
            Console.WriteLine("   Valor guardado: " + cantidadBotellas + " unidades");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

            //----------------------------------------------------------------------

            // ejercicio 2
            Console.WriteLine("\n--- BLOQUE: REGISTRO DE PERSONAJE ---");

            // Declaración de un entero
            int nivelPersonaje = 12;
            Console.WriteLine("1. TIPO ENTERO (int):");
            Console.WriteLine("   Para contar niveles o puntos de experiencia.");
            Console.WriteLine("   Valor guardado: Nivel " + nivelPersonaje);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

        //----------------------------------------------------------------------

        // ejercicio 3
        Console.WriteLine("\n--- BLOQUE: REGISTRO DE LIBRO ---");
        // Declaración de un entero
        int numeroPaginas = 350;
        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para contar páginas de un libro.");
        Console.WriteLine("   Valor guardado: " + numeroPaginas + " páginas");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //----------------------------------------------------------------------

        Console.WriteLine("\n--- ESTACIÓN DE SERVICIO ---");
        // Declaración de un entero
        int numeroSurtidor = 3;
        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para contar surtidores en una estación de servicio.");
        Console.WriteLine("   Valor guardado: " + numeroSurtidor + " surtidores");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

        //----------------------------------------------------------------------

        Console.WriteLine("\n--- REGISTRO DE AUTOMÓVIL ---");
        // Declaración de un entero
        int numeroPuertas = 4;
        Console.WriteLine("1. TIPO ENTERO (int):");
        Console.WriteLine("   Para contar puertas de un automóvil.");
        Console.WriteLine("   Valor guardado: " + numeroPuertas + " puertas");

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}