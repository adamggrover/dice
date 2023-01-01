//----------- DICE ROLLS -----------------------------------------------------------------//

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {

            // initialise nuber of dice variable

            int iNumOfDice = 0;

            // ask user how many dice they would like to roll

            Console.WriteLine("How many dice would you like to roll?");

            // assign user answer to number of dice variable// See https://aka.ms/new-console-template for more information

            iNumOfDice = Convert.ToInt16(Console.ReadLine()); 

            

            // loop to roll dice and print output for specified number of dice

            for (int i = 0; i < iNumOfDice; i++){

                
            // instantiate Random class
            Random random = new Random();

            // generate a random number
            int iDiceRoll = random.Next(1, 6);

            // print the number of console
            Console.WriteLine(iDiceRoll);
            }

            }




        //create a function for dice roll



    }


}
