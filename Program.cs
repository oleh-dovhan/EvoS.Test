using System;

namespace EvoS.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var part = TribonacciSequence.GetPart(4, 10);
            foreach (var v in part)
            {
                Console.WriteLine(v);
            }
        }
    }
}
