using System;

namespace Negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.Beep();
            Console.Clear();

            Console.Write("Digite o número : ");
            n  = double.Parse(Console.ReadLine());

            if(n < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O número é negativo!!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("O número é positivo!!");
                Console.ResetColor();
            }
        }
    }
}
