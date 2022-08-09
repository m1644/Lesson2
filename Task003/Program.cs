// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if ((numberA % numberB) == 0)
Console.WriteLine("Число А кратно числу В.");
else
{
    Console.Write("Число А не кратно числу В, ");
    Console.WriteLine($"остаток {numberA % numberB}.");
}
