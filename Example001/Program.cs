// Напиши программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

Console.Clear();

Console.WriteLine("Введите число:");

int num = int.Parse(Console.ReadLine());

int sqr = num * num;

Console.Write("Квадрат числа" + num +" = " + sqr);
