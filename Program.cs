using System;
using System.Collections;
using System.Collections.Generic;

namespace Csharp
{
    class Program
    {
        static void Main()
        {
            // System.Collections namespace'de bulunur.

            ArrayList liste = new ArrayList();

            //liste.Add("Furkan");
            //liste.Add(26);
            //liste.Add(true);
            //liste.Add(3.14);

            //foreach (var item in liste)
            //    Console.WriteLine(item);

            // Add.Range

            //Console.WriteLine("***** AddRange *****");

            //string[] diller = { "C#", "JavaScript", "Phyton" };
            List<int> maas = new List<int>() { 5500, 7000, 3555 };

            //liste.AddRange(diller);
            liste.AddRange(maas);

            foreach (var item in liste)
                Console.WriteLine(item);

            // Sort. Sort yapmak ArrayList'te tehlikeli çünkü birbirinden farklı değişkenler olduğu zaman compiler ederken hata vermez ama runtime'da hata verir.


            Console.WriteLine("***** Sort *****");

            liste.Sort();

            foreach (var item in liste)
                Console.WriteLine(item);

            // BinarySearch. Sort edilmemiş listelerde yanlış sonuç döndürür

            Console.WriteLine("***** Binary Search *****");

            Console.WriteLine(liste.BinarySearch(5500));

            // Reverse

            Console.WriteLine("***** Reverse *****");

            liste.Reverse();

            foreach (var item in liste)
                Console.WriteLine(item);

            // Clear

            Console.WriteLine("***** Clear *****");

            liste.Clear();

            foreach (var item in liste)
                Console.WriteLine(item);
        }
    }
}