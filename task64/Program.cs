// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int Line(int n)
{
    if(n < 0) return -1;
    if(n == 1) return 1;
    Console.Write(n + ", ");
    return Line(n-1);
}
Console.Write(Line(number));