// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).

string n = Console.ReadLine()!;
int N = int.Parse(n);

if (N % 2 == 0)
{
 Console.WriteLine("четное");
}
else
{
   Console.WriteLine("нечетное");                            
}

