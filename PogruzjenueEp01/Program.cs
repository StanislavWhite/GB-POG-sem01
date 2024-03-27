using System;

namespace Ep01
{
    abstract class MathFunc
    {
        public static double Calculate(double num1, char sign, double num2)
        {
            double result = 0;
            switch (sign)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    { result = num1 / num2; }
                    else { Console.WriteLine("Некорректное значение. "); }
                    break;
                default:
                    Console.WriteLine("Некорректное значение. ");
                    return result;
            }
            return result;
        }
    }
    class Program : MathFunc
    {
        static void Main()
        {
            StartMath();
        }
        static void StartMath()
        {
            Console.WriteLine("Введите аргумент номер один.");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите аргумент номер два.");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите операцию. (+ - * /)");
            char sign = Convert.ToChar(Console.ReadLine());

            Console.WriteLine(Calculate(num1, sign, num2));

            Console.WriteLine(); Console.WriteLine("Вы хотите продолжить ? (Введите *ДА* или *НЕТ*) ");
            string toNext = (Console.ReadLine());
            if (toNext.ToLower() == "да")
            {
                StartMath();
            }
            else { Console.WriteLine("Цикл окончен. "); }
        }
    }
}