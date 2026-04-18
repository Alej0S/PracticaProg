# Ejercicio Clase 1 - Control de Acceso (Boliche)

Este es un programa de consola interactivo escrito en **C#** que simula un sistema de control de acceso para un boliche basándose en la edad de las personas.

## Descripción

El programa solicita al usuario que ingrese el **nombre** y la **edad** de 20 personas seguidas. Una vez que todos los datos han sido recolectados, el sistema evalúa cada entrada y determina si la persona tiene permitido el ingreso basándose en su edad.

La regla configurada en este ejercicio es:
- Si la persona tiene **más de 30 años**, entonces **puede ingresar al boliche**.
- En caso contrario, se le negará el acceso.

Finalmente, muestra por pantalla el resultado para cada una de las 20 personas con el formato: nombre, edad y si se le permite o no el ingreso.

## Requisitos

- .NET SDK (Compatible con la versión especificada en `Ejercicioclase1.csproj`)
- Entorno de desarrollo para C# o terminal con el CLI de .NET.

## Cómo ejecutar (CLI de .NET)

1. Abre tu terminal o consola de comandos.
2. Navega hasta la carpeta del proyecto:
   ```bash
   cd Ejercicioclase1
   ```
3. Ejecuta el programa con el siguiente comando:
   ```bash
   dotnet run
   ```
Alternativamente, puedes abrir la solución o el proyecto desde Visual Studio y presionar F5.

## Tecnologías utilizadas
- Lenguaje: C#
- Uso de arreglos unidimensionales (Arrays paralelos).
- Bucles iterativos (`for`).
- Estructuras condicionales (`if/else`).
