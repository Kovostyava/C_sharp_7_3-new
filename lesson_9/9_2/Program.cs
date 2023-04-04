// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

Console.Write("Enter number N: ");
int num = int.Parse(Console.ReadLine()!);

void NaturalArr(int N)
{
    if(N == 0) return;
    NaturalArr(N-1);
    Console.Write($"{N} ");
}
NaturalArr(num);
