using System;

namespace HomeWork5
{
    enum Figure
    {
        circle = 1,
        rectangle = 2,
        triangular = 3
    }
    class Program
    {
        static void Main()
        {
        returnenum:
            var selectFigure = numeration("Выберите фигуру у которой нужно посчитать площадь 'S'(Круг=1,Прямоугольник=2, Треугольник=3)");

            switch (selectFigure)
            {
                case Figure.circle:
                    double radius = ReadParam("Введите радиус круга");
                    Console.WriteLine($" Площадь круга :{Math.PI * Math.Pow(radius, 2)}");
                    break;

                case Figure.rectangle:
                    double side1 = ReadParam("Введите сторону 'a' Прямоугольника");
                    double side2 = ReadParam("Введите сторону 'b' Прямоугольника");
                    Console.WriteLine($" Площадь круга :{side1 * side2}");
                    break;

                case Figure.triangular:
                    double sideTriangular = ReadParam("Введите сторону равностороннего треугольника");
                    Console.WriteLine($" Площадь треугольного :{Math.Pow(sideTriangular, 2) * Math.Sqrt(3) / 4}");
                    break;
                default:
                    Console.WriteLine("Ввели не существующие значение .");
                    goto returnenum;
                   
            }
            Console.WriteLine("Нажмити любую клавишу для завершения");
            Console.ReadKey();
        }

        static object numeration(string title)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(title);
                    return Enum.Parse(typeof(Figure), Console.ReadLine());
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Ввели не существующие значение .");
                    Console.WriteLine(title);
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
