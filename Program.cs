//----------- DICE ROLLS -----------------------------------------------------------------//

namespace dice
{
    class Program
    {

          static void StartGame() 
        {
            // initialise dice type variable

            int iNumOfDiceSides = 0;

            //initialise dice rolls equal to one variable

            int iNumOfOnes = 0;

            //initialise number of dice rolls equal to highest side variable

            int iNumOfHighest = 0;

            //initialise dice rolls total variable

            int iDiceRollsTotal = 0;

            // menu for user to choose how many sided dice to roll

            Console.WriteLine("\nWhich type of dice would you like to use?\n");
            Console.WriteLine("Choose an option:\n");
            Console.WriteLine("1. D3");
            Console.WriteLine("2. D4");
            Console.WriteLine("3. D6");
            Console.WriteLine("4. D8");
            Console.WriteLine("5. D10");
            Console.WriteLine("6. D12");
            Console.WriteLine("7. D20");
            Console.WriteLine("8. D100\n");

            // get user to choose which sided dice to use

            int iUserDiceChoice = Convert.ToInt16(Console.ReadLine());

            // print user dice choice to console and assign choice to variable

            switch (iUserDiceChoice) 
            {
                case 1:
                    iNumOfDiceSides = 3;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;

                case 2:
                    iNumOfDiceSides = 4;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;

                case 3:
                    iNumOfDiceSides = 6;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;

                case 4:
                    iNumOfDiceSides = 8;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;

                case 5:
                    iNumOfDiceSides = 10;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;

                case 6:
                    iNumOfDiceSides = 12;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;

                case 7:
                    iNumOfDiceSides = 20;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;

                case 8:
                    iNumOfDiceSides = 100;
                    Console.WriteLine("\nYou have chosen the " + iNumOfDiceSides + " sided dice.");
                    break;
            }

            
            // initialise number of dice rolls variable

            int iNumOfDiceRolls = 0;



            // ask user how many dice they would like to roll

            Console.WriteLine("\nHow many of these dice would you like to roll?\n");
            


            // assign user input to number of dice rolls variable

            iNumOfDiceRolls = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine("\nYou have chosen to roll " + iNumOfDiceRolls + " dice.");


            

            // loop to roll specified dice type the specified number of times and print output to the console

            Console.WriteLine("\nYou have rolled:");

            for (int i = 0; i < iNumOfDiceRolls; i++){

                
                // instantiate Random class
                Random random = new Random();

                // generate a random number
                int iDiceRollResult = random.Next(1, iNumOfDiceSides + 1);

                // if dice roll equals 1 increment number of ones variable

                if (iDiceRollResult == 1){
                    iNumOfOnes++;
                }

                // if dice roll equals 1 the highest possible number available, increment number of highest variable

                if (iDiceRollResult == iNumOfDiceSides){
                    iNumOfHighest++;
                }

                // add dice roll result to variable for running total

                iDiceRollsTotal += iDiceRollResult;

                // print the dice roll result to the console
                Console.WriteLine("\nDice Roll " + (i + 1) + ":");
                Console.WriteLine(iDiceRollResult);
                

            }

            // assign dice roll data to variables

            string sNumOfOnesMsg = ("\nNumber of dice that rolled a one = " + iNumOfOnes);
            string sNumOfHighestMsg = ("Number of dice that their highest possible value = " + iNumOfHighest);
            string sDiceRollsTotalMsg = ("Total value of all dice rolls = " + iDiceRollsTotal);

            Console.WriteLine("\nWhat extra data would you like to know about you dice rolls?");
            Console.WriteLine("\nChoose an option:\n");
            Console.WriteLine("1. Number of dice that rolled a one");
            Console.WriteLine("2. Number of dice that their highest possible value");
            Console.WriteLine("3. Total value of all dice rolls");
            Console.WriteLine("4. All data\n");

            

            int iUserDataChoice = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nExtra Data");

            switch (iUserDataChoice) 
            {
                case 1:
                    
                    Console.WriteLine(sNumOfOnesMsg);
                    break;

                case 2:

                    Console.WriteLine(sNumOfHighestMsg);
                    break;

                case 3:

                    Console.WriteLine(sDiceRollsTotalMsg);
                    break;

                case 4:

                    Console.WriteLine(sNumOfOnesMsg);
                    Console.WriteLine(sNumOfHighestMsg);
                    Console.WriteLine(sDiceRollsTotalMsg);
                    break;
            

            }

            
        }


        static void Main(string[] args)

        {
            bool bPlayAgain = true;

            while (bPlayAgain == true){
                StartGame();
            }
        }
    }
}
