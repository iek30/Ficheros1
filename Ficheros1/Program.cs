using System.Diagnostics;

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
            string contenido = File.ReadAllText("C:\\Users\\dam\\source\\repos\\Ficheros1\\Ficheros1\\" + origen + ".txt");
            File.WriteAllText("C:\\Users\\dam\\source\\repos\\Ficheros1\\Ficheros1\\"+destino+".txt", contenido);
            Console.WriteLine("Archivo copiado.");
        }
        catch (IOException iox)
        {
            Console.WriteLine(iox.Message);
        }
    }
}