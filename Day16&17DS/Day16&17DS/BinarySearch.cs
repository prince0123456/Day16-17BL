using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BinarySearch
    {
        public void ReadFile(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                Console.WriteLine(data);
            }
            Console.Write("Enter word to search: ");
            string search = Console.ReadLine();
            foreach (var data in words)
            {
                if (data.Equals(search))
                {
                    Console.WriteLine("Found");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }
    }
}

