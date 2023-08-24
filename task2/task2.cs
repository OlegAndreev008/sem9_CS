// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int Summ(int a, int b)
{
    if (a > b) return 0;
    else return a + Summ(a + 1, b);
}
Console.WriteLine($"Сумма чисел от {number1} до {number2} равна {Summ(number1, number2)}");