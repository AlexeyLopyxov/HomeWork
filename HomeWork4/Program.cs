/*// Задача 1
// Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double DegreeOfNumber(double num1, double num2)
{
    double resultprod = 1;
    if(num2 >= 0 )
    {
        for(int count = 1; count <= num2; count++)
        {
            resultprod *= num1;
        }
        return resultprod;
        }
    else
    {
        for(int count = -1; count >= num2; count--)
        {
            resultprod *= num1;
        }
        double minus = 1 / resultprod;
        return minus;
    }
}

Console.Write("Input a number that will be the base of the degree: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a number to be the exponent: ");
double number2 = Convert.ToDouble(Console.ReadLine());

double result = DegreeOfNumber(number1, number2);
Console.WriteLine($"Number is {number1} to the extent {number2} is {result}");*/


/*// Задача 2
// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumCount(int num)
{
    if(num <= 0)
        num *= -1;
        
    int sum = 0;
    while(num > 0)
    {
        int count = num % 10;
        sum += count;
        num /= 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNum = SumCount(number);
Console.WriteLine($"Summ number {number} is {sumNum}");*/


/*// Задача 3
// Программа, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreatedArray(int size)
 {
    int[] nums = new int[size];

    Console.WriteLine($"Input the elements of the array which has size {size}.");

    for(int i = 0; i < nums.Length; i++)
        nums[i] = Convert.ToInt32(Console.ReadLine());
    return nums;
 }

void ShowNums(int[] nums)
{
    Console.Write("Array: [ ");
    for(int i = 0; i < nums.Length; i++)
        Console.Write(nums[i] + " ");
    Console.Write("]");
}

Console.Write("Input a number of array elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myNums = CreatedArray(size);
ShowNums(myNums);*/