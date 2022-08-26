using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort

            int[] sayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("***Sırasız Dizi***");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***Sıralı Dizi***");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Clear
            //sayıDizisi elemanlrı kullnararak 2. indexten itibaren 2 sayı sildi

            Console.WriteLine("***Array Clear***");
            Array.Clear(sayiDizisi,2,2);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //Reverse
            //ters çevirme
            
            Console.WriteLine("***Array Reverse***");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }

            //IndexOf

            Console.WriteLine("***Array IndexOf***");  
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("***Array Resize***");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine(item);
            }



        }
    }
}