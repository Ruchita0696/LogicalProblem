namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number to Check Number is Prime or Not : ");
            int pn = Convert.ToInt32(Console.ReadLine());

            PrimeNumber prime = new PrimeNumber();
            prime.CheckPrimeNumber(pn);
        }
    }
}