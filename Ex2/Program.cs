﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.WriteLine("Введите число от 1 до 7 обозначающее день недели");
string Number = Console.ReadLine();
int Num = int.Parse(Number); 
if (Num < 6)
{Console.WriteLine($"{Num} -> нет");
}
else {Console.WriteLine($"{Num} -> да");}
