using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Classes
    {
        public static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
