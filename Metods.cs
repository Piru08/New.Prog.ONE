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
        static int poleM3 = 0;
        #region M1 - Автокалькулятор
        public static void M1()
        {
            if (poleM1 < 1) { MassQM1(); poleM1++; }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВведите первое число:\n");
            float A;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                var a = Console.ReadLine();
                if (string.IsNullOrEmpty(a)) { Err0(); }
                float.TryParse(a, out float a1);
                A = a1;
                if (a1 == 0)
                { Err1(); }
            }
            while (A == 0);
            #region Ferst variant
            //var a = Console.ReadLine();
            //if (!string.IsNullOrEmpty(a) && a.All(char.IsDigit)) { }
            //else { Err0(); }
            //float a1 = float.Parse(a);
            ///В этом коменте записана первоначальная реализация - она проверяла на числа, но не позволяла пропустить цифры с запятой.
            #endregion
            Console.WriteLine("\nВведите второе число:\n");
            float B;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                var b = Console.ReadLine();
                float.TryParse(b, out float b1);
                B = b1;
                if (b1 == 0)
                { Err1(); }
            }
            while (B == 0);
            string mass = $"\n{A} + {B} = " + Math.Round((A + B), 2) + $"\t\t{A} - {B} = " + Math.Round((A - B), 2)
                         + $"\n\n{A} * {B} = " + Math.Round((A * B), 2) + $"\t\t{A} / {B} = " + Math.Round((A / B), 2);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mass);
            Console.ResetColor();
            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nДля продолжения нажмите любую клавишу.");
            Console.ReadKey();
            M1();
        }
        #endregion
        #region M2 - Произвольный калькулятор
        public static void M2()
        {
            if (poleM2 < 1) { MassQM2(); poleM2++; }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВведите первое число:\n");
            float A;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                var a = Console.ReadLine();
                if (string.IsNullOrEmpty(a)) { Err0(); }
                if (a == "?")
                {
                    MassQM2();
                    M2();
                }
                float.TryParse(a, out float a1);
                A = a1;
                if (a1 == 0)
                { Err1(); }
            }
            while (A == 0);
            Console.WriteLine("\nВведите операцию:\n");
            string X;
            string[] oper = new string[] { "+", "-", "/", "*", "^", "//", "?", "%" };
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                X = Console.ReadLine();
                if (X == "?")
                {
                    MassQM2();
                    M2();
                }
                if (!oper.Any(X.Contains)) { Err2(); }
            }
            while (!oper.Any(X.Contains)); //Проверка на наличие символа из ввода в массиве
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВведите второе число:\n");
            float B;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                var b = Console.ReadLine();
                float.TryParse(b, out B);
                if (B == 0)
                { Err1(); }
            }
            while (B == 0);

            Console.ForegroundColor = ConsoleColor.Green;
            switch (X)
            {
                case "+":

                    Console.WriteLine($"\n{A} + {B} = " + Math.Round((A + B), 3));
                    break;
                case "-":
                    Console.WriteLine($"\n{A} - {B} = " + Math.Round((A - B), 3));
                    break;
                case "*":
                    Console.WriteLine($"\n{A} * {B} = " + Math.Round((A * B), 3));
                    break;
                case "/":
                    Console.WriteLine($"\n{A} / {B} = " + Math.Round((A / B), 3));
                    break;
                case "%":
                    double d = (B * 100) / A;
                    Console.WriteLine($"\n{A} от {B} = " + Math.Round(d, 3) + "%");
                    break;
                case "^":
                    double c = Math.Pow(A, B);
                    Console.WriteLine($"\n{A} ^ {B} = " + Math.Round(c, 3));
                    break;
                case "//":
                    double C = Math.Pow(A, (1 / B));
                    Console.WriteLine($"\n{A} √ {B} = " + Math.Round(C, 3)); ///Символ корня - Alt+251
                    break;
                case "?":
                    MassQM2();
                    M2();
                    break;
            }

            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
            M2();
        }
        #endregion
        #region M3 - Калькулятор площадей
        public static void M3()
        {
            if (poleM3 < 1) { MassQM3(); poleM3++; }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВыберите фигуру:\n1. Пямоугольник\n2. Круг\n3");
            var Var = Console.ReadLine();
            if (!string.IsNullOrEmpty(Var) && Var.All(char.IsDigit)) { }
            else { Err0(); }
            int i = int.Parse(Var);
            if (i >= 1 && i <= 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                switch (i)
                {
                    case 1:
                        M3m1();
                        break;
                    case 2:
                        M3m2();
                        break;
                }
            }
            else { ErrM3(); }
        }
        #region M3m1 - прямоугольник
        public static void M3m1()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nРасчет по формуле: a * b = S");
            Console.WriteLine("\nВведите длинну:\n");
            float A;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                var a = Console.ReadLine();
                if (string.IsNullOrEmpty(a)) { ErrM3up(); }
                float.TryParse(a, out float a1);
                A = a1;
                if (a1 == 0)
                { Err1(); }
            }
            while (A == 0);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВведите высоту:\n");
            float B;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                var b = Console.ReadLine();
                float.TryParse(b, out B);
                if (B == 0)
                { Err1(); }
            }
            while (B == 0);
            float P = 2 * (A + B);
            float d = (float)Math.Pow(A, 2) + (float)Math.Pow(B, 2);
            float D = (float)Math.Sqrt(d);
            Console.WriteLine($"\nПлощадь равна:\t {A * B}\nА так же:" +
                $"\n\tПериметр\t{Math.Round(P, 3)}" +
                $"\n\tДиагональ\t{Math.Round(D, 3)}");

            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
            M3();
        }
        #endregion
        #region M3m2 - Круг
        public static void M3m2()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВыберите расчет:\n1.По радиусу." +
                "\n2.По диаметру.\n3.По длине окружности.\n");
            var i = Console.ReadLine();
            if (!string.IsNullOrEmpty(i) && i.All(char.IsDigit)) { }
            else { ErrM3up(); }
            int x = int.Parse(i);
            if (x >= 1 && x <= 3)
            {
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Введите радиус:\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        var a = Console.ReadLine();
                        if (!string.IsNullOrEmpty(a) && a.All(char.IsDigit))
                        {
                            double a1 = double.Parse(a);
                            double S = Math.PI * Math.Pow(a1, 2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nПлощадь круга равна = {Math.Round(S, 3)}\n");
                            Console.WriteLine("Для продолжения нажмите любую клавишу.");
                            Console.ReadKey();
                            M3m2();
                        }
                        else { ErrM3m2(); }
                        break;
                    case 2:
                        Console.WriteLine("Введите диаметр:\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        var b = Console.ReadLine();
                        if (!string.IsNullOrEmpty(b) && b.All(char.IsDigit))
                        {
                            double b1 = double.Parse(b);
                            double S = Math.PI * Math.Pow(b1, 2) / 4;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nПлощадь круга равна = {Math.Round(S, 3)}\n");
                            Console.WriteLine("Для продолжения нажмите любую клавишу.");
                            Console.ReadKey();
                            M3m2();
                        }
                        else { ErrM3m2(); }
                        break;
                    case 3:
                        Console.WriteLine("Введите длину окружности:\n");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        var с = Console.ReadLine();
                        if (!string.IsNullOrEmpty(с) && с.All(char.IsDigit))
                        {
                            double с1 = double.Parse(с);
                            double S = Math.Pow(с1, 2) / (Math.PI * 4);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nПлощадь круга равна = {Math.Round(S, 3)}\n");
                            Console.WriteLine("Для продолжения нажмите любую клавишу.");
                            Console.ReadKey();
                            M3m2();
                        }
                        else { ErrM3m2(); }
                        break;
                }
            }
            else { ErrM3m2(); }
            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Для продолжения нажмите любую клавишу.");
            Console.ReadKey();
            M3m2();
        }
        #endregion
        #endregion
        public static string Desctop() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Для выбора метода введите его порядковый номер.\nМеню вызова:");
            System.Threading.Thread.Sleep(700);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1.Автокалькулятор. Производит отдельные базовые операции с двумя числами.");
            System.Threading.Thread.Sleep(350);
            Console.WriteLine("2.Калькулятор. Производит разовое вычесление с возможностью выбора операции.");
            System.Threading.Thread.Sleep(350);
            Console.WriteLine("3.Вычисления площадей фигур.");

            Console.WriteLine();
            var i = Console.ReadLine();
            if (!string.IsNullOrEmpty(i) && i.All(char.IsDigit)) { }
            else { ErrD(); }
            int q = int.Parse(i);
            if (q >= 1 && q <= 3)
            {
                switch (q)
                {
                    case 1:
                        Metods.M1();
                        break;
                    case 2:
                        Metods.M2();
                        break;
                    case 3:
                        Metods.M3();
                        break;


                }
            }
            else { ErrD2(); }
            return Desctop();
        }
    }
}
