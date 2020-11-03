using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 4;        
            ushort b = a;
            ushort a1 = a;
            sbyte c = 3;
            short d = c;
            short c1 = c;
            sbyte e = -4;
            short f = e;
            short e1 = c;
            byte r = (byte)(c + e);
            int k = (int)(a + b - e);
            short l = (short)(c + e);
            Object obj = r;
            byte only_k = (byte)obj;
        }
    }
}
