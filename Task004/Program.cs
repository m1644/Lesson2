// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number % 7) == 0 && (number % 23) == 0) // (&& = И, // = ИЛИ)
Console.WriteLine("Число кратно числу 7 и 23.");
else
{
    Console.WriteLine("Число не кратно числу 7 и 23.");
}
