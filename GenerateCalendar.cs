// ========================================================
// Generate calendar based on current month
// ========================================================
//
// Expected result
//   Januari 2020
//   S    S    R    K    J    S    M
//             1    2    3    4    5
//   6    7    8    9    10   11   12
//   13   14   15   16   17   18   19
//   20   21   22   23   24   25   26
//   27   28   29   30   31

using System;

namespace ChallengeApp
{
    public class GenerateCalendar
    {
        public static string Run(int tahun, int bulan)
        {
            var month = new DateTime(tahun,bulan,1);

            Console.WriteLine($"{month.ToString("MMMM")} {month.Year}");
            string day = $"{month.ToString("MMMM")} {month.Year}";
            Console.WriteLine(new string('-', 20));
            day += new string('-', 20);
            Console.WriteLine("Su Mo Tu We Th Fr Sa");
            day += ("Su Mo Tu We Th Fr Sa");
            
            var padLeftDays = (int)month.DayOfWeek;
            var iterations = DateTime.DaysInMonth(month.Year, month.Month)+padLeftDays;

            for(int i=0; i<iterations;i++)
            {
                if (i<padLeftDays)
                {
                    Console.Write("   ");
                    day +="   ";
                } else
                {
                    Console.Write($"{month.Day.ToString().PadLeft(2, ' ')} ");
                    day += $"{month.Day.ToString().PadLeft(2, ' ')} ";
                    if((i+1)%7==0)
                    {
                        Console.WriteLine();
                        day+="\n";
                    }
                    month = month.AddDays(1);
                }
            }
            Console.WriteLine("\n");
            day+="\n";
            return day;
        }
    }
}
