using System;
using System.Collections.Generic;

namespace StringCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            var names = new List<string> { "Pedro", "Ana", "Felipe" };
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }
            //https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections

            //Stack<T>
            Stack<string> myStack = new Stack<string>();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            Console.WriteLine( "myStack" );
            Console.WriteLine( "\tCount:    {0}", myStack.Count);
            Console.Write( "\tValues:" );
            foreach ( Object obj in myStack)
                Console.Write( "    {0}", obj);
            Console.WriteLine();
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-7.0

            //Queue<T>
            Queue<string> myQ = new Queue<string>();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Displays the properties and values of the Queue.
            Console.WriteLine( "myQueue" );
            Console.WriteLine( "\tCount:    {0}", myQ.Count );
            Console.Write( "\tValues:" );
            foreach ( Object obj in myQ )
                Console.Write( "    {0}", obj );
            Console.WriteLine();
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.queue?view=net-7.0

            //HashSet<T>
            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                // Populate numbers with just even numbers.
                evenNumbers.Add(i * 2);

                // Populate oddNumbers with just odd numbers.
                oddNumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            Console.Write("{");
            foreach (int i in evenNumbers)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            Console.Write("{");
            foreach (int i in oddNumbers)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");

            // Create a new HashSet populated with even numbers.
            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);
            Console.Write("{");
            foreach (int i in numbers)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
            //https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1.-ctor?view=net-7.0
        }
    }
}
