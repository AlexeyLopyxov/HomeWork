/*// Задача 1
// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

 int Polindrom(int num) // ЧЕРЕЗ INT
 {
    int sum = 0;
    while(num > 0)
    {
        int num1 = num % 10;
        sum = sum * 10 + num1;
        num /= 10;
    }
    return sum;
 }

Console.Write("Input a number: ");
int numPol = Convert.ToInt32(Console.ReadLine());

int result = Polindrom(numPol);
Console.WriteLine($"Number {numPol} conversely is {result}");
if(numPol == result) Console.WriteLine("Is number a Polindrom");
else Console.WriteLine("Is number a no Polindrom");*/

/*void Polin(int num) // ЧЕРЕЗ VOID (для тренировки)
{
    int newsum = num;
    int sum = 0;
    while(num > 0)
    {
        int ost = num % 10;
        sum = sum * 10 + ost;
        num = num / 10;
    }
    if(newsum == sum)
        Console.WriteLine("Polindrom");
    else 
        Console.WriteLine("No polindrom");
}
Console.Write("Number: ");
int number = Convert.ToInt32(Console.ReadLine());
Polin(number);*/


/*// Задача 2
// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistanceBetweenPoints(double xa, double ya, double za, double xb, double yb, double zb)
{
    double distance = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));
    return Math.Round(distance, 3);
}

Console.Write("Coordinate point A along the x axis: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate point A along the y axis: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate point A along the z axis: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate point B along the x axis: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate point B along the y axis: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Coordinate point B along the z axis: ");
double zB = Convert.ToDouble(Console.ReadLine());

double disPoints = DistanceBetweenPoints(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance between points A({xA};{yA};{zA}) and B({xB};{yB};{zB}) is {disPoints}");*/


/*// Задача 3
// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubNumber(int num)
{
    if(num >= 0)
    {
        for(int i = 0; i <= num; i++)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
    }
    else
        for(int i = -1; i >= num; i--)
        {
            Console.Write(Math.Pow(i, 3) + " ");
        }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Cub Number {number} is ");
CubNumber(number);*/
