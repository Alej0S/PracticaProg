using System.Runtime.CompilerServices;

namespace Array03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("seleccione el ejercicio del 1 al 5");
            int ejercicio = int.Parse(Console.ReadLine());
            switch (ejercicio)
            {
                case 1:
                Console.WriteLine("--- EJERCICIO INICIAL 3: USO DE .LENGTH Y BUCLE FOR ---");

                int[] edades = { 15, 22, 30, 18, 25 };

                int cantidadElementos = edades.Length;
                Console.WriteLine("El arreglo tiene " + cantidadElementos + " elementos.");
                Console.WriteLine("-------------------------------------");

                for(int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("Índice " + i + ": La edad es " + edades[i]);
            }
                break;

                case 2:
                Console.WriteLine("--- EJERCICIO INICIAL 3: USO DE .LENGTH Y BUCLE FOR ---");

                string[] frutas = { "Manzana", "Banana", "Naranja", "Uva" };
                
                int cantidadFrutas = frutas.Length;
                Console.WriteLine("El arreglo tiene " + cantidadFrutas + " elementos.");
                Console.WriteLine("-------------------------------------");

                for(int i = 0; i < frutas.Length; i++)
                    {
                        Console.WriteLine("Índice " + i + ": La fruta es " + frutas[i]);
                    }
                break;
                case 3:
                
                Console.WriteLine("--- EJERCICIO INICIAL 3: USO DE .LENGTH Y BUCLE FOR ---");
                
                double[] precios = { 10.5, 20.7, 30.9, 15.3 };
                
                int cantidadPrecios = precios.Length;
                Console.WriteLine("El arreglo tiene " + cantidadPrecios + " elementos.");
                Console.WriteLine("-------------------------------------");

                for(int i = 0; i < precios.Length; i++)
                    {
                        Console.WriteLine("Índice " + i + ": El precio es " + precios[i]);
                    }
                break;
                case 4:
                
                Console.WriteLine("--- EJERCICIO INICIAL 3: USO DE .LENGTH Y BUCLE FOR ---");
                
                char[] letras = { 'A', 'B', 'C', 'D' };
                
                int cantidadLetras = letras.Length;
                
                Console.WriteLine("El arreglo tiene " + cantidadLetras + " elementos.");
                Console.WriteLine("-------------------------------------");

                for(int i = 0; i < letras.Length; i++)
                    {
                        Console.WriteLine("Índice " + i + ": La letra es " + letras[i]);
                    }
                break;
                case 5:
                
                Console.WriteLine("--- EJERCICIO INICIAL 3: USO DE .LENGTH Y BUCLE FOR ---");
                
                bool[] estados = { true, false, true, false };
                
                int cantidadEstados = estados.Length;
                
                Console.WriteLine("El arreglo tiene " + cantidadEstados + " elementos.");
                Console.WriteLine("-------------------------------------");

                for(int i = 0; i < estados.Length; i++)
                    {
                        Console.WriteLine("Índice " + i + ": El estado es " + estados[i]);
                    }
                break;
            }
        }
    }
}