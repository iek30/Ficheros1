internal class Program
{
    private static void Main(string[] args)
    {
        string fichero = File.ReadAllText("C:\\Users\\cayet\\JokeApp\\Ficheros1\\Ficheros6\\enteros.txt");
        string[] numeros = fichero.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Números: " + fichero);
        Console.WriteLine("Cantidad: " + numeros.Length);
        int suma = 0;
        foreach (string item in numeros)
        {
            int numero = Int32.Parse(item);
            suma = suma + numero;
        }
        Console.WriteLine("Suma:"+suma);
    }
}