//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Write("Введите первое число => ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
Console.Write("Введите второе число => ");
string paramString2 = Console.ReadLine();
int paramInt2 = int.Parse(paramString2);
if (paramInt1 > paramInt2)
{
    Console.WriteLine ("первое число больше второго");
}
else
{
    Console.WriteLine ("Второе число больше первого");
}
