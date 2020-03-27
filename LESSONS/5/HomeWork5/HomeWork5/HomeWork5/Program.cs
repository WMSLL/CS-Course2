using System;

namespace HomeWork5
{
    enum figure
    {
        circle = 1,
        rectangle = 2,
        triangular = 3
    }
    class Program
    {
        static void Main()
        {
            area();
        }

        static void area()
        {
        returnenum:
            Console.WriteLine("Выберите фигуру у которой нужно посчитать площадь 'S'(Круг=1,Прямоугольник=2, Треугольник=3)");
            try
            {
                var selectFigure = Enum.Parse(typeof(figure), Console.ReadLine());
                switch (selectFigure)
                {
                    case figure.circle:
                        double radius = ReadParam("Введите радиус круга");
                        Console.WriteLine($" Площадь круга :{Math.PI * Math.Pow(radius, 2)}");
                        break;

                    case figure.rectangle:
                        double side1 = ReadParam("Введите сторону 'a' Прямоугольника");
                        double side2 = ReadParam("Введите сторону 'b' Прямоугольника");
                        Console.WriteLine($" Площадь круга :{side1 * side2}");
                        break;

                    case figure.triangular:
                        double sideTriangular = ReadParam("Введите сторону равностороннего треугольника");
                        Console.WriteLine($" Площадь треугольного :{Math.Pow(sideTriangular, 2) * Math.Sqrt(3) / 4}");
                        break;

                    default:
                        Console.WriteLine("Ввели не верную фигуру повторите ввод");
                        goto returnenum;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ввели не существующие значение");
                goto returnenum;
            }
            Console.WriteLine("Нажмити любую клавишу для завершения");
            Console.ReadKey();
        }

        static double ReadParam(string title)
        {
            for (; ; )
            {
                try
                {
                    Console.WriteLine(title);
                    return double.Parse(Console.ReadLine().Replace(".", ","));
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не числовое значение, повторите ввод");
                }

            }
        }
    }
}
