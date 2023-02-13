// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53




void Distance(double x2, double x1, double y2, double y1, double z2, double z1)
{
    System.Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 3));
}

int InputNumber(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine();
int x1 = InputNumber("Введите координату х точки а: ");
int y1 = InputNumber("Введите координату y точки а: ");
int z1 = InputNumber("Введите координату z точки а: ");

int x2 = InputNumber("Введите координату х точки b: ");
int y2 = InputNumber("Введите координату y точки b: ");
int z2 = InputNumber("Введите координату z точки b: ");

Distance(x2, x1, y2, y1, z2, z1);
