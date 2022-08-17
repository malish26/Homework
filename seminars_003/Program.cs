// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();

// bool IsPalindrome(string s)
// {
//     for (int i = 0; i < s.Length / 2; ++i)
//         if (s[i] != s[s.Length - 1 - i]) return false;
//     return true;
// }
// Console.WriteLine(IsPalindrome(number) == true ? "Число является палиндромом" : "Число не является палиндромом");


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();


// void distance(double a, double b, double c, double d, double e, double f)
// {
//     Console.WriteLine($"Расстояние между точками равно {Math.Round(Math.Sqrt(Math.Pow(a - d, 2) + Math.Pow(b - e, 2) + Math.Pow(c - f, 2)), 2)}");
// }
// Console.WriteLine("Введите координаты двух точек в 3D пространстве, а я расчитаю расстояние между ними");

// Console.Write("Координата x первой точки: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата y первой точки: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата z первой точки: ");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.Write("Координата x второй точки: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата y второй точки: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.Write("Координата z второй точки: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// distance(xa, ya, za, xb, yb, zb);



// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


allCubeNumber(checkValue());
void allCubeNumber(int N)
{
    for (int i = 1; i <= N; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine($"Digit (i) at cube = {result}");
    }
}
int checkValue()
{
    int digit = 0;
    bool value;
    do 
    {

        value = int.TryParse(Console.ReadLine(), out digit);
        if (digit < 0)
        {
            value = false;
        }
    } while(!value);
    return digit;
}
