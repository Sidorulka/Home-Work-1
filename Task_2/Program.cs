// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Ввведите первое число =>");
string number1 = Console.ReadLine();

Console.WriteLine("Ввведите второе число =>");
string number2 = Console.ReadLine();

Console.WriteLine("Ввведите третье число =>");
string number3 = Console.ReadLine();

int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);
int num3 = Convert.ToInt32(number3);

int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
Console.WriteLine($"Максимальное число {max}");