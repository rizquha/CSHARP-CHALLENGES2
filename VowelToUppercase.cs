// ========================================================
// Covert all vowel letters into uppercase
// ========================================================
// Input: rasanya otakku semakin keram
// Expected result
// rAsAnyA OtAkkU sEmAkIn kErAm

using System;
using System.Collections.Generic;
using System.Text;
namespace ChallengeApp
{
    public class VowelToUppercase
    {
        public static string Run(string input)
        {
            var sb = new StringBuilder();
            var lookup = new HashSet<char>(){'a','i','u','e','o'};
            foreach(var x in input) 
            {
                sb.Append(lookup.Contains(x)? char.ToUpper(x):x);
            }
            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}
