using System;

class HomeWork2
{
    static void Main()
    {
        // Задача 1.
        // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

        /*int SecondNum(int num)
        {
            int number = num / 10;
            int result = number % 10;
            return result;
        }

        Console.Write("Input a three-digit number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 / 100 != 0 && num1 / 100 < 10) // Проверка 3-х значное число или нет. Если нет, то выведет ошибку, если да, то идет счет.
        {
            int final = SecondNum(num1);
            Console.WriteLine("Second digit: " + final);
        }
        else
            Console.WriteLine("Error");*/





        // Задача 2.
        // Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

        /*int ThirdNum(int num)
        {
            while(num > 999)
            {
                num = num / 10;
            }

            int result = num % 10;
            return result;
        }

        Console.Write("Input a number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 / 100 != 0)
        {
            int thirdNum = ThirdNum(num1);
            Console.WriteLine("Third Number: " + thirdNum);
        }
        else
            Console.WriteLine("Third Number not exist!!!");*/






        // Задача 3.
        // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

        /*bool DayWeeks(int num)
        {
            if (num == 6 || num == 7)
                return true;
            else
                return false;
        }

        Console.Write("Inut a number from 1 to 7: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 <= 7 && num1 >= 1) // Проверка: если вводимое число меньше 1 и больше 7, то выйдет ошибка.
        {
            bool boolCheck = DayWeeks(num1);
            Console.Write("Day off? ");
            Console.WriteLine(boolCheck);
        }
        else
            Console.WriteLine("Error");*/
    }
}