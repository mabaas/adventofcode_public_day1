using System;

namespace DepthMeasurements.Services
{
    public class CompareDepths : ICompareDepths
    {
        public int Compare(string[]  arr)
        {
            int biggerThanPrevious = 0;
            for (int x = 0; x < arr.Length - 1; x++)
            {
                if (Int32.Parse(arr[x + 1]) > Int32.Parse(arr[x]))
                {
                    biggerThanPrevious++;
                }
            }
            return biggerThanPrevious;
        }
    }
}
