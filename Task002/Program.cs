// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

System.Console.WriteLine("Введите 3 числа: ");
int max = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
if (num2 > max)
    max = num2;
if (num3 > max)
    max = num3;
System.Console.WriteLine($"Максимальное число {max}");
