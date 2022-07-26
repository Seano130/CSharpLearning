namespace BasicElseIfSwitchTest;


internal class Program
    {
        static void Main(string[] args)
        {


           

            Console.WriteLine("What is your earth weight?\n");
            double weight = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Here is the list of planets to choose from:\n\n");
            Console.WriteLine(" 1. Mercury 2. Venus 3. Mars\n");
            Console.WriteLine(" 4. Jupiter 5. Saturn 6. Uranus 7. Neptune\n");

            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine ("Your weight on Mercury is: " + weight * 0.38);
                break;

                case 2:
                    Console.WriteLine("Your weight on Venus is: " + weight * 0.91);
                break;

                case 3:
                Console.WriteLine("Your weight on Mars is: " + weight * 0.38);
                break;

                case 4:
                Console.WriteLine("Your weight on Jupiter is: " + weight * 2.34);
                break;

                case 5:
                Console.WriteLine("Your weight on Saturn is: " + weight * 1.06);
                break;

                case 6:
                Console.WriteLine("Your weight on Uranus is: " + weight * 0.92);
                break;

                case 7:
                Console.WriteLine("Your weight on Neptune is: " + weight * 1.19);
                break;

            default:
                   Console.WriteLine(weight);
                break;

            }

        }

    }
