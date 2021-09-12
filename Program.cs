using System;
using static System.Math;
using System.Threading;
namespace New.Prog.ONE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Добро пожаловать в автокалькулятор!");
            Thread.Sleep(700);
            Console.WriteLine(".\t.\t.");
            Thread.Sleep(1000);
            Metods.Desctop();
            Console.ReadKey();
        }
    }
}
