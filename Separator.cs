// ========================================================
// Letter separators
// ========================================================

// new Separator("minum susu sapi")
// Expected output: m-i-n-u-m-s-u-s-u-s-a-p-i
//
// new Separator("minum susu sapi", '*')
// Expected output: m*i*n*u*m*s*u*s*u*s*a*p*i

using System;
using System.Text;

namespace ChallengeApp
{
    public class Separator
    {
        
        public static string Run(string str, string separator="-")
        {
            
            string delete = str.Replace(" ",String.Empty);
            var sepr = string.Join(separator,delete.ToCharArray());

            foreach(var x in sepr)
            {
                Console.Write(x);
            }
            Console.WriteLine("");
            return sepr;
            throw new NotImplementedException();
        }
    }
}
