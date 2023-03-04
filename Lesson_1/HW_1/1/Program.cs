// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

int firstNumber = Console.ReadLine()!;
int secondNumber = Console.ReadLine()!;

int max = 0;
int min = 0;

if (firstNumbe > secondNumber)
                    max = firstNumbe,min = secondNumber;

else
                    max = secondNumber, min = firstNumbe;

Console.WriteLine(max);
Console.WriteLine(min);
