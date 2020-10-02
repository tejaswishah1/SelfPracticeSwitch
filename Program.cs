using System;

namespace Practice_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0;
            int costOfCoffee = 0;
       Start: 
            Console.WriteLine("Choose 1 for Small \n Choose 2 for Medium \n Choose 3 for Large");
            userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    costOfCoffee +=10; //// used +=10 instead of =10, because to print finall bill, total will be added
                    break;

                case 2:
                    costOfCoffee+= 20;
                    break;

                case 3:
                    costOfCoffee +=50;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    goto Start;

            }

            Console.WriteLine("Your bill is {0}", costOfCoffee);

            DecideFurther:
            Console.WriteLine("Do you want to continue shopping?");
            Console.WriteLine("Press 1 for yes. Press 2 for No.");

            int userDecision = 0;

            userDecision = Convert.ToInt32(Console.ReadLine());

            switch (userDecision)
            {
                case 1:
                    goto Start;
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    goto DecideFurther;
                    

            }
            Console.WriteLine("Your final bill is {0}", costOfCoffee);
        }  

        }

    internal class Start
    {
    }
}

