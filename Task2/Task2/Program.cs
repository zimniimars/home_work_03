using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1 = 13;
            System.Int32 a2 = 14;
            sbyte a3 = 15;
            System.SByte a4 = 16;

            Console.WriteLine("a1: " + a1.GetType());
            Console.WriteLine("a2: " + a2.GetType());
            Console.WriteLine("a3: " + a3.GetType());
            Console.WriteLine("a4: " + a4.GetType());
        }
    }
}
