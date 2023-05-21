using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class BubbleSort
    {
        public void ReadFile3(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            int[] arr = new int[words.Length];
            int count = 0;
            foreach (var data in words)
            {
                arr[count] = Convert.ToInt32(data);
                count++;
                Console.WriteLine(data);
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (var data in arr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
