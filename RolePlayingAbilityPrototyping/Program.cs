using System;

namespace RolePlayingAbilityPrototyping
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena();

            arena.Battle();

            wait();
        }

        private static void wait()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Done, press any key to close application");
            Console.ReadKey();
        }
    }
}
