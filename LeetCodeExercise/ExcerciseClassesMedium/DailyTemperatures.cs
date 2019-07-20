using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercise.ExcersiseClassesEasy
{
    public class DailyTemperaturesExcercise
    {
        public int[] DailyTemperatures(int[] T)
        {
            var result = new int[T.Length];

            for (int i = 0; i < T.Length - 1; i++)
            {
                int daysForWait = 0;

                for (int j = i + 1; j < T.Length; j++)
                {
                 
                    if (T[i] < T[j])
                    {
                        daysForWait = j - i;
                        break;
                    }

                }
                result[i] = daysForWait;

            }
            return result;
        }
    }
}
