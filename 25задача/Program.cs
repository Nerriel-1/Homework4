// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int getDegree(int num1, int num2)
{
    int exp = 1;
    int d = 0;
    while (d < num2)
    {
        exp = exp * num1;
        d++;
    }
    return exp;
}


Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(getDegree(a, b));