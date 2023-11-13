using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Origen:");
        string origen = Console.ReadLine();
        Console.WriteLine("Frase a buscar:");
        string patron = Console.ReadLine();

        try
        {
            IEnumerable<string> contenido = File.ReadLines("C:\\Users\\dam\\source\\repos\\Ficheros1\\Ficheros2\\" + origen + ".txt");

            int cont = 0;

            foreach (string linea in contenido)
            {
                cont++;
                if (Regex.IsMatch(linea, patron))
                {
                    Console.WriteLine(linea + "(" + cont + ")");
                }
            }

        }
        catch (IOException iox)
        {
            Console.WriteLine(iox.Message);
        }
    }
}