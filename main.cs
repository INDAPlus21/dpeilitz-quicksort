namespace Quicksort{
    class Main
    {
        static void Main(string[] args){
            var numbers = new[] {1, 5, 3 , 34, 9, 10};
            foreach (var number in numbers)
            {
                Console.writeLine(number);
            }
            Console.ReadKey();
        }
        private static void SortArray(int[] numbers){
            Quicksort(numbers, 0, numbers.length - 1);
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
        private int Partition(int[] numbers, int left, int right)
        {
            pivotValue = numbers[right];
            pivotIndex = left;
            for(int i = left; i<right; i++){
                if(numbers[i] <= numbers[pivotIndex]){
                    temp = numbers[i];
                    numbers[i] = numbers[pivotIndex];
                    numbers[i] = temp;
                    pivotIndex = pivotIndex + 1;
                }
            }
            return pivotIndex - 1;

        }
        private static void QuickSort(int[] numbers, int left, int right)
        {
            if(left >= right){
                return;
            }
            pivotIndex = Partition(numbers, left, right);
            QuickSort(numbers, left, pivotIndex - 1);
            QuickSort(numbers, pivotIndex + 1, right);
        }
    }
}