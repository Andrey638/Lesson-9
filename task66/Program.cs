//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Введите два числа");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

NumberSum(m,n,0);

void NumberSum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма элементов от m до n: {sum}"); 
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}
