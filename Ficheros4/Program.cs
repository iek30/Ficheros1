internal class Program
{
    private static void Main(string[] args)
    {
        string inputFileName = "C:\\Users\\cayet\\JokeApp\\Ficheros1\\Ficheros4\\entrada.txt";  // Cambia esto al nombre de tu archivo de entrada
        string outputFileName = "C:\\Users\\cayet\\JokeApp\\Ficheros1\\Ficheros4\\salida.txt";  // Cambia esto al nombre de tu archivo de salida

        // Verifica si el archivo de entrada existe
        if (!File.Exists(inputFileName))
        {
            Console.WriteLine($"El archivo {inputFileName} no existe.");
            return;
        }

        // Lee todas las líneas del archivo de entrada
        string[] lines = File.ReadAllLines(inputFileName);

        // Verifica si hay datos en el archivo
        if (lines.Length == 0)
        {
            Console.WriteLine("El archivo de entrada está vacío.");
            return;
        }

        // Variables para mantener el total de calificaciones y el máximo en informática
        double totalMatematicas = 0;
        double maxInformatica = double.MinValue;
        string nombreMaxInformatica = "";

        // Procesar cada línea del archivo
        foreach (string line in lines)
        {
            // Dividir la línea en partes
            string[] parts = line.Split(' ');

            // Verificar si la línea tiene el formato esperado
            if (parts.Length == 3)
            {
                // Obtener el nombre y las calificaciones
                string nombre = parts[0];
                double calificacionMatematicas;
                double calificacionInformatica;

                // Intentar convertir las calificaciones a números
                if (double.TryParse(parts[1], out calificacionMatematicas) &&
                    double.TryParse(parts[2], out calificacionInformatica))
                {
                    // Actualizar el total de calificaciones en matemáticas
                    totalMatematicas += calificacionMatematicas;

                    // Verificar si la calificación en informática es la máxima hasta ahora
                    if (calificacionInformatica > maxInformatica)
                    {
                        maxInformatica = calificacionInformatica;
                        nombreMaxInformatica = nombre;
                    }
                }
                else
                {
                    Console.WriteLine($"Error al procesar la línea: {line}");
                }
            }
            else
            {
                Console.WriteLine($"Error al procesar la línea: {line}");
            }
        }

        // Calcular la media en matemáticas
        double mediaMatematicas = totalMatematicas / lines.Length;

        // Escribir los resultados en el archivo de salida
        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            writer.WriteLine($"Media en Matemáticas: {mediaMatematicas}");
            writer.WriteLine($"Mejor nota en Informática: {maxInformatica} (Obtenida por: {nombreMaxInformatica})");
        }

        Console.WriteLine("Proceso completado. Resultados escritos en el archivo de salida.");
    }
}