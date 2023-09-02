//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

System.Console.WriteLine("Введите положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int index = 2;
if (num < 0)
    System.Console.WriteLine("Вы ввели отрицательное число");
else
{
    while (index <= num)
    {
        System.Console.Write($"{index} ");
        index+=2;
    }
}

