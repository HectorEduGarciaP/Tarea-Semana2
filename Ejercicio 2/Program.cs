using System;

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Ingrese el primer número de dos cifras: ");
        byte num1 = byte.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número de dos cifras: ");
        byte num2 = byte.Parse(Console.ReadLine());

        ushort resultado = (ushort)(num1 * num2);

        Console.WriteLine("El resultado de la multiplicación de ambos numeros es: " + resultado);
    }
}





