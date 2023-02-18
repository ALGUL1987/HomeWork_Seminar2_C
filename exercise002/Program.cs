/*
Напишите программу, которая выводит третью цифру заданного семизначного числа или 
сообщает, что третьей цифры нет.

78 -> третьей цифры нет

3267900 -> 6
*/

Console.WriteLine("Введите семизначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999999 && number < 10000000)
{
    int valL = (number - (number / 100000) * 100000 - number % 10000) / 10000;
    int valR = (number - (number / 1000) * 1000 - number % 100) / 100;
    Console.WriteLine($"Третьей цифрой слева в {number} является {valL}, третьей цифрой справа - {valR}");
}
else if (number < 100)
{
    Console.WriteLine($"Третьей цифры в числе {number} нет");
}
else
    Console.WriteLine("Введите семизначное число");