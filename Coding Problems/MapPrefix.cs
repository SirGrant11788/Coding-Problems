using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{
    //Implement a PrefixMapSum class with the following methods:
    //insert(key: str, value: int) : Set a given key's value in the map. If the key already exists, overwrite the value.
    //sum(prefix: str) : Return the sum of all values of keys that begin with a given prefix.
    class MapPrefix
    {
        public static void PrefixSum()
        {
            var mapsum = new Dictionary<string, int>();
            char exit = 'y';
            while(exit == 'y')
            {
                Console.Write("enter key: ");
                string key = Console.ReadLine();
                Console.Write("enter value: ");
                int value = int.Parse(Console.ReadLine());
                
                    if (mapsum.ContainsKey(key))
                    {
                        mapsum[key] =mapsum[key] + value;
                    }
                    else
                    {
                        mapsum.Add(key, value);
                    }

                //exit
                Console.WriteLine("Type 'y' to enter new pair. Type 'n' to exit and see results");
                exit = Console.ReadLine()[0];//gets first char
            }
            
            //output result
            foreach (var itemOut in mapsum)
            {
                Console.WriteLine($"{itemOut.Key}: {itemOut.Value}");
            }
            Console.ReadKey();

        }
    }
}
