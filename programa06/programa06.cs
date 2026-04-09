namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP1 = "GameMaster Pro";
            const string VERSION1 = "v1.0.2";
            const int EDAD_MINIMA = 18;

            Console.WriteLine("=== " + NOMBRE_APP1 + " (" + VERSION1 + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
            const int EDAD_CLIENTE = 17;
            const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP1);
            Console.WriteLine("Constante VERSION = " + VERSION1);

            Console.ReadLine();


        //---------------------------------------

        //Ejercicio 2

        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP2 = "Programa de descuentos";
            const string VERSION2 = "v2.1.0";
            const double GASTO_MINIMO = 50.0;

            Console.WriteLine("=== " + NOMBRE_APP2 + " (" + VERSION2 + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Descuento aplicado a partir de $" + GASTO_MINIMO);

        // Intento de uso con constantes (sin estructuras de control)
            const double GASTO_CLIENTE = 45.50;
            const bool ES_PREMIUM = GASTO_CLIENTE >= GASTO_MINIMO; // expresión booleana

            Console.WriteLine("\nVerificando cliente con gasto de $" + GASTO_CLIENTE + "...");
            Console.WriteLine("Gasto mínimo: " + GASTO_MINIMO);
            Console.WriteLine("¿Aplica descuento? (valor bool constante): " + ES_PREMIUM);

        // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP2);
            Console.WriteLine("Constante VERSION = " + VERSION2);

            Console.ReadLine();
        

        //---------------------------------------

        //Ejercicio 3
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP3 = "Limite de velocidad";
            const string VERSION3 = "v3.0.0";
            const double VELOCIDAD_MAXIMA = 80.0;

            Console.WriteLine("=== " + NOMBRE_APP3 + " (" + VERSION3 + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Velocidad máxima permitida: " + VELOCIDAD_MAXIMA + " km/h");

        // Intento de uso con constantes (sin estructuras de control)
            const double VELOCIDAD_CLIENTE = 90.0;
            const bool EXCEDE_LIMITE = VELOCIDAD_CLIENTE > VELOCIDAD_MAXIMA; // expresión booleana
        

            Console.WriteLine("\nVerificando cliente con velocidad de " + VELOCIDAD_CLIENTE + " km/h...");
            Console.WriteLine("Velocidad máxima: " + VELOCIDAD_MAXIMA);
            Console.WriteLine("¿Excede el límite? (valor bool constante): " + EXCEDE_LIMITE);

        // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP3);
            Console.WriteLine("Constante VERSION = " + VERSION3);

            Console.ReadLine();

        //---------------------------------------
        
        //Ejercicio 4

        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
            const string NOMBRE_APP4 = "Horario de atencion";
            const string VERSION4 = "v1.5.0";
            const int HORA_APERTURA = 7;
            const int HORA_CIERRE = 13;

            Console.WriteLine("=== " + NOMBRE_APP4 + " (" + VERSION4 + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Acceso permitido entre las " + HORA_APERTURA + ":00 y las " + HORA_CIERRE + ":00");

        // Intento de uso con constantes (sin estructuras de control)
            const int INGRESO_AFILIADO = 9;
            const bool TIENE_ACCESO = INGRESO_AFILIADO >= HORA_APERTURA && INGRESO_AFILIADO < HORA_CIERRE; // expresión booleana

            Console.WriteLine("\nVerificando acceso a las " + INGRESO_AFILIADO + ":00...");
            Console.WriteLine("Horario de acceso: " + HORA_APERTURA + ":00 - " + HORA_CIERRE + ":00");
            Console.WriteLine("¿Acceso permitido? (valor bool constante): " + TIENE_ACCESO);

        // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP4);
            Console.WriteLine("Constante VERSION = " + VERSION4);

            Console.ReadLine();
        
        //---------------------------------------

        //Ejercicio 5
            const string NOMBRE_APP5 = "Hay asientos disponibles";
            const string VERSION5 = "v3.2.1";
            const int ASIENTOS_DISPONIBLES = 30;

            Console.WriteLine("=== " + NOMBRE_APP5 + " (" + VERSION5 + ") ===");
            Console.WriteLine("Cargando reglas del sistema...");
            Console.WriteLine("Restricción: Asientos disponibles: " + ASIENTOS_DISPONIBLES);

        // Intento de uso con constantes (sin estructuras de control)
            const int ASIENTOS_SOLICITADOS = 9;
            const bool HAY_ASIENTOS = ASIENTOS_SOLICITADOS <= ASIENTOS_DISPONIBLES; // expresión booleana

            Console.WriteLine("\nVerificando disponibilidad de asientos...");
            Console.WriteLine("Asientos disponibles: " + ASIENTOS_DISPONIBLES);
            Console.WriteLine("Asientos solicitados: " + ASIENTOS_SOLICITADOS);
            Console.WriteLine("¿Hay asientos disponibles? (valor bool constante): " + HAY_ASIENTOS);

        // Mostrar constantes para reforzar concepto
            Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP5);
            Console.WriteLine("Constante VERSION = " + VERSION5);

            Console.ReadLine();



    }
}