// Задача 13: Напишите программу, которая выводит третью
//  цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
bool status = true;
while (status)
{
    if(number > 99 && number <1000)
    {
        result = number % 10;
        Console.WriteLine($"{result}");
        status = false;
    } else if (number < 99)
    {
        Console.WriteLine($"третьей цифры нет");
        status = false;
    } else
    {
       number = number / 10;
    }
}
    