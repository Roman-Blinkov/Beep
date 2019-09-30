using System;

namespace Beep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beep with arguments. Press enter");
            Console.ReadLine();
            Console.Beep(500, 300);
            Console.WriteLine("Beep without arguments. Press enter");
            Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Beep finished. Press enter to exit");
            Console.ReadLine();
        }
    }
}
