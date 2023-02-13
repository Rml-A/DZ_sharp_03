// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int N = InputNumber("Введите число: ");

for (int i = 1; i <= N; i++)
{
    if (i == N)
    {
        System.Console.Write($"{Math.Pow(i, 3)}. ");
        break;
    }
    System.Console.Write($"{Math.Pow(i, 3)}, ");
    
}