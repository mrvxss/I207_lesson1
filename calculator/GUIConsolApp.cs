using System;

namespace Claculator
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("0 - percent\n");
                Console.Write("1 - *\n");
                Console.Write("2 - /\n");
                Console.Write("3 - -\n");
                Console.Write("4 - +\n");
                Console.Write("5 - sum\n");
                Console.Write("6 - count\n");
                Console.Write("7 - max\n");
                Console.Write("8 - min\n");
                Console.Write("9 - factorial\n");
                Console.Write("10 - modulas and int division\n");
                Console.Write("11 - reverse percent\n");
                Console.Write("Выбери: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Введи первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double result = num1 * num2;
                    Console.Write("Result: " + result + "\n");
                }
                else if (choice == "2")
                {
                    Console.Write("Введи первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double result = num1 / num2;
                    Console.Write("Result: " + result + "\n");
                }
                else if (choice == "3")
                {
                    Console.Write("Введи первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double result = num1 - num2;
                    Console.Write("Result: " + result + "\n");
                }
                else if (choice == "4")
                {
                    Console.Write("Введи первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введи второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double result = num1 + num2;
                    Console.Write("Result: " + result + "\n");
                }
                else if (choice == "5")
                {
                    double sum = 0;
                    Console.Write("Введите число (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0)
                        {
                            break;
                        }
                        sum = sum + n;
                    }
                    Console.Write("Sum: " + sum + "\n");
                }
                else if (choice == "6")
                {
                    int count = 0;
                    Console.Write("Введите число (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0)
                        {
                            break;
                        }
                        count = count + 1;
                    }
                    Console.Write("Count: " + count + "\n");
                }
                else if (choice == "7")
                {
                    double max = 0;
                    Console.Write("Введите число (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0)
                        {
                            break;
                        }
                        if (n > max)
                        {
                            max = n;
                        }
                    }
                    Console.Write("Max: " + max + "\n");
                }
                else if (choice == "8")
                {
                    double min = 0;
                    Console.Write("Введите число (0 to stop):\n");
                    while (true)
                    {
                        double n = Convert.ToDouble(Console.ReadLine());
                        if (n == 0)
                        {
                            break;
                        }
                        if (n < min)
                        {
                            min = n;
                        }
                    }
                    Console.Write("Min: " + min + "\n");
                }
                else if (choice == "9")
                {
                    Console.Write("Введите число: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num < 0)
                    {
                        Console.WriteLine("Факториал отрицательного числа не определен");
                    }
                    else
                    {
                        int fact = 1;
                        if (num == 0)
                        {
                            fact = 1;
                        }
                        else
                        {
                            int i = 1;
                            while (i <= num)
                            {
                                fact = fact * i;
                                i = i + 1;
                            }
                        }

                        Console.Write("Factorial: " + fact + "\n");
                    }
                }
                else if (choice == "10")
                {
                    Console.Write("Введи первое число: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введи второе число: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int div = num1 / num2;
                    int mod = num1 % num2;
                    Console.Write("Int division: " + div + "\n");
                    Console.Write("Modulas: " + mod + "\n");
                }
                else if (choice == "11")
                {
                    Console.Write("Введите значение в процентах: ");
                    double val = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите процент: ");
                    double percent = Convert.ToDouble(Console.ReadLine());
                    double result = val * 100 / percent;
                    Console.Write("Original number: " + result + "\n");
                }
                else if (choice == "0")
                {
                    Console.Write("Введите число: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите процент: ");
                    double percent = Convert.ToDouble(Console.ReadLine());
                    double result = num * percent / 100;
                    Console.Write("Percent: " + result + "\n");
                }

                Console.Write("Вы хотите продолжить? (y/n): ");
                string answer = Console.ReadLine();
                if (answer == "n" || answer == "N")
                {
                    break;
                }
            }
        }
    }
}
