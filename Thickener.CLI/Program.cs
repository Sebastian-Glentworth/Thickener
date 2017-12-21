using System;
using Thickener;

namespace Thickener.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("Enter string to thicken");
                var thickened = Console.ReadLine().Thicken();
                Console.WriteLine(thickened);
                Console.ReadKey();
            }
            else
            {
                foreach (var a in args)
                {
                    Console.Write(a.Thicken() + " ");
                }
            }
        }
    }
}
