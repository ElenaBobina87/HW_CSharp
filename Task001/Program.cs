//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

System.Console.WriteLine("Введите 2 числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2)
System.Console.WriteLine($"число {num1} больше числа {num2}");
else
System.Console.WriteLine($"число {num2} больше числа {num1}");
