//• Nombre del estudiante : Maximiliano Jose de leon cera
//• Grupo: 54
//• Número y Texto del programa : Ingenieria de sistemas - 213022_54
//• Código Fuente: autoría propia : Maximiliano De Leon

using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar la cantidad de empleados
        Console.Write("Ingrese la cantidad de empleados: ");
        int cantidadEmpleados = int.Parse(Console.ReadLine());

        string[] nombres = new string[cantidadEmpleados];
        int[] edades = new int[cantidadEmpleados];

        // Captura de nombre y edad de cada empleado
        for (int i = 0; i < cantidadEmpleados; i++)
        {
            Console.Write($"Ingrese el nombre del empleado {i + 1}: ");
            nombres[i] = Console.ReadLine();

            Console.Write($"Ingrese la edad del empleado {i + 1}: ");
            edades[i] = int.Parse(Console.ReadLine());
        }

        // Calcular y mostrar la edad promedio
        double edadPromedio = CalcularEdadPromedio(edades);
        ImprimirEdadPromedio(edadPromedio);
    }

    // Función que calcula y retorna el promedio de las edades
    static double CalcularEdadPromedio(int[] edades)
    {
        int sumaEdades = 0;

        foreach (int edad in edades)
        {
            sumaEdades += edad;
        }

        return (double)sumaEdades / edades.Length;
    }

    // Función que imprime el promedio calculado (sin retorno)
    static void ImprimirEdadPromedio(double promedio)
    {
        Console.WriteLine($"La edad promedio de los empleados es: {promedio}");
    }
}

