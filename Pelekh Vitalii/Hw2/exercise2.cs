using System;
using System.Collections.Generic;

namespace Hw2
{
    internal class exersice2
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> pairs = new Dictionary<uint, string>();
            uint id;
            string name;
            const int PERSONS = 7;

            Console.WriteLine("Enter pairs of persons:");
            for (int i = 0; i < PERSONS; i++)
            {
                Console.WriteLine($"\n{i + 1} persons' data: ");
                Console.Write($"Enter {i + 1} id : ");
                id = (uint)Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter {i + 1} name : ");
                name = Console.ReadLine();
                pairs.Add(id, name);
            }

            Console.WriteLine("\nEntered pairs: ");
            foreach (KeyValuePair<uint, string> keyValue in pairs)
            {
                Console.Write($"\n id({ keyValue.Key}) - name ({keyValue.Value})");
            }

            Console.Write("\n\nEnter searched id: ");
            uint searchedId = (uint)Convert.ToInt32(Console.ReadLine());
            foreach (KeyValuePair<uint, string> localId in pairs)
            {
                if (localId.Key == searchedId)
                {
                    Console.WriteLine($"Person {localId.Value} has id({searchedId}).");
                    break;
                }

            }
        }
    }
}
