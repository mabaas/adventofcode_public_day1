using System;
using System.IO;
using DepthMeasurements.Services.Interfaces;

namespace DepthMeasurements.Services
{
    public class ProcessDepths : IProcessDepths
    {
        public int DetermineDepths()
        {
            int biggerThanPrevious = 0;
            string depthFile = "depth_measurements.txt";
            CompareDepths depths = new();
            if (File.Exists(depthFile))
            {
                string[] arr = File.ReadAllLines(depthFile);
                biggerThanPrevious = depths.Compare(arr);
            } 
            else
            {
                Console.WriteLine("Could not find the file depth_measurements.txt");
            }
            return biggerThanPrevious;
        }
    }
}
