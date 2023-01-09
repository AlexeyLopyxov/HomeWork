/*// Задача 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNums(int num)
{
    if(num > 1)
    {
        Console.Write(num + " ");
        ShowNums(num - 1);
    }

    if(num < 1)
    {
        Console.Write(num + " ");
        ShowNums(num + 1);
    }
    if(num == 1)
        Console.Write(num + " ");
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);*/






/*// Задача 2
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ShowNums(int num1, int num2)
{
    if (num1 > num2) return ShowNums(num1 - 1, num2) + num1;

    if (num2 > num1) return ShowNums(num1, num2 - 1) + num2;

    return num1;
}

Console.Write("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumend = ShowNums(m, n);
Console.WriteLine(sumend);*/






/*// Задача 3
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunAkker(int num1, int num2)
{
    if(num1 == 0) return num2 + 1;
    else if((num1 > 0) && (num2 == 0)) return FunAkker(num1 - 1, 1);
    else return FunAkker(num1 - 1, FunAkker(num1, num2 - 1));
}

Console.Write("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = FunAkker(m, n);
Console.WriteLine(result);*/