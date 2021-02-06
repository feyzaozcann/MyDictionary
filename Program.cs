using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int > MyDictionary = new Dictionary<string, int>();

            MyDictionary.Add("Feyza", 20);
            MyDictionary.Add("Beyza", 21);
            MyDictionary.Add("Nuray", 19);
            MyDictionary.Add("Furkan", 16);

            foreach (var item in MyDictionary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }


            Console.WriteLine();
            Console.WriteLine("Feyza Removed");
            Console.WriteLine();
            MyDictionary.Remove("Feyza");

            foreach (var item in MyDictionary)
            {
                Console.WriteLine("{0}:{1}" , item.Key , item.Value);
            }

            Console.WriteLine();

            MyDictionary.Add("Ali",5);

            Console.WriteLine("Ali Added");
            Console.WriteLine();

            foreach (var item in MyDictionary)

            {
                Console.WriteLine("{0}:{1}" , item.Key , item.Value);
            }
        }
    }

    
}


