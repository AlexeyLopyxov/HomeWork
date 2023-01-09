/*// Задача 1
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " \t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void DescendingArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int maxPos = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
                if(array[i, k] > array[i, maxPos])
                    maxPos = k;
            
            int temp = array[i, j];
            array[i, j] = array[i, maxPos];
            array[i, maxPos] = temp;
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

DescendingArrayRows(myArray);
Show2dArray(myArray);*/






/*// Задача 2
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray(int rows, int colums)
{
    Console.Write("Input a max possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " \t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ArraySumRows(int[,] array)
{
    int[] arraySum = new int[array.GetLength(0)];

    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumRows = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumRows += array[i, j];

        arraySum[i] = sumRows;

        if (arraySum[i] < arraySum[min])
            min = i;
    }
    Console.WriteLine($"Row {min + 1} minimum amount is {arraySum[min]} ");
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

if (rows != colums)
{
    int[,] myArray = CreateRandom2dArray(rows, colums);
    Show2dArray(myArray);
    ArraySumRows(myArray);
}
else
{
    Console.WriteLine("Error! Set the parameters of a rectangular 2d array!");
}*/






/*// Задача 3
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a max possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " \t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProdMatrix(int[,] array1, int[,] array2)
{
    int[,] prodMatrixArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            prodMatrixArray[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
                prodMatrixArray[i, j] += array1[i, k] * array2[k, j];
        }

    return prodMatrixArray;
}

void ErrorMatrix()
{
    Console.WriteLine("Mistake! The number of columns in the first matrix must equal the number of rows in the second matrix!");
}

int[,] myArray1 = CreateRandom2dArray();
int[,] myArray2 = CreateRandom2dArray();
Show2dArray(myArray1);
Show2dArray(myArray2);

if (myArray1.GetLength(1) == myArray2.GetLength(0))
{
    int[,] prodArray = ProdMatrix(myArray1, myArray2);
    Show2dArray(prodArray);
}
else ErrorMatrix();*/







/*// Задача 4
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3dArray()
{
    Console.Write("Input array dimension along the X axis: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input array dimension along the Y axis: ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input array dimension along the Z axis: ");
    int z = Convert.ToInt32(Console.ReadLine());

    int size = x * y * z;
    int[] nums = new int[size];
    int current;

    for (int i = 0; i < size; i++)
    {
        nums[i] = new Random().Next(10, 100);
        current = nums[i];

        if (i >= 1)
            for (int j = 0; j < i; j++)
            {
                while (nums[i] == nums[j])
                {
                    nums[i] = new Random().Next(10, 100);
                    current = nums[i];
                }
                current = nums[i];
            }
    }

    int[,,] array = new int[x, y, z];
    current = 0;

    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                array[i, j, k] = nums[current];
                current++;
            }

    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,,] myArray = CreateRandom3dArray();
Show3dArray(myArray);*/







/*// Задача 5
// Напишите программу, которая заполнит спирально массив m на n.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];

    int count = 1;
    int num = 0;
    int allNums = 0;
    while (allNums < rows * colums)
    {
        num++;
        for (int i = num - 1; i < colums - num + 1; i++)
        {
            array[num - 1, i] = count++;
            allNums++;
        }
        for (int i = num; i < rows - num + 1; i++)
        {
            array[i, colums - num] = count++;
            allNums++;
        }
        for (int i = colums - num - 1; i >= num - 1; i--)
        {
            array[rows - num, i] = count++;
            allNums++;
        }
        for (int i = rows - num - 1; i >= num; i--)
        {
            array[i, num - 1] = count++;
            allNums++;
        }
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " \t");

        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);*/