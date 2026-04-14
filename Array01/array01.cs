namespace Array01{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("seleccione el ejercicio del 1 al 5");
            int ejercicio = int.Parse(Console.ReadLine());
            switch (ejercicio)
            {
                case 1:
                Console.WriteLine("---EJERCICIO INICIAL: FUNDAMENTOS DE ARRAYS---");

                int[] numeros = new int[3];

                numeros[0] = 10;
                numeros[1] = 20;
                numeros[2] = 30;

                Console.WriteLine("Valor en índice 0: " + numeros[0]);
                Console.WriteLine("Valor en índice 1: " + numeros[1]);
                Console.WriteLine("Valor en índice 2: " + numeros[2]);
                break;
                case 2:
                Console.WriteLine("---EJERCICIO INICIAL: FUNDAMENTOS DE ARRAYS---");
                string[] nombres = new string[3];
                nombres[0] = "Juan";
                nombres[1] = "María";
                nombres[2] = "Pedro";

                Console.WriteLine("Valor en índice 0: " + nombres[0]);
                Console.WriteLine("Valor en índice 1: " + nombres[1]);
                Console.WriteLine("Valor en índice 2: " + nombres[2]);
                break;
                case 3:
                Console.WriteLine("---EJERCICIO INICIAL: FUNDAMENTOS DE ARRAYS---");
                double[] precios = new double[3];
                precios[0] = 10.5;
                precios[1] = 20.7;
                precios[2] = 30.9;

                Console.WriteLine("Valor en índice 0: " + precios[0]);
                Console.WriteLine("Valor en índice 1: " + precios[1]);
                Console.WriteLine("Valor en índice 2: " + precios[2]);
                break;
                case 4:
                Console.WriteLine("---EJERCICIO INICIAL: FUNDAMENTOS DE ARRAYS---");
                char[] letras = new char[3];
                letras[0] = 'A';
                letras[1] = 'B';
                letras[2] = 'C';

                Console.WriteLine("Valor en índice 0: " + letras[0]);
                Console.WriteLine("Valor en índice 1: " + letras[1]);
                Console.WriteLine("Valor en índice 2: " + letras[2]);
                break;
                case 5:
                Console.WriteLine("---EJERCICIO INICIAL: FUNDAMENTOS DE ARRAYS---");
                bool[] respuestas = new bool[3];
                respuestas[0] = true;
                respuestas[1] = false;
                respuestas[2] = true;

                Console.WriteLine("Valor en índice 0: " + respuestas[0]);
                Console.WriteLine("Valor en índice 1: " + respuestas[1]);
                Console.WriteLine("Valor en índice 2: " + respuestas[2]);
                break;
            }
        }
    }
}