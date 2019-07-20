using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercise.ExcersiseClasses
{
    public class DuplicateZerosExcercise
    {
        public void DuplicateZeros(int[] arr)
        {
            int count = 0;
            int k = 0;
            int[] arr2 = new int[arr.Length];
            for (int i = 0; i < arr.Length -count; i++)
            {
                if (arr[i] == 0)
                {
                    arr2[k] = 0;
                    arr2[k + 1] = 0;
                    count++;
                    k += 2;
                }
                else
                {
                    arr2[k] = arr[i];
                    k++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr2[i];
            }
        }
    }
}
