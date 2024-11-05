//• Nombre del estudiante : Maximiliano Jose de leon cera
//• Grupo: 54
//• Número y Texto del programa : Ingenieria de sistemas - 213022_54
//• Código Fuente: autoría propia : Maximiliano De Leon



using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar la cantidad de estudiantes
        Console.Write("Ingrese la cantidad de estudiantes: ");
        int cantidadEstudiantes = int.Parse(Console.ReadLine());

        string[] nombres = new string[cantidadEstudiantes];
        int[] calificaciones = new int[cantidadEstudiantes];

        // Capturar nombre y calificación
        for (int i = 0; i < cantidadEstudiantes; i++)
        {
            Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
            nombres[i] = Console.ReadLine();

            // Validar calificación entre 1 y 10
            int calificacion;
            do
            {
                Console.Write($"Ingrese la calificación (1-10): ");
                calificacion = int.Parse(Console.ReadLine());
            } while (calificacion < 1 || calificacion > 10);

            calificaciones[i] = calificacion;
        }

        // Calcular y mostrar el promedio, máxima y mínima calificación
        Console.WriteLine($"Promedio: {CalcularCalificacionPromedio(calificaciones)}");
        Console.WriteLine($"Máxima: {CalcularCalificacionMaxima(calificaciones)}");
        Console.WriteLine($"Mínima: {CalcularCalificacionMinima(calificaciones)}");
    }

    // Función que calcula el promedio de las calificaciones
    static double CalcularCalificacionPromedio(int[] calificaciones)
    {
        int suma = 0;
        foreach (int calificacion in calificaciones)
            suma += calificacion;

        return (double)suma / calificaciones.Length;
    }

    // Función que retorna la calificación máxima
    static int CalcularCalificacionMaxima(int[] calificaciones)
    {
        int max = calificaciones[0];
        foreach (int calificacion in calificaciones)
            if (calificacion > max) max = calificacion;

        return max;
    }

    // Función que retorna la calificación mínima
    static int CalcularCalificacionMinima(int[] calificaciones)
    {
        int min = calificaciones[0];
        foreach (int calificacion in calificaciones)
            if (calificacion < min) min = calificacion;

        return min;
    }
}
