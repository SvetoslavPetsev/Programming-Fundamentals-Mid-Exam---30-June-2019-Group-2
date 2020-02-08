using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Giftbox_Coverage
{
    class Program
    {
        static void Main()
        {
            double sideSize = double.Parse(Console.ReadLine());
            int sheetOfPaper = int.Parse(Console.ReadLine());
            double areaOneSheetCover = double.Parse(Console.ReadLine());

            double areaOfBox = sideSize * sideSize * 6;
            double coveredArea = 0;

            for (int i = 1; i <= sheetOfPaper; i++)
            {
                double currCovered = areaOneSheetCover;
                if ( i % 3 ==0)
                {
                    currCovered = areaOneSheetCover * 0.25;
                }

                coveredArea += currCovered;
            }

            double percent = coveredArea / areaOfBox * 100;
            Console.WriteLine($"You can cover {percent:F2}% of the box.");
        }
    }
}
