//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.WriteLine("Input Array Length; ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [Length];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int count = 0;

for(int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");    
}
*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Input Array Length; ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [Length];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int sum = 0;

for(int i = 0; i < numbers.Length; i++)
sum = sum + numbers[i];
Console.WriteLine($"всего {numbers.Length} чисел, сумма элементов на нечётных позициях = {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}
void PrintArray(int[] numbers)
{
Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
}
*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива
/*
Console.WriteLine("Input Array Length; ");
int Length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double [Length];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"всего {numbers.Length} чисел. Max = {max}, Min = {min}");
Console.WriteLine($"Difference between Max and Min = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
    Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
*/