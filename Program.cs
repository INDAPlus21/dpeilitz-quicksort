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
        }

        private static void QuickSort(int[] numbers, int left, int right)
        {
            
            //  base case: array size <= 1
            if(left < right){


                int pivot = Partition(numbers, left, right);
            
                if (pivot > 1) {
                    QuickSort(numbers, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    QuickSort(numbers, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[right];
            int pivotIndex = left;
            for(int i = left; i <= right; i++){
                if (numbers[i] <= pivot){
                    int temp = numbers[i];
                    numbers[i] = numbers[pivotIndex];
                    numbers[pivotIndex] = temp;
                    pivotIndex++;
                } 
            }
            return pivotIndex - 1;
        }
    }
}
