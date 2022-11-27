// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Программа которая возводит число А в натуральную степень В");
Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");
int numberB = int.Parse(Console.ReadLine()!);

void Exponentiation()
{
    int count = 0;
    double result = 1;

    // Для положительной степени

    if (numberB > 0)
    {
        while (count < numberB)
        {
            result = result * numberA;
            count++;
        }
        Console.WriteLine("Результат " + numberA + " ^ " + numberB + " = " + result);
    }
}
Exponentiation();




