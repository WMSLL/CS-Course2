using System;

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleKeyInfo key = Console.ReadKey(); 
            //Console.WriteLine(key.Key);

            object o=34.55;
            Console.WriteLine(23.Equals(10)); // Equals Сравнение 23 c 10 Возврат Bool
            Console.WriteLine(23.GetType()); // Указывает тип данных

            System.Type type11= 35.GetType();//  Возвращает инфу по типу данных
            Console.WriteLine(type11);

            object name = "Andr";

            int lenght22 = ((string)name).Length; // Приведение к типу

            float test = 1.12f + 2.45f;

            float test2 = (float)(1.12+2.45);
            float test3 = (float)1.12 + (float)2.45;

            
            // Все что(Какой тип) в Object Положено достать можно только тот же тип
            short sh = 10;

            object shObject = sh;

            //int interNUm = (int) shObject;// Раблтать не будет, Исключение
            int interNUm = (Int16)shObject; // работать будет

        }
    }
}
