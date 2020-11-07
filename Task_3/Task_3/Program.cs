using System;

namespace Task_3
{
    class Program

    {
        class calculeter
        {

            static void Main(string[] args)
            {
                double num1, num2, num3;
                Console.WriteLine("Введите первое число ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число ");
                num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите Радиус круга");
                num3 = double.Parse(Console.ReadLine());
                double sumResult = num1 + num2;
                double subResult = num1 - num2;
                double multResult = num1 * num2;
                double divResult = num1 / num2;
                double remResult = num1 % num2;
                double SResult = 3.14 * (num3 * num3);
                Console.WriteLine("Сумма чисел 1 и 2 = " + sumResult);
                Console.WriteLine("Вычетание чисесл 1 и 2 = " + subResult);
                Console.WriteLine("Умножение чисесл 1 и 2 = " + multResult);
                Console.WriteLine("Деление чисесл 1 и 2 = " + divResult);
                Console.WriteLine("Остаток от деления числа 1 на число 2 = " + remResult);
                Console.WriteLine("Площадь круга = " + SResult);
            }


        }
      
    }
}
