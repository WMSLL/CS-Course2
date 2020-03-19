using System;

namespace ClassWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // //ConsoleKeyInfo key = Console.ReadKey(); 
            // //Console.WriteLine(key.Key);
            //
            // object o=34.55;
            // Console.WriteLine(23.Equals(10)); // Equals Сравнение 23 c 10 Возврат Bool
            // Console.WriteLine(23.GetType()); // Указывает тип данных
            //
            // System.Type type11= 35.GetType();//  Возвращает инфу по типу данных
            // Console.WriteLine(type11);
            //
            // object name = "Andr";
            //
            // int lenght22 = ((string)name).Length; // Приведение к типу
            //
            // float test = 1.12f + 2.45f;
            //
            // float test2 = (float)(1.12+2.45);
            // float test3 = (float)1.12 + (float)2.45;
            //
            // 
            // // Все что(Какой тип) в Object Положено достать можно только тот же тип
            // short sh = 10;
            //
            // object shObject = sh;
            //
            // //int interNUm = (int) shObject;// Раблтать не будет, Исключение
            // int interNUm = (Int16)shObject; // работать будет


            //int a = 10;
            //
            //string name = "100";
            //
            //name = new string('c', 1000);
            //
            //Console.WriteLine($"{default(int)}");// 0
            //
            //Console.WriteLine($"{default(bool)}");// false
            //
            //Console.WriteLine($"{default(DateTime)}");// 1/01/0001 00:00:00
            //
            //Console.WriteLine($"{default(string)}");// ???
            //
            //int? AAA = null; // Знак "?" Дает возможность присвоить NULL 
            //Nullable<Int32> iii = null;  // Так делает компелятор

            // Масивы

            //string[] name = new string[4];
            //
            //name[0] = "Andrey";
            //name[2] = "Viktor";
            //name[2] = "Olga";
            //name[2] = "Valy";
            //
            //
            //for (int i =0; i<4;i++)
            //{
            //    Console.WriteLine("a");
            //}


            // Самостоятельная работа
            //Считать кол-во эле ентов в масиве
            // создать масив этого размера
            //проинициализировать каждый элемент с консоли

            Console.WriteLine("Введите количество Элементов массива");

            int count = int.Parse(Console.ReadLine());

            string[] names = new string[count]; 


            for (int i =0;i< names.Length; i++)
            {
                
                Console.WriteLine("Заполните "+ i.ToString()+" элемент Массива");
                names[i] = Console.ReadLine();
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
