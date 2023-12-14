// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// int ReadInt(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void PrintNumbers(int M, int N)
// {
//     if (M > N)
//         return;
//     Console.Write(M + " ");
//     PrintNumbers(M + 1, N);
// }

// // ----------------------
// int M = ReadInt("Введите первое значение: ");
// int N = ReadInt("Введите второе значение: ");

// PrintNumbers(M, N);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}
// вызов функции Аккермана
void AkkermanFunction(int M, int N)
{
    Console.Write(Akkerman(M, N));
}

// функция Аккермана
int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }
}
// _____________________________
int M = ReadInt("Введите первое значение: ");
int N = ReadInt("Введите второе значение: ");

AkkermanFunction(M, N);

