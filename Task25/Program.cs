// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число: ");
int b = Convert.ToInt32(Console.ReadLine());
int Degree(int k, int g)
{
    int i = 1;
    int num = 1;
    while (i <= g)
    {
    num = num * k;
    i++;        
    }
    return num;
}
int degree = Degree(a, b);
Console.WriteLine(degree);

