using System;

namespace Sorting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 4, 67, 2, 56, 33, 476, 34, 789, 333, 645, 51, 43, 42, 41, 55, 999, 111 };
            int first = 0;
            int last = numbers.Length - 1;

            Display("Unsorted", numbers);
            int[] bubblesorted = BubbleSort(numbers);
            Display("Bubblesorted", bubblesorted);

            Display("Unsorted", numbers);
            int[] quicksorted = QuickSort(numbers, first, last);
            Display("Quicksorted", quicksorted);
        }  //end method Main

        public static void Display(string what, int[] numbers)
        {
            Console.Write("{0}: ", what);
            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }
            Console.WriteLine("\n");
        }  //end method Display

        public static int[] BubbleSort(int[] numbers)
        {
            bool swapped;
            int last = numbers.Length - 1;
            do
            {
                swapped = false;
                for (int i = 0; i < last; i++)
                {
                    if (numbers[i + 1] < numbers[i])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;

                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;
        }  //end method BubbleSort

        public static int[] QuickSort(int[] numbers, int left, int right)
        {
            if (left < right)
            {
                int pivotIx = Partition(numbers, left, right);
                if (pivotIx - 1 > left)
                {
                    QuickSort(numbers, left, pivotIx - 1);
                }
                if (pivotIx + 1 < right)
                {
                    QuickSort(numbers, pivotIx + 1, right);
                }
            }
            return numbers;
        }  //end method QuickSort

        public static int Partition(int[] numbers, int left, int right)
        {
            while (true)
            {
                int pivotVal = numbers[left];

                while (numbers[left] < pivotVal) left++;
                while (numbers[right] > pivotVal) right--;

                if (left < right)
                {
                    int temp = numbers[left];
                    numbers[left] = numbers[right];
                    numbers[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }  //end method Partition
    }  //end class Program
}  //end namespace Sorting
