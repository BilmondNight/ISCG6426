using System;
using System.Collections.Generic;
using System.Text;

namespace Week3
{
    class Search
    {
        public static int ArrayBinarySearch(int[] array, int value)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (value == array[mid])
                {
                    return ++mid;
                }
                else if (value < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        public static int LinearRecursive(int[] array, int target, int index)
        {
            if (array[index] == target)
                return index;
            if (index == array.Length - 1)
                LinearRecursive(array, target, index + 1);
            return -1;
        }

        public static int BinaryRecursive(int[] array, int target, int min, int max)
        {
            if (max >= min)
            {
                int mid = (int)((max + min) * 0.5);
                if (array[mid] == target)
                    return mid;
                if (array[mid] > target)
                    return BinaryRecursive(array, target, min, mid - 1);
                else
                    return BinaryRecursive(array, target, mid + 1, max);
            }
            return -1;
        }
    }
}
