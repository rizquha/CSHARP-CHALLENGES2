// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(4);
//
// Expected result
// 1
// 12
// 123
// 1234
//
// TriangleStars(2);
//
// Expected result
// 1
// 12

using System;

namespace ChallengeApp
{
    public class TriangleOfNumbers
    {
        public static string Run()
        {
            Console.WriteLine("Anda ingin berapa angka ?");
            string jumlah = Console.ReadLine();
            int x = Convert.ToInt32(jumlah);
            Console.WriteLine("Hasil Triangle Numbers :");
            for(int i = 1 ; i<=x; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            return jumlah;
            throw new NotImplementedException();
        }
    }
}
