// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да




// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int number = InputNumber("Введите пятизначное число: ");

if (number > 10000 && number < 100000)
{
    char[] array = number.ToString().ToCharArray();
    if (array[0] == array[4] && array[1] == array[3])
    {
        System.Console.Write("Да, палиндром");
    }
    else
    {
        System.Console.Write("NO!");
    }
}
else
{
    System.Console.Write("Число не является пятизначным");
}

