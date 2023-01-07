using System.Diagnostics;

namespace LogicalProblems
{
    public class Stopwatchprogram
    {
        public void CalculateStopWatchTime(int s)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Hello World");
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : " + stopwatch.Elapsed);
        }
    }
}

