namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to get Reverse Number : ");
            int r = Convert.ToInt32(Console.ReadLine());

            ReverseNumber reverse = new ReverseNumber();
            reverse.CalculateReverseNumber(r);
        }
    }
}