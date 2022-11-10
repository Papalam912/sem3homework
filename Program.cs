// Console.WriteLine("Hello, World!");

Console.Clear();

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 99999)
{
    Console.Write("вы ввели не пятизначное число, повторите ввод: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num2 > 9999 || num2 < 100000)
    {
        num = num2;
    }
}
if (num / 10000 == num % 10 || num / 10000 % 10 == num / 10 % 10)
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"число {num} не является палиндромом");
}


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("введите X1: ");
// int X1 = int.Parse(Console.ReadLine());
// Console.Write("введите Y1: ");
// int Y1 = int.Parse(Console.ReadLine());
// Console.Write("введите Z1: ");
// int Z1 = int.Parse(Console.ReadLine());
// Console.Write("введите X2: ");
// int X2 = int.Parse(Console.ReadLine());
// Console.Write("введите Y2: ");
// int Y2 = int.Parse(Console.ReadLine());
// Console.Write("введите Z2: ");
// int Z2 = int.Parse(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
// Console.WriteLine($"d = {d:f3}");


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("введите число N: ");
// int N = int.Parse(Console.ReadLine());
// for (int i = 1; i <= N; i++)
// {
//     Console.Write($"{i * i * i} ");
// }
