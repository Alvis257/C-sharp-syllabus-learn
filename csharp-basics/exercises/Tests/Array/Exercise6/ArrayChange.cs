using System;

namespace Exercise6
{
    public class ArrayChange
    {
        public static void PutInArrayRandomNumbers(Random randomNum, int[] array, int[] copyArray)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNum.Next(1, 100);
                copyArray[i] = array[i];
            }
        }

        public static void ChangeArray(int[] copyArray)
        {
            copyArray[copyArray.Length - 1] = -7;
        }
    }
}
