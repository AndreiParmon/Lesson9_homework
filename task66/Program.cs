// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите ДВА числа через Enter");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int Sum(int n, int m)
{
    if (n == m || n < 0) return n;
    return Sum(n, m-1) + m;
}
Console.WriteLine(Sum(n, m));