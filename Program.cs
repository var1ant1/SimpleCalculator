using System;

namespace projects
{
    class Program
    {
        static void Main()
        {
            double a, b; // объявление переменных a и b, т.е. первое и второе число
            char sign; // объявление переменной, отвечающей за знак операции

            Console.Write("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine()); // консоль.райт получает строку, так что переводим ее в дабл
            
            Console.Write("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите операцию: +, -, *, /\n");
            sign = Convert.ToChar(Console.ReadLine());

            if (sign == '+')
            {
                double result = a + b;
                Console.Write($"Результат сложения: {result}");
            }
            else if (sign == '-')
            {
                double result = a - b;
                Console.Write($"Результат вычитания: {result}");
            }
            else if (sign == '*')
            {
                double result = a * b;
                Console.Write($"Результат умножения: {result}");
            }
            else if (sign == '/')
            {
                double result = a / b;
                Console.Write($"Результат деления: {result}");
            }
            else
            {
                Console.WriteLine("Введите корректную операцию или число!");
            }

            Console.WriteLine("\nНажмите любую кнопку для выхода из программы.....");
            Console.ReadKey();

        }
    }
}

