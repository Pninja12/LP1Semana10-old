using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Pedro", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }
        }
    }
}
