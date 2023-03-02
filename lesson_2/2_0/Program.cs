// 1. Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

int TakeNum(int num)
{
                    Console.WriteLine(num);
                    return num % 10;
}
int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);
//Console.WriteLine (num % 10);