// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число пятизначное число N: ");
int number = int.Parse(Console.ReadLine());

int N1 = number / 10000 % 10;
int N2 = number / 1000 % 10;
int N3 = number / 10 % 10;
int N4 = number % 10;

if (number < 9999 || number > 999999)
{
    Console.WriteLine($"Число {number} не пятизначное. Введите пятизначное число!");
}
else if  (N1 == N4 && N2 == N3)
{
    Console.WriteLine($"Число {number} - палиндром");
}
else
{
    Console.WriteLine($"Число {number} не палиндром");
}
for (int i = 0; i < 10; i++);
