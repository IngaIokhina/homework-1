/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Enter the first number: ");
int numberOne = int.Parse(Console.ReadLine() ??"");

Console.WriteLine("Enter the second number: ");
int numberTwo = int.Parse(Console.ReadLine() ??"");

if (numberOne > numberTwo)
{
    Console.WriteLine($"First number {numberOne} is greater than the second {numberTwo}");
}
else 
{
    Console.WriteLine($"Second number {numberTwo} is greater than the first {numberOne}");
}