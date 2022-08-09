// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.

// Обычное решение!!!
//int number = new Random().Next(100, 1000);
//Console.WriteLine(number);
//int digit1 = number / 100;
//int digit2 = number % 10;
//int digit3 = digit1 * 10 + digit2;
//Console.WriteLine(digit3);

// Строчное решение!!!
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
string str_number = number.ToString();
char digit1 = str_number[0];
char digit3 = str_number[2];
string new_str_number = digit1.ToString() + digit3.ToString();
int new_number = Convert.ToInt32(new_str_number);
System.Console.WriteLine(new_number);
