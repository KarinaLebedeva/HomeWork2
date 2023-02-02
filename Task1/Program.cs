/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int GetDel(int number)
{
    int numberOne = number / 100;
    int numberTwo = number % 10;
    int result = numberOne * 10 + numberTwo;
    return result;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{GetDel(number)}");