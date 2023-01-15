Console.Clear();
Console.Write("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA == numB * numB)
{
    Console.WriteLine("Да!");

}
else
{
     Console.WriteLine("Нет!");
}