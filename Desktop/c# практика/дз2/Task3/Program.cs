//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет

System.Console.WriteLine();

int Number = new Random().Next(1, 999);
System.Console.WriteLine();
System.Console.WriteLine($"Дано число: {Number}");

if (Number % 10  > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number % 10 }");
else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

System.Console.WriteLine();