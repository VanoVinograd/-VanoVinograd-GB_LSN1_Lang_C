// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Enter the first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int b = Convert.ToInt32(Console.ReadLine());

if ( a > b)
    Console.WriteLine( $" max = {a}" );
else
    Console.WriteLine( $" max = {b}" );
