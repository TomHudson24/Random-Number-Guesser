using System;
using System.Threading;
using System.Text;


namespace Random_Number_Guesser
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //ConsoleKeyInfo input2;
            bool userError = false;


            do
            {

                //************************************************************************************************************
                //Global Variables
                numGen numberGenerator = new numGen();//accessing the number generator
                int lowBand = 1;
                int highBand = 10;

                int num = numberGenerator.randomNumberSelect(lowBand, highBand);

                //************************************************************************************************************

                Console.WriteLine("Welcome to the random number guessing game!\nA random number is being generated, please wait a moment!");
                for (int i = 0; i <= 10; i++)
                {
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("*");
                            break;
                        case 2:
                            Console.WriteLine("**");
                            break;
                        case 3:
                            Console.WriteLine("***");
                            break;
                        case 4:
                            Console.WriteLine("****");
                            break;
                        case 5:
                            Console.WriteLine("*****");
                            break;
                        case 6:
                            Console.WriteLine("******");
                            break;
                        case 7:
                            Console.WriteLine("*******");
                            break;
                        case 8:
                            Console.WriteLine("********");
                            break;
                        case 9:
                            Console.WriteLine("*********");
                            break;
                        case 10:
                            Console.WriteLine("**********");
                            break;
                        default:
                            
                            break;
                    }
                    Thread.Sleep(350);
                }
                

                Console.WriteLine("\nA random number has been generated, can you guess what it is?\n(HINT: It is between {0} & {1})", lowBand, highBand);
                Console.WriteLine("\nType stop to exit.");
                Console.WriteLine("***********************\n"); //can I make this look like a loading bar in a loop and also using thread sleep?


                string input = Console.ReadLine().ToLower();//guessing the number

                switch (input)
                {
                    case "stop":
                        userError = true;
                        Console.WriteLine("Game Over..\n:-(");
                        break;
                    default:
                        int userGuess = 0;
                        try
                        {
                            userGuess = int.Parse(input); //convert the inputted string into a double to be used in the calculation
                        }
                        catch (FormatException)
                        {
                            //do not use the data if you cannot convert it
                            Console.WriteLine("Unable to convert '{0}' to an int.", input);
                            userError = true;
                            return;
                        }
                        if (userGuess > highBand || userGuess < lowBand)
                        {
                            userError = true;
                            Console.WriteLine("Value entered is out of acceptable range");
                            return;
                            
                        }
                        Thread.Sleep(1000);
                        if (userGuess == num)
                        {
                            Console.WriteLine("Correct!\nYou entered {0} and the random number was {1}\n", userGuess, num);
                            Console.WriteLine("\n\nGame Over!\nStarting again..");
                            Thread.Sleep(5000);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect.\nYou entered {0} but the correct random number was {1}\n", userGuess, num);
                            Console.WriteLine("\n\nGame Over!\nStarting again..");
                            Thread.Sleep(5000);
                            Console.Clear();
                        }
                        break;

                        

                }

               


            } while (userError != true);
            
                

                    

            //input2 = Console.ReadKey(false);//checking if escape was pressed to exit programme
            //Console.WriteLine("Would you like to try again?\n************************\nPress Spacebar to try again");

            //input.Key != ConsoleKey.Escape
            //if (input2.Key == ConsoleKey.Spacebar)
            //{

            //}

            //int localOne = numberGenerator.getLowerValue;//checking its default value

            //Console.WriteLine(localOne);//viewing it

            //int five = 5;//new lower value
            //numberGenerator.setLowerValue = five;//setting the lower value
            //int localTwo = numberGenerator.getLowerValue;//assigning it a local variable to be used if necessary

            //Console.WriteLine(localTwo);//viewing it

            // Console.WriteLine(num);
        }
    }

    
}
