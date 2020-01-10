// ========================================================
// Basic statistics - WITHOUT LINQ
// ========================================================

// int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
//
// FindMax(numbers);
//
// FindMin(numbers);
//
// CalculateAverage(numbers);
//
// CalculateTotal(numbers);

using System;

namespace ChallengeApp
{
    public class BasicStatistic
    {
        public static int FindMax(int[] numbers)
        {

            int Max = numbers[0];
            for(int i=0;i<numbers.Length;i++)
            {
                if(Max<numbers[i])
                {
                    Max = numbers[i];
                }
            }
            Console.WriteLine(Max);
            return Max;
            throw new NotImplementedException();
        }

        public static int FindMin(int[] numbers)
        {
            int Min = numbers[0];
            for(int i =0; i<numbers.Length;i++)
            {
                if(Min>numbers[i])
                {
                    Min = numbers[i];
                }
            }
            Console.WriteLine(Min);
            return Min;
            throw new NotImplementedException();
        }

        public static double CalculateAverage(int[] numbers)
        {
            double sum = CalculateTotal(numbers);
            double average = sum/numbers.Length;
            Console.WriteLine(average);
            return average;
            throw new NotImplementedException();
        }

        public static int CalculateTotal(int[] numbers)
        {
            int sum = 0;
            for (int i= 0; i< numbers.Length; i++)
            {
                sum = sum + numbers[i];  
            }
            Console.WriteLine(sum);
            return sum;
            throw new NotImplementedException();
        }
    }
}
