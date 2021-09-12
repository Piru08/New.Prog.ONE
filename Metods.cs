using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace New.Prog.ONE
{
    class Metods : Error
    {
        static int poleM1 = 0;
        static int poleM2 = 0;
        public static void M1()
        {
            if (poleM1 < 1) { MassQM1(); poleM1++; }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВведите первое число:\n");
            var a = (Console.ReadLine());
            if (!string.IsNullOrEmpty(a) && a.All(char.IsDigit)) { }
            else { Err0(); }
            float a1 = float.Parse(a);
            Console.WriteLine("\nВведите второе число:\n");
            var b = (Console.ReadLine());
            if (!string.IsNullOrEmpty(b) && b.All(char.IsDigit)) { }
            else { ErrM1(); }
            float b1 = float.Parse(b);
            string mass = $"\n{a1} + {b1} = " + (a1 + b1) + $"\t\t{a1} - {b1} = " + (a1 - b1)
                         + $"\n\n{a1} * {b1} = " + (a1 * b1) + $"\t\t{a1} / {b1} = " + Math.Round((a1 / b1), 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mass);
            Console.WriteLine();
            Console.ResetColor();
            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
            M1();
        }
        public static void M2() ///Сейчас тут!
        {
            if (poleM2 < 1) { MassQM2(); poleM2++; }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВведите первое число:\n");
            var a = Console.ReadLine();
            if (!string.IsNullOrEmpty(a) && a.All(char.IsDigit)) { }
            else { Err0(); }
            float a2 = float.Parse(a);
            Console.WriteLine("\nВведите операцию:\n");
            string x = Console.ReadLine();
            if (string.IsNullOrEmpty(x))
            { ErrM2(); }
            Console.WriteLine("\nВведите второе число:\n");
            var b = Console.ReadLine();
            if (!string.IsNullOrEmpty(b) && b.All(char.IsDigit)) { }
            else { ErrM2(); }
            float b2 = float.Parse(b);
            string[] oper = new string[] { "+", "-", "/", "*", "^", "//"};
            if (oper.Any(x.Contains)) //Проверка на наличие символа из ввода в массиве
            {
                Console.ForegroundColor = ConsoleColor.Green;
                switch (x)
                {
                    case "+":
                        Console.WriteLine($"\n{a2} + {b2} = " + (a2 + b2));
                        break;
                    case "-":
                        Console.WriteLine($"\n{a2} - {b2} = " + (a2 - b2));
                        break;
                    case "*":
                        Console.WriteLine($"\n{a2} * {b2} = " + (a2 * b2));
                        break;
                    case "/":
                        Console.WriteLine($"\n{a2} / {b2} = " + (a2 / b2));
                        break;
                    case "^":
                        Console.WriteLine($"\n{a2} ^ {b2} = " + Math.Pow(a2, b2));
                        break;
                    case "//":
                        Console.WriteLine($"\n{a2} из корня степени {b2} = " + Math.Pow(a2, (1 / b2)));
                        break;
                }
            }
            else { ErrM2(); }
            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
            M2();
        }
        public static string Desctop() ///в процессе всего проекта
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Для выбора метода введите его порядковый номер.\nМеню вызова:");
            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.Автокалькулятор. Производит отдельные базовые операции с двумя числами.");
            System.Threading.Thread.Sleep(350);
            Console.WriteLine("2.Калькулятор. Производит разовое вычесление с возможностью выбора операции.");

            Console.WriteLine();
            var i = Console.ReadLine();
            if (!string.IsNullOrEmpty(i) && i.All(char.IsDigit)) { }
            else { ErrD(); }
            int q = int.Parse(i);
            if (q >= 1 || q <= 2)
            {
                switch (q)
                {
                    case 1:
                        Metods.M1();
                        break;
                    case 2:
                        Metods.M2();
                        break;
                }
            }
            return Desctop();
        }
    }
}
