// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int getSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int i = number % 10;
        number = number / 10;
        sum = sum + i;

    }
    return sum;
}


Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(getSum(num));