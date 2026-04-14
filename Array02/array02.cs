namespace Array02
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("seleccione el ejercicio del 1 al 5");
            int ejercicio = int.Parse(Console.ReadLine());
            switch (ejercicio)
            {
               case 1:
               Console.WriteLine("---Array ---");
                    string[] invitados =
                    {
                        "Juan",
                        "María",
                        "Pedro",
                        "Ana",
                        "Luis"
                    };
                    //bucle foreach: para cada nombre (cadena) dentro de 'inbitados'
                    foreach (string nombre in invitados)
                    {
                        Console.WriteLine("Invitado: " + nombre);
                    }
                    break;
                case 2:
               Console.WriteLine("---Array ---");
                    int[] numeros = { 10, 20, 30, 40, 50 };
                    //bucle foreach: para cada numero (entero) dentro de 'numeros'
                    foreach (int numero in numeros)
                    {
                        Console.WriteLine("Número: " + numero);
                    }
                    break;
                case 3:
                Console.WriteLine("---Array ---");
                    double[] precios = { 19.99, 29.99, 39.99, 49.99, 59.99 };
                    //bucle foreach: para cada precio (decimal) dentro de 'precios'
                    foreach (double precio in precios)
                    {
                        Console.WriteLine("Precio: $" + precio);
                    }
                    break;
                case 4:
                    Console.WriteLine("---Array ---");
                    char[] letras = { 'A', 'B', 'C', 'D', 'E' };
                    //bucle foreach: para cada letra (carácter) dentro de 'letras'
                    foreach (char letra in letras)
                    {
                        Console.WriteLine("Letra: " + letra);
                    }

                    break;
                case 5:
                    Console.WriteLine("---Array ---");
                    bool[] respuestas = { true, false, true, false, true };
                    //bucle foreach: para cada respuesta (booleano) dentro de 'respuestas'
                    foreach (bool respuesta in respuestas)
                    {
                        Console.WriteLine("Respuesta: " + respuesta);
                    }

                    break;
                default:
                    Console.WriteLine("Ejercicio no válido. Por favor, selecciona un número del 1 al 5.");
                    break;
            }
        }
    }
}