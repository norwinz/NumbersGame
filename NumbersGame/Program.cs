using System;
using System.Threading;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool playAgain = true;
            while (playAgain == true)
            { 
            
            string lowString = "placeholder";
            string highString = "placeholder";
            int lowNumber = 0;
            int highNumber = 0;
            bool lowTest = false;
            bool highTest = false;
            bool toLow = false;
            string guessText;
            bool textSvar = false;
            
            
            
                //Welcome text
                Console.WriteLine("Välkommen till det superkluriga gissa-rätt-nummer-spelet!");
                Console.WriteLine("Först måste du välja vilka nummer du vill gissa imellan.");

                //Chose low number
                while (lowTest == false)
                {
                    Console.WriteLine("Lägst nummer: ");
                    lowString = Console.ReadLine();
                    if (int.TryParse(lowString, out lowNumber))
                    {
                        lowTest = true;
                    }
                    else
                    {
                        Console.WriteLine("Du måste skriva en siffra!");
                    }
                }

                //Chose high number
                while (highTest == false || toLow == false)
                {
                    Console.WriteLine("Högst nummer: ");
                    highString = Console.ReadLine();
                    if (int.TryParse(highString, out highNumber))
                    {
                        highTest = true;
                    }
                    else
                    {
                        Console.WriteLine("Du måste skriva en siffra!");
                    }
                    if (lowNumber < highNumber)
                    {
                        toLow = true;
                    }
                    else
                    {
                        if (highTest == true)
                        {
                            Console.WriteLine("Talet måste vara högre än ditt lägsta tal!");
                        }
                    }
                }

                int randNumber = Randomize(lowNumber, highNumber); //Call method

                //Start of the game
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
                            Console.WriteLine("Tyvärr, du gissade för LÅGT!");
                        }
                        else if (guessNumber > randNumber)
                        {
                            Console.WriteLine("Tyvärr, du gissade för HÖGT!");
                        }
                        if (amountGuess >= 5 && randNumber != guessNumber)
                        {
                            Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök");
                        }


                    }

                }
                Console.WriteLine("Spelet är nu slut!");
                while (textSvar == false)
                {
                    Console.WriteLine("Vill du spela igen? (Ja/Nej)");
                    string igenString = Console.ReadLine().ToUpper();
                    if (igenString == "NEJ")
                    {
                        playAgain = false;
                        textSvar = true;
                    }
                    else if (igenString == "JA")
                    {
                        textSvar = true;
                        Console.Write("Startar ett nytt spel om: ");
                        for(int i=5; i>0; i--)
                        {
                            
                          Console.Write(i);
                           
                            Thread.Sleep(600);
                            Console.Write("\b");
                        }
                        
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Skriv Ja eller Nej");
                    }

                }
            }
            }
            public static int Randomize(int numLow, int numHigh)
            {
                Random rand = new Random();
                numHigh++; //Add one to fix rand.next command
                return rand.Next(numLow, numHigh);

            }
            
        }
    }