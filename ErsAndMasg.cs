using System;
namespace New.Prog.ONE
{
    internal class Error : Massange
    {
        public static void Err0()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Переход в основное меню.");
            Metods.Desctop();
        }
        public static void ErrM1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода № 2\nВведите числа заново.\n");
            Metods.M1();
        }
        public static void ErrM2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода № 2\nВведите все заново.\n");
            Metods.M2();
        }
        public static void ErrD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода № 1.\nНеобходимо ввести номер метода!");
            Metods.Desctop();
        }
    }
    class Massange
    {
        public static void MassQM1()
        {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nЭто 'Авто-калькулятор'. Он производит четыре базовых операции вычисления парой введенных чисел.\n" +
                    "Для выхода в основное вменю вместо первого числа просто нажмите 'Enter'.");
        }
        public static void MassQM2()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n" +
                "Для выхода в основное вменю вместо первого числа просто нажмите 'Enter'.");
        }
    }
}