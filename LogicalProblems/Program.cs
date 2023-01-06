namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to Check Number is Perfect or Not : ");
            int n = Convert.ToInt32(Console.ReadLine());

            PerfectNumber perfect = new PerfectNumber();
            perfect.CheckPerfectNumber(n);
        }
    }
}