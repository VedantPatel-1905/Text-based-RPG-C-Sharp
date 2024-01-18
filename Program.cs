using System;

namespace TextRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string startGame ="Y";
            bool wantsToPlay = false;
            Game game = new Game();

            // This line initialze the game and display introuduction prologue
            
            game.displayIntroduction();
            int[] life = {10,10,10,1,0,0};

            do
            {
                try
                {
                    Console.Write("Do you want to enter game of adventure (Y/N). Be prepared once you enter there is no turning back: ");
                    startGame = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid character.");
                    continue;
                }
                if (startGame == "Y")
                {
                    wantsToPlay = game.Initialize();    
                }

            } 
            while (startGame!= "Y" && startGame != "N");

            // This is main loop of the game 
            while (life[3] == 1)
            {
                do
                {
                    game.showStatus(life);
                    life = game.toggleQuestion(life);
                    life = game.strengthCheck(life);
                } 
                while (life[0] > 0 && life[3] != 11);

                life = game.displayGameOver(life);
                
            }

            // This displays thankyou message of the game
            game.displayGoodbye(wantsToPlay);
        }
    }
}
