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

        //----------------------------------------------------------------------

        Console.WriteLine("\n--- REGISTRO DE AUTOMÓVIL ---");
            // 1. Entrada de Texto (Simple)
            Console.Write("Marca del automóvil: ");
            string marcaAuto = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Año del modelo: ");
            string añoModeloTexto = Console.ReadLine();
            int añoModelo = int.Parse(añoModeloTexto); // Convertimos el texto a número entero

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Precio del automóvil ejemplo (ejemplo: 15000,50): ");
            double precioAuto = double.Parse(Console.ReadLine()); // Conversión directa en una línea

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- DETALLES DEL AUTOMÓVIL ---");
            Console.WriteLine("Marca: " + marcaAuto);
            Console.WriteLine("Año del modelo: " + añoModelo);
            Console.WriteLine("Precio: $" + precioAuto);

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

        //----------------------------------------------------------------------

        Console.WriteLine("\n--- REGISTRO DE LIBRO ---");
            // 1. Entrada de Texto (Simple)
            Console.Write("Título del libro: ");
            string tituloLibro = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Número de páginas: ");
            string numeroPaginasTexto = Console.ReadLine();
            int numeroPaginas = int.Parse(numeroPaginasTexto); // Convertimos el texto a número entero

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Precio del libro ejemplo (ejemplo: 29,99): ");
            double precioLibro = double.Parse(Console.ReadLine()); // Conversión directa en una línea

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- DETALLES DEL LIBRO ---");
            Console.WriteLine("Título: " + tituloLibro);
            Console.WriteLine("Número de páginas: " + numeroPaginas);
            Console.WriteLine("Precio: $" + precioLibro);

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();

        //----------------------------------------------------------------------

        Console.WriteLine("\n--- REGISTRO DE CIUDAD ---");
            // 1. Entrada de Texto (Simple)
            Console.Write("Nombre de la ciudad: ");
            string nombreCiudad = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Población de la ciudad: ");
            string poblacionTexto = Console.ReadLine();
            int poblacionCiudad = int.Parse(poblacionTexto); // Convertimos el texto a número entero

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Superficie de la ciudad en km² ejemplo (ejemplo: 500,75): ");
            double superficieCiudad = double.Parse(Console.ReadLine()); // Conversión directa en una línea

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- DETALLES DE LA CIUDAD ---");
            Console.WriteLine("Nombre: " + nombreCiudad);
            Console.WriteLine("Población: " + poblacionCiudad);
            Console.WriteLine("Superficie: " + superficieCiudad + " km²");

        //----------------------------------------------------------------------

        Console.WriteLine("\n--- BLOQUE 2: REGISTRO DE CELULAR ---");
        // 1. Entrada de Texto (Simple)
        
        Console.WriteLine("Marca del celular: ");
        string marcaCelular = Console.ReadLine();
        
        // 2. Entrada de Números (Requiere Conversión)
        Console.Write("Capacidad de almacenamiento en GB: ");
        string almacenamientoTexto = Console.ReadLine();
        int almacenamientoGB = int.Parse(almacenamientoTexto); // Convertimos el texto a número entero
        
        // 3. Entrada de Decimales (Precios o Medidas)
        Console.Write("Tamaño de la pantalla en pulgadas (ejemplo: 6,5): ");
        string pantallaTexto = Console.ReadLine();
        double tamañoPantalla = double.Parse(pantallaTexto); // Conversión directa en una línea
    }
}