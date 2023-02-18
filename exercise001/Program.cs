/*
Напишите программу, которая принимает на вход трёхзначное число и на
выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = (number - (number / 100)*100 - number % 10)/10;
    Console.WriteLine($"Вторая цифра в {number} является {result}");
}
else
    Console.WriteLine($"Число {number} не является трехзначным");