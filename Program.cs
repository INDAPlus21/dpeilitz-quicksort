using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dpeilitz_quicksort
{
    class Program
    {
        static void Main(string[] args){
            //parse input
            string line; 
            line = Console.ReadLine();

            string[] strings = line.Split();
            //remove first element from array
            strings = strings.Skip(1).ToArray();

            //convert to int array
            int[] nums = Array.ConvertAll(strings, s => int.Parse(s));

            if(nums.Length != 0) {
                SortArray(nums);
            }  

            //convert back to original format
            string output = String.Join("\n", nums);
            Console.WriteLine(output);
        }
        private static void SortArray(int[] numbers){
                QuickSort(numbers, 0, numbers.Length - 1);
                // TA BORT numbers.Sort();
        }

        private static void QuickSort(int[] numbers, int left, int right)
        {
            
            //  base case: array size <= 1
             if (numbers.Length < 100) {
                InsertSort(numbers);
                return;
            } 

            if (left >= right) {
                return;
            }

                int pivot = Partition(numbers, left, right);
            
                    QuickSort(numbers, left, pivot);
                    QuickSort(numbers, pivot + 1, right);
        }
        private static int Partition(int[] numbers, int left, int right)
        {   
            // choose the leftmost element as the pivot
            int pivot = numbers[(left + right )/ 2 ];
            int pivL = left - 1;
            int pivR = right + 1;

            while(true){   
                while(numbers[++pivL] < pivot);
                while(numbers[--pivR] > pivot);

                if(pivL >= pivR){
                    return pivR;
                }
                int temp = numbers[pivR];
                numbers[pivR] = numbers[pivL];
                numbers[pivL] = temp;
            }
        }
        
         private static void InsertSort(int[] numbers) {
             for(int i = 1; i < numbers.Length; i++) {
                 int key = numbers[i];
                 int j = i-1;

                 while(j >= 0 && numbers[j] > key){
                     numbers[j+1] = numbers[j];
                     j = j-1;
                     numbers[j+1] = key;
                 } 
             }
         }
    }
}
