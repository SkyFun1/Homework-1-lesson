//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

System.Console.WriteLine();

int dayNumber = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string txtResult = "";

if (dayNumber > 5) txtResult = $".Это выходной день!";
else txtResult = $", рабочий день.";

System.Console.WriteLine($"{dayNumber}-й день недели - это {Days[dayNumber - 1]}{txtResult}");