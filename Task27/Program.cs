// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    int summa = 0;
    while (num > 0)
    {
    int remains = num % 10;
    num = (num - remains) / 10;
    summa = summa + remains;
    }
    return summa;
}
int sum = Sum(number);
Console.WriteLine(sum);

