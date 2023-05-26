using DataStructure;
using Day16_17DS;
using DelegatesAndEvents;

public class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Welcome to Data Structure");
        //Anagram anagram = new Anagram();
        //anagram.CheckAnagram();

        //BinarySearch search = new BinarySearch();
        // InsertionSort sort1 = new InsertionSort();

        //BubbleSort bubbleSort = new BubbleSort();
        //bubbleSort.ReadFile3("F:\\BL_.net278\\Demo\\Day16-17BL\\Day16&17DS\\Day16&17DS\\ABC.txt");
        string[] Arr= { "sun", "earth", "mars", "mercury" };  
        string[] a = MergeSort.mergeSort(Arr, 0, Arr.Length - 1);
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}