// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// A(m,n) = n + 1               ; m = 0
// A(m,n) = A(m-1, n)           ; m > 0, n = 0
// A(m,n) = A(m-1, A(m, n-1))   ; m > 0, n > 0

Console.Write("Введите M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, n);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine($"Для чисел {number1} и {number2} значение функции Аккермана равно {Akkerman(number1, number2)}");