// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// void FillArrayRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n];

// int PositiveNum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0) count++;            
//     }
//     return count;
// }

// FillArrayRandom(array);
// PrintArray(array);
// int count = PositiveNum(array);
// Console.WriteLine($"Количество чётных чисел в массиве: {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// void FillArrayRandom(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 100);
//     }
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// int SumNegNum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i+=2)
//     sum = sum + array[i];
//     return sum;
// }

// Console.WriteLine("Введите размер массива");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];

// FillArrayRandom(array);
// PrintArray(array);
// int sum = SumNegNum(array);
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArrayRandom(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];

FillArrayRandom(array);
PrintArray(array);

double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else if (array[i] < min) min = array[i];
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");


