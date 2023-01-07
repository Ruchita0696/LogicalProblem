namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number for how many times to print the statement to get time elapsed for it : ");
            int st = Convert.ToInt32(Console.ReadLine());

            Stopwatchprogram watch = new Stopwatchprogram();
            watch.CalculateStopWatchTime(st);
        }
    }
}