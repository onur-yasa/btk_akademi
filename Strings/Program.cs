﻿using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Demiroğ";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "my name is derin demiroğ";

            bool result3 = sentence.EndsWith("ğ");
            bool result4 = sentence.StartsWith("m");

            var result5 = sentence.IndexOf("name");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");
            var result8 = sentence.Insert(0, "Hello, ");
            var result9 = sentence.Substring(3,4);//metni parçalamak için kullanılır
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ","-");
            var result13 = sentence.Remove(2,5);
            Console.WriteLine(result13);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";

            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
