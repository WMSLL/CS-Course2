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
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру у которой нужно посчитать площадь 'S'(Круг=1,Прямоугольник=2, Треугольник=3)");
            Square();
            Console.WriteLine("Нажмити любую клавишу");
            Console.ReadKey();
        }


        static void Square()
        {            
            var selectFigure = Enum.Parse(typeof(figure), Console.ReadLine().Replace(".", ","));
            try
            {
                switch (selectFigure)
                {
                    case figure.circle:
                        Console.WriteLine("Введите Радиус круга");
                        var radius = double.Parse(Console.ReadLine().Replace(".", ","));
                        Console.WriteLine($"Площадь круга равна {3.14 * Math.Pow(radius, 2)}");
                        break;

                    case figure.rectangle:
                        Console.WriteLine("Введите 1-ю сторону прямоугольника");
                        var side1 = double.Parse(Console.ReadLine().Replace(".", ","));
                        Console.WriteLine("Введите 2-ю сторону прямоугольника");
                        var side2 = double.Parse(Console.ReadLine().Replace(".", ","));
                        Console.WriteLine($"Площадь прямоугольника {(side1 * side2)}");
                        break;

                    case figure.triangular:
                        Console.WriteLine("Введите cторону равностороннего треугольника");
                        var sideTriangular = double.Parse(Console.ReadLine().Replace(".", ","));
                        Console.WriteLine($"Площадь равностороннего треугольника {(Math.Pow(sideTriangular, 2) * Math.Sqrt(3)) / 4}");
                        break;

                    default:
                        Console.WriteLine("Введена не существующая фигура");
                        Console.WriteLine("Повторите ввод фигуры у которой нужно посчитать площадь 'S'(Круг=1,Прямоугольник=2, Треугольник=3)");
                        Square();
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введено нечисловое значение!");
                Console.WriteLine("Повторите ввод фигуры у которой нужно посчитать площадь 'S'(Круг=1,Прямоугольник=2, Треугольник=3)");
                Square();              
            }
           
            
        }
    }
}
