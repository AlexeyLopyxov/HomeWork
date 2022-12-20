/*// Задача 1
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int HowManyNumbers(int num)
{
    int count = 0;
    for(int i = 0; i < num; i++)
    {
        Console.WriteLine($"Input a number {i+1}: ");
        int numbers = Convert.ToInt32(Console.ReadLine());
        if(numbers < 0)
            count++;
    }
    return count;
}

Console.Write("How many numbers do you want to enter? ");
int m = Convert.ToInt32(Console.ReadLine());

int result = HowManyNumbers(m);
Console.WriteLine("Number of negative numbers: " + result);*/





/*// Задача 2
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 != b2)
        Console.WriteLine("Lines are parallel!");
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Lines a match!");
    else
    {
        double x, y;
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;

        Console.WriteLine($"Coorsinats intersection y={k1}x+{b1} and y={k2}x+{b2} is ({x};{y})");
    }
}

Console.Write("Input a coefficient k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a coefficient b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a coefficient k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a coefficient b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint(k1, b1, k2, b2);*/