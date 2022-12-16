/*// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreatedRandomArray(int size)
 {
    int[] nums = new int[size];
    int minValue = 100;
    int maxValue = 999;

    for(int i = 0; i < size; i++)
        nums[i] = new Random().Next(minValue, maxValue + 1);
    
    return nums;
 }

void ShowNums(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
        Console.Write(nums[i] + " ");
    Console.WriteLine();
}

int CountChetNumber(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myNums = CreatedRandomArray(size);
ShowNums(myNums);

int result = CountChetNumber(myNums);
Console.WriteLine("The number of even numbers is " + result);*/




/*// Задача 2
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreatedRandomArray(int size, int minValue, int maxValue)
 {
    int[] nums = new int[size];

    for(int i = 0; i < size; i++)
        nums[i] = new Random().Next(minValue, maxValue + 1);
    
    return nums;
 }

void ShowNums(int[] nums)
{
    for(int i = 0; i < nums.Length; i++)
        Console.Write(nums[i] + " ");
    Console.WriteLine();
}

int SumChetIndex(int[] array)
{
    int sum  = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myNums = CreatedRandomArray(size, min, max);
ShowNums(myNums);

int result = SumChetIndex(myNums);
Console.WriteLine("sum of elements at odd indices in an array " + result);*/




/*// Задача 3
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreatedRandomArray(int size, int minValue, int maxValue)
 {
    Random rnd = new Random();
    double[] nums = new double[size];

    for(int i = 0; i < size; i++)
        nums[i] = rnd.NextDouble() + rnd.Next(minValue, maxValue + 1);
    
    return nums;
 }

void ShowNums(double[] nums)
{
    for(int i = 0; i < nums.Length; i++)
        Console.Write(nums[i] + " ");
    Console.WriteLine();
}

double RaznitsaMaxMin(double[] array)
{
    double maxnum = array[0];
    double minnum = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxnum)
            maxnum = array[i];
        else
            if(array[i] < minnum)
                minnum = array[i];
    }

    double result = maxnum - minnum;
    return result;    
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myNums = CreatedRandomArray(size, min, max);
ShowNums(myNums);

double raznitsa = RaznitsaMaxMin(myNums);
Console.WriteLine("Raznitsa between max and min elements " + raznitsa);*/