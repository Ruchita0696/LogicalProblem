namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Elements : ");
            int num = Convert.ToInt32(Console.ReadLine());

            FibonacciSeries series = new FibonacciSeries();
            series.CalculateFibonacciSeries();
        }
    }
}