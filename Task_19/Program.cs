// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите любое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 10 == number / 10000 && number % 100 / 10 == number / 1000 % 10)
    {
    Console.WriteLine($"палиндром");
    }
else
    {
    Console.WriteLine($"не палиндром");
    }