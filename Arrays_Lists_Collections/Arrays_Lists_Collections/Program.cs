using System;
using System.Collections.Generic;

namespace Arrays_Lists_Collections
{
    class Program
    {
        static void Main(string[] args)
        {

           // workingWithStrings();
            workingWithotherTypes();

        }
        public static void workingWithotherTypes()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while(fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            

            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);

        }
            public static void workingWithStrings()
        {
            //lists and arrays
            var names = new List<string> { "<name>", "Ana", "Felipe" };
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }


            Console.WriteLine($"Hello {names[1].ToUpper()}!");
            Console.WriteLine($"The list has {names.Count} people in it");


            //search 

            var index = names.IndexOf("Maria");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");


            //sort
            names.Sort(); // in place sorting
            foreach (string name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
