using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string low;
            string high;
            int lowNumber;
            int highNumber;
            bool lowTest = false;

            Console.WriteLine("Välkommen till det superkluriga gissa-rätt-nummer-spelet!");
            Console.WriteLine("Först måste du välja vilka nummer du vill gissa imellan.");
            //Chose low number 
            //for (lowTest == false)
            //{
                Console.WriteLine("Lägst nummer: ");
                low = Console.ReadLine();
                lowNumber = Convert.ToInt32(low);
                //bool lowTrue = int.TryParse(lowNumber);
            //}
           //Chose high number
            Console.WriteLine("Högst nummer: ");
            high = Console.ReadLine();
            highNumber = Convert.ToInt32(high);
            

            int randNumber = rand.Next(lowNumber, highNumber);
            string guessText;
            
            

            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan {0} och {1}. " +
                "Kan du gissa vilket? Du får fem försök.", lowNumber, highNumber);

            for (int amountGuess = 0; amountGuess < 5; amountGuess++)
            {
                if (amountGuess <= 6)
                {
                    guessText = Console.ReadLine();
                    int guessNumber = Convert.ToInt32(guessText);

                    if (guessNumber == randNumber)
                    {
                        Console.WriteLine("Woho! Du gjorde det!");
                        amountGuess = amountGuess + 100; //End the amountGuess loop
                    }
                    else if (guessNumber < randNumber)
                    {
                        Console.WriteLine("Tyvärr, du gissade för lågt!");

                    }
                    else if (guessNumber > randNumber)
                    {
                        Console.WriteLine("Tyvärr, du gissade för högt!");

                        //Four IFs, correct, to low, to high or no more guesses 
                    }  
                        if (amountGuess >= 5 && randNumber != guessNumber)
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök");
                    }


                }
                
            }
            Console.WriteLine("Spelet är nu slut!");
        }
    }
}
