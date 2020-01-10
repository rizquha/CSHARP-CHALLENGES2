// ========================================================
// Flatting array
// ========================================================

// int[] theFirstArray = {2, 52, 56, 12, 3};
// int[] theSecondArray = {1, 0, 65, 42};
// int[] theThirdArray = {3, 4, 6};
//
// CombineArray(theFirstArray, theSecondArray, theThirdArray)
// Expected result: {0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65};

using System;
using System.Collections;
using System.Collections.Generic;


namespace ChallengeApp
{
    public class FlatArray
    {
        public static int[] Combine(params int[][] arrays)
        {
            int[] theFirstArray = {2, 52, 56, 12, 3};
            int[] theSecondArray = {1, 0, 65, 42};
            int[] theThirdArray = {3, 4, 6};
            var myList = new List<int>();
            myList.AddRange(theFirstArray);
            myList.AddRange(theSecondArray);
            myList.AddRange(theThirdArray);

            int [] array = myList.ToArray();
            Array.Sort(array);
            foreach(int hasil in array)
            {
            Console.Write("{0} ",hasil);
            }
            Console.WriteLine("");

            return array;
            throw new NotImplementedException();
        }
    }
}
