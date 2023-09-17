
using System;

class MainClass
{
    private static int operatioin;

    public static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1.Сложение");
            Console.WriteLine("2.Вычитание");
            Console.WriteLine("3.Умножение");
            Console.WriteLine("4.Деление");
            Console.WriteLine("5.Возведение в степень");
            Console.WriteLine("6.Квадратный корень");
            Console.WriteLine("7. 1 %");
            Console.WriteLine("8.Факториал");
            Console.WriteLine("9.Выход");

            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"{ num1} + { num2} = { num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{ num1} - { num2} = { num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{ num1} * { num2} = { num1* num2}");
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine($"{ num1} / { num2} = { num1 / num2}");
                    else
                        Console.WriteLine("Деление на ноль невозможно.");
                    break;
                case 5:
                    double pow = Math.Pow(num1, num2);
                    Console.WriteLine($"{ num1} ^({ num2}) = { pow}");
                    break;
                case 6:
                    double sqrt = Math.Sqrt(num1);
                    Console.WriteLine($"√{ num1} = { sqrt}");
                    break;
                case 7:
                    double percent = num1 / 100;
                    Console.WriteLine($"{ num1}% = { percent}");
                    break;
                case 8:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;
                    
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }
        } while (operatioin  != 9);
    }

    static long Factorial(int num)
    {
        if (num <= 1)
            return 1;
        else
            return num * Factorial(num - 1);
    }

}