// Напишите программу, оторая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

string SecondNum(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"[num] -> {num / 100 * 10 + num % 10}";
    return "The number is not three-digit!";
}

int val = int.Parse(Console.ReadLine()!);
string result = SecondNum(val);
Console.WriteLine(result);