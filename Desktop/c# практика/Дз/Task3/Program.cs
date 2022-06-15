//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число => ");
string paramString1 = Console.ReadLine();
int paramInt1 = int.Parse(paramString1);
if (paramInt1 % 2 ==0) 
{
Console.WriteLine("Четное");
}
else 
{
Console.WriteLine("Нечетное");
}