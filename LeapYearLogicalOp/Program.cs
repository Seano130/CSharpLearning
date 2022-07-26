namespace LeapYearLogicalOp
{
    internal class Program
    {
        static void Main()
        {
           
            Console.WriteLine("Enter a year: \n");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + " Falls on a leap year.\n");

            }

            else if (year < 1000 || year > 9999)
            {
                Console.WriteLine("Invalid Entry.\n");

            }

            else
            {
                Console.WriteLine(" is not on a leap year.\n");

            }



        }
    }
}