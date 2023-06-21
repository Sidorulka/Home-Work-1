// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Ввведите первое число =>");
string number1 = Console.ReadLine();

Console.WriteLine("Ввведите второе число =>");
string number2 = Console.ReadLine();

int num1 = Convert.ToInt32(number1);
int num2 = Convert.ToInt32(number2);

if (num1 < num2)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
else
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}