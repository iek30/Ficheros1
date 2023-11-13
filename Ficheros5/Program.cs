internal class Program
{
    private static void Main(string[] args)
    {

        string inputFile1 = "C:\\Users\\cayet\\JokeApp\\Ficheros1\\Ficheros5\\archivo1.txt";
        string inputFile2 = "C:\\Users\\cayet\\JokeApp\\Ficheros1\\Ficheros5\\archivo2.txt";
        string outputFile = "C:\\Users\\cayet\\JokeApp\\Ficheros1\\Ficheros5\\union.txt"; // Nombre del archivo de salida

        try
        {
            CombineFiles(inputFile1, inputFile2, outputFile);
            Console.WriteLine("Combinación de archivos completada. Resultados escritos en 'union.txt'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CombineFiles(string inputFile1, string inputFile2, string outputFile)
    {
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            // Leer líneas de ambos archivos
            string[] lines1 = File.ReadAllLines(inputFile1);
            string[] lines2 = File.ReadAllLines(inputFile2);

            int index1 = 0;
            int index2 = 0;

            // Combinar líneas de ambos archivos
            while (index1 < lines1.Length || index2 < lines2.Length)
            {
                // Escribir una línea de inputFile1 si hay más líneas disponibles
                if (index1 < lines1.Length)
                {
                    writer.WriteLine(lines1[index1]);
                    index1++;
                }

                // Escribir una línea de inputFile2 si hay más líneas disponibles
                if (index2 < lines2.Length)
                {
                    writer.WriteLine(lines2[index2]);
                    index2++;
                }
            }
        }
    }

}
