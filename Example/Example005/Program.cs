Console.Clear();
Console.WriteLine("Введите число N: ");
int numA = Convert.ToInt32(Console.ReadLine());

int numB = -numA;
while(numB <= numA)
{
    Console.Write($"{numB} ");
    numB += 1;
}
