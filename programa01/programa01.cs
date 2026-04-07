namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- CREADOR DE PERSONAJES ---");

            // 1. Entrada de Texto (Simple)
            Console.Write("Nombre del personaje: ");
            string nombre = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Puntos de vida: ");
            string puntosVidaTexto = Console.ReadLine();
            int puntosVida = int.Parse(puntosVidaTexto); // Convertimos el texto a número entero

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Puntos de fuerza ejemplo (ejemplo: 5,0): ");
            double puntosFuerza = double.Parse(Console.ReadLine()); // Conversión directa en una línea

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Puntos de vida: " + puntosVida);
            Console.WriteLine("Puntos de fuerza: " + puntosFuerza);

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}