// 1. Напишите программу, которая принимает на вход
// пятизначное число и проверяет, явлется ли оно полиндромом.

void Pali(int num)
{
    int num_1_2 = num / 1000;
    int num_5 = num % 10;
    int num_4 = num / 10 % 10;

    if (num_1_2 == num_5 * 10 + num_4)
        Console.WriteLine($"yes, {num} is a palindrom");
    else
        Console.WriteLine($"no, {num} is not a polindrom");

}

int num = (new Random().Next(10000, 99999));
Console.WriteLine("Enter a five-digit number");
int val = int.Parse(Console.ReadLine()!);

Pali(val);
