//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.WriteLine("Введите 2-а числа, чтобы узнать какое больше ");
System.Console.WriteLine("Введите 1-ое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2-ое число ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA > numberB)
{
    System.Console.WriteLine(max = numberA);
}
else if (numberA < numberB)
{
    System.Console.WriteLine(max = numberB);
}
else if (numberA == numberB)
{
    System.Console.WriteLine("Числа равны ");
}
