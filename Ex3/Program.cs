// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
string Number = Console.ReadLine();
int Num = int.Parse(Number); 

var digits = Number.ToString().Select(t=>int.Parse(t.ToString())).ToArray();
int n = digits.Length;

if(n<3)
{
Console.WriteLine("третьей цифры нет"); 
}
else
{Console.WriteLine(digits[2]);}
