using System;
using Tyuiu.IzingerVA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IzingerVA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Влад"));
            Console.ReadKey();
        }
    }
}