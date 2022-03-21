using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dpeilitz_quicksort
{
    class Program
    {
        static void Main(string[] args){
            int[] numbers = new int[] {1, 5, 3 , 34, 9, 10};
            SortArray(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
        private static void SortArray(int[] numbers){
            QuickSort(numbers, 0, numbers.Length - 1);
        }
        /* 
        function QUICKSORT(ARRAY, START, END)			(1)
            #   base case size <= 1		
            if START >= END then					    (2)		
                return						            (3)
            end if							            (4)
            PIVOTINDEX = PARTITION(ARRAY, START, END)	(5)
            QUICKSORT(ARRAY, START, PIVOTINDEX – 1)		(6)
            QUICKSORT(ARRAY, PIVOTINDEX + 1, END)		(7)
            end function							        (8)
         */
        private static void QuickSort(int[] numbers, int left, int right)
        {
            
            //  base case: array size <= 1
            if(left < right){

            
            int pivot = Partition(numbers, left, right);
            QuickSort(numbers, left, pivot - 1);   
            QuickSort(numbers, pivot + 1, right);
            }
        }
         /*
         function PARTITION(ARRAY, START, END)			(1)
            PIVOTVALUE = ARRAY[END]				        (2)
            PIVOTINDEX = START					        (3)
            loop INDEX from START to END				(4)
                if ARRAY[INDEX] <= PIVOTVALUE			(5)
                    TEMP = ARRAY[INDEX]        		    (6)
                    ARRAY[INDEX] = ARRAY[PIVOTINDEX]	(7)
                    ARRAY[PIVOTINDEX] = TEMP			(8)
                    PIVOTINDEX = PIVOTINDEX + 1		    (9)
                end if						            (10)
            end loop							        (11)
            return PIVOTINDEX – 1					    (12)
         */
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
