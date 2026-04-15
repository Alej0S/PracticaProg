namespace ejercicioclase1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string [20];
            int[] edad = new int [20];

            for(int i = 0 ; i < 20; i++)
            {
                Console.WriteLine("Ingrese su nombre:");
                nombre[i] = Console.ReadLine();

                Console.WriteLine("Ingrese su edad:");
                edad[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0 ; i < 20; i++)
            {
                if (edad[i] > 30)
                {
                    Console.WriteLine($"Puede ingresar al boliche: {nombre[i]} y su edad es : {edad[i]}");
                }
                else
                {
                    Console.WriteLine($"No puede ingresar al boliche: {nombre[i]} y su edad es : {edad[i]}");
                }
            }
        }
    }
}