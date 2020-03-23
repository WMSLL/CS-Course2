using System;

namespace ClassWork4
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            
            // Префиксный инкримент ++i
            int a = 0;
            int b = 0;
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            // Постфиксный инкримент ++i
            int c = 0;
            int d = 0;
            c = d++;
            Console.WriteLine(a);
            Console.WriteLine(b);




            // Префиксный Дикримент --i
            int q = 0;
            int w = 0;
            q = --w;
            Console.WriteLine(q);
            Console.WriteLine(w);

            // Постфиксный Дикримент --i
            int e = 0;
            int r = 0;
            e = r--;
            Console.WriteLine(e);
            Console.WriteLine(r);


            //  Циклы
            // for (int i = 0; i < length; i++)
            // {
            //
            // }
            //
            // обратный цикл
            // for (int i = length - 1; i >= 0; i--)
            // {
            //
            // }


            var array = new string [2];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine();
            }


           
            
            for (int i = 0; i != array.Length; i++)
            {
                Console.WriteLine();
            }


            var g = 9.8;

            int f = (int)g;


            var i = 9.5;
            Console.WriteLine(Math.Round(i));

            Console.WriteLine( Math.);
        }
    }
}
