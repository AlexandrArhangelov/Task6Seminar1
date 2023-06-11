/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Enter the number you want to check if this number is even");
double number = Convert.ToDouble(Console.ReadLine());
if (number % 2 == 0){
    Console.WriteLine($"Number {number} is an even number");
}
else 
    Console.WriteLine($"Number {number} is not an even number");
    