using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P01BinaryGap
{
    public class BinaryGapHelper
    {
        public int BinaryGap(int number)
        {
            var rxGap = new Regex("(?<=1)(0+)(?=1)");
            var strGap = Convert.ToString(number, 2);
 
            return
                rxGap.Matches(strGap)
                    .Select(m => m.Length)
                    .DefaultIfEmpty(0)
                    .Max();
        }
    }
}
