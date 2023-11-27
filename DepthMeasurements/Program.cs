using System;
using DepthMeasurements.Services;

namespace DepthMeasurements
{
    public class Program
    {
        static void Main()
        {
            ProcessDepths depths = new();
            Console.WriteLine("Depths greater than previous: "+ depths.DetermineDepths());
            Console.WriteLine("Press any key and Enter");
            Console.ReadLine();
        }
    }
}
