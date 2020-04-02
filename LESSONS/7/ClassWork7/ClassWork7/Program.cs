using System;

namespace ClassWork7
{
    class Program
    {
        static void Main(string[] args)
        {

            var text = "   loren        ipsum  dolor        sit amet   ";
            var textMody = text.Trim();
            var textArray = textMody.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var textModyArray = new string[textArray.Length];

            var textMody2 = text.TrimEnd();
            var indexEndWord = textMody2.LastIndexOf("amet");

            
            for (int i = 0; i < textArray.Length; i++)
            {
                string word = textArray[i];
                textModyArray[i] = i == 1 ? word.ToUpper() : word;
            }
            Console.WriteLine(string.Join(' ', textModyArray));
            Console.WriteLine(textMody2.Substring(0, indexEndWord));
            //var testString = "Test string";
            //
            //Console.WriteLine(testString.Contains(' '));// true or false
            //Console.WriteLine(testString.StartsWith('T'));// true or false
            //Console.WriteLine(testString.EndsWith('s'));// true or false
            //
            //Console.WriteLine(testString.IndexOf("st")); // return index 
            //Console.WriteLine(testString.LastIndexOf("st")); // return index 

            //var text = "   lorem    ipsum  dolor        sit\tamet       ";
            //var array = text.Split(new[] {' ','\t'},StringSplitOptions.RemoveEmptyEntries);            
            //var upperTwoWord = new  string[array.Length];
            //var cammelCase = new string[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    string word = array[i];
            //    upperTwoWord[i] = i == 0   // когда i равна 1-му элементу масива, тогда '?' в верхнем регистер иначе ':' как есть
            //                      ? word.ToLower()
            //                      : char.ToUpper(word[0]) + word.Substring(1).ToLower();
            //    cammelCase[i] = char.ToUpper(word[0]) +word.Substring(1).ToLower();
            //    Console.WriteLine(upperTwoWord[i]);
            //}
            //
            //Console.WriteLine(string.Join(' ', upperTwoWord));
            //var subString = string.Join(' ', array);
            //var indexSub = subString.IndexOf("amet");
            //Console.WriteLine(subString.Substring(0, indexSub));
            //Console.WriteLine("Press any key");
            //Console.ReadKey();
            ///// Форматирование /////
            /*
             var a = 15.33;
             var b = Math.PI;
             
             Console.WriteLine($"{a} + {b:0.###} = {a+b:0.###}");
             Console.WriteLine( "Перемножить: "+a+"*"+b.ToString("0.##") + "="+(a*b).ToString("0.##"));
             Console.WriteLine("Вычисть из {0}-{1:0.##}= {2:0.##}",a,b,a-b);
             */


            //var tab = "Сделаем табуляцию перед \tвот этими словами";
            //Console.WriteLine(tab);

            //var nextLine = "Переведем на следующую строку\nвот эти слова";
            //Console.WriteLine(nextLine);

            //var sound = "\a";
            //Console.WriteLine(sound);



        }



    }
}
