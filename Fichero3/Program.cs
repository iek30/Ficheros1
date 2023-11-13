internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Origen:");
        string origen = Console.ReadLine();
        Console.WriteLine("Destino:");
        string destino = Console.ReadLine();

        try
        {
            File.Copy("C:\\Users\\cayet\\JokeApp\\Ficheros1\\Fichero3\\" + origen + ".txt", "C:\\Users\\cayet\\JokeApp\\Ficheros1\\Fichero3\\" + destino + ".txt");
            Console.WriteLine("Archivo copiado.");
        }
        catch (IOException iox)
        {
            Console.WriteLine(iox.Message);
        }
    }
}