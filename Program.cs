// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] digitArray = CreateDigitArray(10, 100, 1000);

int[] CreateDigitArray(int size, int min, int max)
{   
    int[] digitArray = new int [size];
    Random digit = new Random();

    for (int i = 0; i < size ; i++)
    {
        digitArray[i] = digit.Next(min, max);
    }

    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine(digitArray[i]);
    }

    return digitArray;
}

int count = EvenNumber(digitArray);

int EvenNumber(int[] digitArray)
{
    int count = 0;

    for (int i = 0; i < digitArray.Length; i++)
    {
        if (digitArray[i] % 2 == 0)
        {
            count++;
        }
    }
    
    return count;
}

System.Console.WriteLine("Количество четных элементов в массиве = " + count);

////////////////////////////////////////////////////////////////////////////////////////

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] digitArray = CreateDigitArray(5, 0, 10);

int[] CreateDigitArray(int size, int min, int max)
{   
    int[] digitArray = new int [size];
    Random digit = new Random();

    for (int i = 0; i < size ; i++)
    {
        digitArray[i] = digit.Next(min, max);
    }

    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine(digitArray[i]);
    }

    return digitArray;
}

int sumOfEvenElement = SumOfOddElement(digitArray);

int SumOfOddElement(int[] digitArray)
{
    int sumOfOddElement = 0;

    for (int i = 0; i < digitArray.Length; i++)
    {
       sumOfOddElement = sumOfOddElement + digitArray[i];
       i++;
    }

    System.Console.WriteLine("Сумма элементов стоящих на нечетных позициях = " + sumOfOddElement);

    return sumOfOddElement;
}

////////////////////////////////////////////////////////////////////////////////////////

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


float[] digitArray = CreateDigitArray(5);

float[] CreateDigitArray(int size)
{   
    float[] digitArray = new float [size];
    Random digit = new Random();

    for (int i = 0; i < size ; i++)
    {
        digitArray[i] = digit.Next();
    }

    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine(digitArray[i]);
    }

    return digitArray;
}


float dif = difOfMinAndMaxDigit(digitArray, 0, 0);

float difOfMinAndMaxDigit(float[] digitArray, float min, float max)
{
    min = 0;
    max = 0;
    
    for (int i = 0; i < (digitArray.Length - 1); i++)
    {
        if (digitArray[i] > digitArray[i + 1])
        {
            min = digitArray[i + 1];
            max = digitArray[i];
        }
    }

    dif = max - min;

    Console.WriteLine("");
    Console.WriteLine($"min = {min}");
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"dif = max - min = {dif}");

    return dif;
}

