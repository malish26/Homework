// Задача 01: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();

// int number = new Random().Next(100,1000);
// int secondNumber = number / 10 % 10;
// Console.WriteLine($"Вторая цифра в числе {number} -> {secondNumber}");






// Задача 02: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0)
// {
//     number = number * -1;
// }
// if (number > 0 && number < 100)
// { 
//     Console.WriteLine("Третьей цифры нет");
// }
// else
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
//     int thirdnumber = number % 10;
//     Console.WriteLine("Третья цифра" + thirdnumber);
// }






// Задача 03: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.Write("Введите число");
// int number = int.Parse(Console.ReadLine());
// if (number > 7 || number < 1)
// { 
//     Console.WriteLine("Неверный день недели");
// }
// if (number < 7 || number >1)
// {
//     Console.WriteLine("Да");
// }

