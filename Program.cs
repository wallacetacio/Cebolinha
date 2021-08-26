using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string cebolinhaFalando; 
            Console.Write("Olá usuário! Por favor digite um texto: ");
            cebolinhaFalando = Console.ReadLine()
            .Replace("r", "l")
            .Replace("R","L");

            Console.WriteLine("O Cebolinha repetiu:");
            Console.WriteLine(cebolinhaFalando);
        }
    }
}
