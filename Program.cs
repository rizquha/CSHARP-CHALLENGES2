using System;

namespace ChallengeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
            BasicStatistic.FindMax(numbers); 
            BasicStatistic.FindMin(numbers);
            BasicStatistic.CalculateAverage(numbers);

            int[] theFirstArray = {2, 52, 56, 12, 3};
            int[] theSecondArray = {1, 0, 65, 42};
            int[] theThirdArray = {3, 4, 6};
            FlatArray.Combine(theFirstArray,theSecondArray,theThirdArray);

            HowManyDuplicates.Run();
            MultiplicationOfTwoArray.Run();
            string str = "minum susu sapi";
            Separator.Run(str,"-");
            Separator.Run(str,"*");
            TriangleOfNumbers.Run();
            TriangleStars.Run();
            VowelToUppercase.Run("rasanya otakku semakin keram");
            GenerateCalendar.Run(2020,1);


        }
    }
}
