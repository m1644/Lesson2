// Важное!!!

// $$ - обозначает "И"
// || - обозначает "ИЛИ"

// Возведение в степень!
//int a = 2;
//int b = Convert.ToInt32(Math.Pow(a, 5));
//System.Console.WriteLine(b);

// Корень квадратный!
//int a = 81;
//int b = Convert.ToInt32(Math.Sqrt(a));
//System.Console.WriteLine(b);

// [-10, 10]
//new Random().Next(-10, 11);

// [0, 10.0] (double)
//double n = new Random().NextDouble() * 10; // [0, 1)
//System.Console.WriteLine(n);

// [-10.0, 10.0) (double)
//double n = new Random().NextDouble() * 20 - 10;
//System.Console.WriteLine(n);

// [100.0, 150.0) (double)
double n = new Random().NextDouble() * 50 + 100;
System.Console.WriteLine(n);
