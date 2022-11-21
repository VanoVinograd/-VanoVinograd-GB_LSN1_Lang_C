// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.WriteLine("Enter the first number:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number:");
int c = Convert.ToInt32(Console.ReadLine());

if ( a > b && a > c)
    Console.WriteLine( $" max = {a}" );
if ( b > a && b > c)
    Console.WriteLine( $" max = {b}" );
if ( c > a && c > b)
    Console.WriteLine( $" max = {c}" );