using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter words to check for anagram");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            if (word1.Length != word2.Length)
            {
                Console.WriteLine("Given words are not an anagram");
            }
            else
            {
                char[] result1 = word1.ToCharArray();
                Array.Sort(result1);
                word1 = result1.ToString();
                char[] result2 = word2.ToCharArray();
                Array.Sort(result2);
                word2 = result1.ToString();
                if (word1.Equals(word2))
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not an Anagram");
                }
            }
        }
    }
}

