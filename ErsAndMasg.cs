using System;
namespace New.Prog.ONE
{
    internal class Error : Massange
    {
        public static void Err0()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Переход в основное меню.");
            Metods.Desctop();
        }
        public static void Err1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода!\nВведите число заново.\n");
        }
        public static void Err2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Такой операции не существует!\nВведите операцию заново.\n");

        }
        public static void ErrM3()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода № 2\nПовторите выбор\n");
            Metods.M3();
        }
        public static void ErrM3up()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Возврат к меню выбора...\n");
            Metods.M3();
        }
        public static void ErrM3m1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода № 2\nВведите все заново.\n");
            Metods.M3m1();
        }
        public static void ErrM3m2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода. Не может иметь символов или отрицательного значения.\nВозврат на уровень выше.\n");
            Metods.M3m2();
        }
        public static void ErrD()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода № 1.\nНеобходимо ввести номер метода!");
            Metods.Desctop();
        }
        public static void ErrD2()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка ввода № 1.2.\nНеобходимо ввести номер существующего метода!");
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
            Console.WriteLine("\nВ это методе вы можете вводить не только числа, но и саму операцию." +
                "\nОперцаии есть следующие:  " +
                "\nСложение   ( + )" +
                "\nВычитание  ( - )" +
                "\nУмножение  ( * )" +
                "\nДеление    ( / )" +
                "\nВозведение в степень ( ^ ) - где второе число это степень." +
                "\nИзвлечение из корня ( // ) - где второе число степень корня." +
                "\nВычисление процента ( % ) - Сколько % второе число состовляет от первого." +
                "\nДля повторного вызова справки введите - ( ? )" +
                "\nДля выхода в основное вменю вместо первого числа просто нажмите 'Enter'.");
        }
        public static void MassQM3()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВ это методе вы можете вычислять площади разных фигур разными методами.\n" +
                "Читайте описания внимательно!");
        }
    }
}