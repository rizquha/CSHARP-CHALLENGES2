// ========================================================
// Generate triangle
// ========================================================
//
// TriangleStars(5);
//
// Expected result
// *
// **
// ***
// ****
// *****
//
// TriangleStars(2);
//
// Expected result
// *
// **

using System;

namespace ChallengeApp
{
    public class TriangleStars
    {
        public static string Run()
        {
            Console.WriteLine("Anda ingin berapa bintang ?");
            string jumlah = Console.ReadLine();
            int x = Convert.ToInt32(jumlah);
            Console.WriteLine("Hasil Triangle Stars :");
            for(int i = 1 ; i<=x; i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            return jumlah;
            throw new NotImplementedException();
        }
    }
}
