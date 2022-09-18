/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N. */

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");
        int num = int.Parse(Console.ReadLine()); // Последнее число
        Console.WriteLine($"Чётные числа от 1 до {num}:");

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i+"\t");
            }
        }
    }
}
