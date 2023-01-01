//----------- DICE ROLLS -----------------------------------------------------------------//

namespace dice
{
    class Program
    {

          static void MainMenu() 
        {
            // initialise dice type variable

            int iNumOfDiceSides = 0;

            // menu for user to choose how many sided dice to roll

            Console.WriteLine("\nWhich type of dice would you like to use?\n");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. D3");
            Console.WriteLine("2. D4");
            Console.WriteLine("3. D6");
            Console.WriteLine("4. D8");
            Console.WriteLine("5. D10");
            Console.WriteLine("6. D12");
            Console.WriteLine("7. D20");
            Console.WriteLine("8. D100\n");

            int iUserDiceChoice = Convert.ToInt16(Console.ReadLine());



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

            Console.WriteLine("\nHow many times would you like to roll?\n");
            


            // assign user answer to number of dice variable

            iNumOfDiceRolls = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine("\nYou have chosen to roll " + iNumOfDiceRolls + " times.");


            

            // loop to roll dice and print output for specified number of dice

            for (int i = 0; i < iNumOfDiceRolls; i++){

                
                // instantiate Random class
                Random random = new Random();

                // generate a random number
                int iDiceRollResult = random.Next(1, iNumOfDiceSides);

                // print the number of console
                Console.WriteLine("\nDice Roll " + (i + 1) + ":");
                Console.WriteLine(iDiceRollResult);
            }

            
        }


        static void Main(string[] args)

        {
            bool bPlayAgain = true;

            while (bPlayAgain == true){
                MainMenu();
            }
        }




      



    }


}
