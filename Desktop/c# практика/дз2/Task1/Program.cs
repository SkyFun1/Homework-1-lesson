//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

System.Console.Write("Введите трёхзначное число ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);

System.Console.WriteLine("Вторая цифра числа "+ (numberInt % 100)/10);
