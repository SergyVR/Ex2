// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// 456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трёхзначное число");
string Number = Console.ReadLine();
int Num = int.Parse(Number); 

var digits = Number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
Console.WriteLine(digits[1]);
