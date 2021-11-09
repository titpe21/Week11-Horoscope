using System;
using System.IO;

namespace Horoscope
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your horoscope sign:");
            string userSign = Console.ReadLine();
            Console.WriteLine(GetHoroscope(userSign));
            
        }
        //a function to open and read the file
        public static string[] ReadHoroScope()
        {
            //absolute file path
            string filePath = @"C:\Users\opilane\samples\horoscope.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);            
            return dataFromFile;
        }

        public static string GetHoroscope(string userInput)
        {
            string[] horoscope = ReadHoroScope();
            string todayHoroscope = "";

            foreach(string element in horoscope)
            {
                if (element.Contains(userInput))
                {
                    todayHoroscope = element;
                }
            }

            return todayHoroscope;
        }




    }
}
