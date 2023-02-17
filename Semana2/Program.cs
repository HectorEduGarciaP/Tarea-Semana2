using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("¿Cuál es tu edad? ");
        byte edad = byte.Parse(Console.ReadLine());
        Console.WriteLine("No aparentas {0} años.", edad);
    }
}
