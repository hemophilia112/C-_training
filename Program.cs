using System;

namespace MyProgram
{
   class Program
   {
        static void Main(string[] args)
        {
            Console.Write("Напиши первое число ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Напиши второе число ");
            int b = int.Parse(Console.ReadLine()!);
            Console.Write("Отлично. Теперь выбери операцию '+'','-'','*'','/'");
            string sign = Console.ReadLine()!;

            if (sign == "+")
            {
                int result = a + b;
                Console.Write($"Результат сложения равен {result}");
            }
            else if (sign == "-")
            {
                int result = a - b;
                Console.Write($"Результат вычитания равен {result}");
            }
            else if (sign == "*")
            {
                int result = a * b;
                Console.Write($"Результат умножения равен {result}");
            }
            else if (sign == "/")
            {
                if (b != 0)
                {
                    float result = (float)a / b;
                    Console.Write($"Результат деления равен {result}");
                }
                else
                {
                    System.Console.WriteLine("Ошибка. Нельзя делить на 0");
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Некорректная операция ");
            }
            Console.ReadLine();
      }
   }
}