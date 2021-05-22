using System;
using System.Threading;

namespace Game
{
    class Game
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, there");
            // Thread.Sleep(TimeSpan.FromSeconds(4));
            // Console.WriteLine("Your still here wow");
            // Console.WriteLine("Press any key to end program");
            // while (Console.KeyAvailable) Console.ReadKey(true);
            // Console.ReadKey();
        }

        static void DelayPrint(string args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Thread.Sleep(TimeSpan.FromMilliseconds(100));
                Console.Write(args[i]);
            }
        }
    }
}
