using System;

class Program
{
    static void Main(string[] args)
    {
        long num1, num2;

        //Pedimos al usuario que ingrese los numeros no mayores a 19 digitos gracias a la variable long

        Console.Write("Ingrese el primer número (No mayor a 19 digitos): ");
        num1 = long.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo número (No mayor a 19 digitos): ");
        num2 = long.Parse(Console.ReadLine());

        long suma = num1 + num2;
        long resta = num1 - num2;
        long producto = num1 * num2;

        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
        Console.WriteLine($"La resta de {num1} y {num2} es: {resta}");
        Console.WriteLine($"El producto de {num1} y {num2} es: {producto}");

        Console.ReadKey();
    }
}
