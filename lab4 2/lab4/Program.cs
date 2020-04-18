using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Victoria
{
    class Program
    {
        [DllImport("C:\\Users\\User\\source\\repos\\lab4\\lab4\\max.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Max(int a, int b);
        static void Main(string[] args)
        {
            int c = Max(2000, 100);
            Console.WriteLine("{0}", c);

        }
    }
}
