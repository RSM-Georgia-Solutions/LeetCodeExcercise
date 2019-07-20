using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeExercise.ExcersiseClasses
{
    public class JewelsandStonesExcercise
    {

        public int NumJewelsInStones(string Jew, string Stone)
        {
            int count = 0;
            for (int i = 0; i < Stone.Length; i++)
            {
                if (Jew.IndexOf(Stone[i]) != -1)
                {
                    count++;
                }
            }
    
            return count;
        }
    }
}


//public class Solution
//{
//    public int NumJewelsInStones(string J, string S)
//    {
//        int count = 0;
//        foreach (char ch in S.ToCharArray())
//        {
//            if (J.Contains(ch))
//            {
//                count++;
//            }
//        }
//        return count;
//    }
//}