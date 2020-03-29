using System;

namespace HomeWork5
{
    enum Figure
    {
        Circle = 1,
        Rectangle = 2,
        Triangular = 3
    }
    class Program
    {
        static void Main()
        {
            var selectFigure = Numeration("Выберите фигуру у которой нужно посчитать площадь 'S'(Круг=1,Прямоугольник=2, Треугольник=3)");
            switch (selectFigure)
            {
                case Figure.Circle:
                    double radius = ReadParam("Введите радиус круга");
                    Console.WriteLine($" Площадь круга :{Math.PI * Math.Pow(radius, 2)}");
                    break;
                case Figure.Rectangle:
                    double side1 = ReadParam("Введите сторону 'a' Прямоугольника");
                    double side2 = ReadParam("Введите сторону 'b' Прямоугольника");
                    Console.WriteLine($" Площадь прямоугольника :{side1 * side2}");
                    break;
                case Figure.Triangular:
                    double sideTriangular = ReadParam("Введите сторону равностороннего треугольника");
                    Console.WriteLine($" Площадь треугольного :{Math.Pow(sideTriangular, 2) * Math.Sqrt(3) / 4}");
                    break;
            }
            Console.WriteLine("Нажмити любую клавишу для завершения");
            Console.ReadKey();
        }
        static object Numeration(string title)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(title);
                    var values = Enum.Parse(typeof(Figure), Console.ReadLine());
                    if (Enum.IsDefined(typeof(Figure), values))
                    {
                        return Enum.Parse(typeof(Figure), values.ToString());
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Вы ввели не существующие значение");
                }
            }
        }



        static double ReadParam(string title)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(title);
                    return double.Parse(Console.ReadLine().Replace(".", ","));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не числовое значение, повторите ввод");
                }

            }
        }
    }
}
