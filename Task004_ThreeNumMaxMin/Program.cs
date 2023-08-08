//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int numA = new Random().Next(1, 100);
Console.Write("Первое число ");
Console.WriteLine(numA);

int numB = new Random().Next(1, 100);
Console.Write("Второе число ");
Console.WriteLine(numB);

int numC = new Random().Next(1, 100);
Console.Write("Третье число ");
Console.WriteLine(numC);

int max = numA;

if(max < numB)
{
    max = numB;
}
if(max < numC )
{
    max = numC;
}
Console.Write("Максимальное из трех чисел: ");
Console.WriteLine(max);

