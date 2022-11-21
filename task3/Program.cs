// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка). 

Console.WriteLine("Enter the number:");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 2) == 0)
{
    Console.WriteLine("Yes");
}
else 
    Console.WriteLine("No");