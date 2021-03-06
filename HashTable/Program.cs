﻿using System;
using System.Linq;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table");
            MyMapNode<string, int> hash = new MyMapNode<string, int>(5);

            string input = "“paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Console.WriteLine("Input Statement is: ");
            Console.WriteLine(input);
            string[] inputArray = input.Split(" ");
            foreach(string word in inputArray)
            {
                if (hash.Get(word) == 0)
                {
                    hash.Add(word, 1);
                    
                }
                else
                {
                    int value = hash.Get(word) + 1;
                    hash.Set(word, value);
                }
            }

            hash.Remove("avoidable");

            string []newInputArray = inputArray.Distinct().ToArray();
            foreach(var word in newInputArray)
            {
                Console.WriteLine("The frequency of occurrence of \"" + word + "\" is: " + hash.Get(word));
            }
        }
    }
}
