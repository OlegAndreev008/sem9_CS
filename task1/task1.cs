// Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите N: ");
int number = Convert.ToInt32(Console.ReadLine());
string Order (int a)
{
    if (a == 0) return string.Empty;
    else return $"{a} " + Order(a - 1);
}
Console.WriteLine(Order(number));
