// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом второго.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB || numberB == numberA * numberA) // (|| = ИЛИ)
Console.WriteLine("True");
else
{
    Console.WriteLine("False");
}
