﻿// 2. Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.

int SumNums_2(int num)
{
    int n_sum = 0;

    for (; num != 0; num /= 10)
        n_sum += num % 10;

    return n_sum;
}


int num_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumNums_2(num_2));
