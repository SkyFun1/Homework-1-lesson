﻿//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
System.Console.WriteLine();
int volume = 10;                // колчество ввода чисел
int count = 0;

while (volume > 0)
{
    System.Console.Write("Введите число:   ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
}

System.Console.WriteLine($"Количество чисел больше 0: {count}");