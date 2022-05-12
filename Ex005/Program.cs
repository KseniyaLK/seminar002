//  Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого. 
//  5, 25  ->  да-4, 16  ->  да 25, 5  ->  да 12 мин 8,9  ->  нет

Console.WriteLine("введите первое число ");
int num1 =Convert.ToInt32(Console.ReadLine ());

Console.WriteLine("введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine ());

int res = num1*num1;
if (res == num2) Console.WriteLine ($"{num2} является квадратом {num1}");
else Console.WriteLine ($"{num2} не является квадратом {num1}");
