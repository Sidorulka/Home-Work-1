// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Ввведите число");
string number = Console.ReadLine();

int num = Convert.ToInt32(number);

if (num%2 == 0)
{
    Console.WriteLine($"{number} является чётным числом");
}
else
{
    Console.WriteLine($"{number} является нечётным числом");
}