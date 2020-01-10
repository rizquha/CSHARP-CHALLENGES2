// ========================================================
// How many duplicates
// ========================================================

// int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
//
// Expected result
// 1 -> 3x
// 2 -> 1x
// 3 -> 3x
// 4 -> 2x
// 5 -> 2x

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace ChallengeApp
{
    public class HowManyDuplicates
    {
        public static int[] Run()
        {
            int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
            var dict = new Dictionary<int,int>();
            foreach(int value in dups)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value]=1;
                }
            }
            foreach(var pair in dict.OrderBy(item => item.Key))
            {
                Console.WriteLine("{0}->{1}",pair.Key,pair.Value);
            }
            return dups;
            throw new NotImplementedException();
        }
    }
}
