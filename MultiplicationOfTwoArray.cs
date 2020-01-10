// ========================================================
// Multiplication of two arrays
// ========================================================

// int[] firstArray = {1, 3, -5, 4};
// int[] secondArray = {1, 4, -5, -2};
//
// MultiplyArray(firstArray, secondArray)
//
// Expected result { 1, 12, 25, -8 }

using System;

namespace ChallengeApp
{
    public class MultiplicationOfTwoArray
    {
        public static int[] Run(params int[] arrays){
        int[] firstArray = {1, 3, -5, 4};
        int[] secondArray = {1, 4, -5, -2};

        int[] multiplication = new int[4];
        for(int i=0; i<firstArray.Length; i++)
        {
            multiplication[i] = firstArray[i]*secondArray[i];
            Console.Write("{0} ",multiplication[i]);
        }
        Console.WriteLine();
        return multiplication;
        } 
    }
}
