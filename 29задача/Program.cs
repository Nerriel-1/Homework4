// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] getArray(int lengthArray, int a, int b)
{
    int[] array = new int[lengthArray];

    for (int i = 0; i < lengthArray; i++)
    {
        array[i] = new Random().Next(a, b);
    }
    return array;
}

Console.WriteLine("Введите длину массива:");
int length = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон чисел в массиве от:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите диапазон чисел до:");
int num2 = int.Parse(Console.ReadLine());

Console.Write("[");

foreach (int item in getArray(length, num1, num2))
{
    Console.Write(item);
}

Console.Write("]");