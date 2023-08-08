// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int num = new Random().Next(-100, 100);
Console.Write("Число ");
Console.Write(num);

if(num % 2 == 0)
{
    Console.WriteLine(" является четным.");
}
else
{
    Console.WriteLine(" является нечетным.");
}