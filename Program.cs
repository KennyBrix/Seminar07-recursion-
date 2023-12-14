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

// int ReadInt(string str)
// {
//     System.Console.Write(str);
//     return Convert.ToInt32(Console.ReadLine());
// }
// // вызов функции Аккермана
// void AkkermanFunction(int M, int N)
// {
//     Console.Write(Akkerman(M, N));
// }

// // функция Аккермана
// int Akkerman(int M, int N)
// {
//     if (M == 0)
//     {
//         return N + 1;
//     }
//     else if (N == 0 && M > 0)
//     {
//         return Akkerman(M - 1, 1);
//     }
//     else
//     {
//         return Akkerman(M - 1, Akkerman(M, N - 1));
//     }
// }
// // _____________________________
// int M = ReadInt("Введите первое значение: ");
// int N = ReadInt("Введите второе значение: ");

// AkkermanFunction(M, N);

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = CreateArray(10, 10, 0);
System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array, array.Length - 1))}]");


static int[] CreateArray(int size, int max, int min)
{
    int[] array = new int[size];
    Random rand = new();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}
static string PrintArray(int[] array)
{
    return string.Join(", ", array);
}
static int[] ArraySwap(int[] array, int index)
{

    if (index <= 0)
    {
        return array;
    }
    int temp = array[index];
    array[index] = array[array.Length - index - 1];
    array[array.Length - index - 1] = temp;
    return ArraySwap(array, index -= 2);
}