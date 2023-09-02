// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 0)
    System.Console.WriteLine("Вы ввели 0");
else if (num % 2 == 0)
    System.Console.WriteLine($"{num} число четное");
else
    System.Console.WriteLine($"{num} число нечетное");
