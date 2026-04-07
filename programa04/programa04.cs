namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- BLOQUE 3: REGISTRO VEHICULAR ---");

            // Cadena de texto (string) - Comillas dobles ""
            string modeloAuto = "Toyota Corolla";
            Console.WriteLine("4. TIPO TEXTO (string):");
            Console.WriteLine("   Valor guardado: " + modeloAuto);

            // Carácter único (char) - Comillas simples ''
            char tipoLicencia = 'B';
            Console.WriteLine("\n5. TIPO CARÁCTER (char):");
            Console.WriteLine("   Valor guardado: '" + tipoLicencia + "'");

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();

    }
}