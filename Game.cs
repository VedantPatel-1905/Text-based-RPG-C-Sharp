using System;

namespace TextRPG
{
    class Game
    {
        private string option;
        private bool wantsToPlay;
        public bool Initialize()
        {
            return true;
        }

        // This function display introduction of the game
        public void displayIntroduction()
        {
            Console.WriteLine("> Almost 500 years ago, a great war between humans and demons took place. The war stretched for over 100 years, after years of blood shed demon king was defeated by the hero.");

            Console.WriteLine("> There was peace and harmony in the land. However, few survivors of last great war have resurrected the demon king, but, he has not gained his full abilities as before.Even if in weakened state, he still dangerous. The only way to defeat the devil easily is the holy sword sealed in the hidden labyrinth of the magic forest.");

            Console.WriteLine("> You have been chosen to be the hero, and you must find the sword and defeat the demon king. Till the time you return with holy knights we will gather the army to support you in the battle.");
            Console.WriteLine("");
            
        }
        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 1 of the game
        private int[] displayQuestion1(int[] life)
        {
            Console.WriteLine("You have entered the magic forest, where monsters are stronger than averages beasts. A horde of wolves are in front of you. What will you do?");
            Console.WriteLine("A) Fight the wolves with magic (-2 MP)");
            Console.WriteLine("B) Barge through the horde");
            Console.WriteLine("C) Take a detour (-2 STR)");

            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[1] -=2;
                    life[4] = 1;
                }
                else if (option == "B")
                {
                    life[0]--;
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[2] -=2 ;
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";
                }
                
            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 2 senario 1 of the game
        private int[] displayQuestion2A(int[] life)
        {
            Console.WriteLine("You defeated the wolves with your fireballs. Now you have reached the entrance to the hidden labyrinth. How will you enter?");

            Console.WriteLine("A) Release your magic power by placing your hand on the door (-1 MP)");
            Console.WriteLine("B) Enter the labyrinth through an unknown passage");
            Console.WriteLine("C) Break open the door with force");

             do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 2;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[1]--;
                    life[4] = 1;
                }
                else if (option == "B")
                {
                    life[0]-= 2;
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[2]-=2;
                    life[0]-=2;
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }
                
            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 2 senario 2 of the game
        private int[] displayQuestion2B(int[] life)
        {
            Console.WriteLine("You were hurt but able to escape the wolves. Now you have reached the entrance to the hidden labyrinth. How will you enter?  ");

            Console.WriteLine("A) Release your magic power by placing your hand on the door (-1 MP)");
            Console.WriteLine("B) Enter the labyrinth through an unknown passage");
            Console.WriteLine("C) Break open the door with force");
             do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 2;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >0)
                {
                    life[1]--;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] <1)
                {
                    Console.WriteLine("You do not have enough magice to cast spell");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[0]-=2;
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[2]-=2;
                    life[0]-=2;
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }
                
            } while (option != "A" && option != "B" && option != "C");

            return life;
        }
        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 2 senario 3 of the game
        private int[] displayQuestion2C(int[] life)
        {
            Console.WriteLine("You had to take a longer route, but you reached the entrance to the hidden labyrinth. How will you enter? Strength = -2");

            Console.WriteLine("A) Release your magic power by placing your hand on the door (-1 MP)");
            Console.WriteLine("B) Enter the labyrinth through an unknown passage");
            Console.WriteLine("C) Break open the door with force");
             do
            {

                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 2;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >0)
                {
                    life[1]--;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] <1)
                {
                    Console.WriteLine("You do not have enough magice to cast spell");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[0]-=2;
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[2]-=2;
                    life[0]-=2;
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }
                
            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 3 senario 1 of the game
        private int[] displayQuestion3A(int[] life)
        {
            Console.WriteLine("The dungeon has accepted you and allowed you to enter. Walking forward, you encounter a few goblins on your path. What choices will you make?");

            Console.WriteLine("A) Attack them using your sword (-2 Str)");
            Console.WriteLine("B) Use magic earth bullet (-1 MP)");
            Console.WriteLine("C) Try to sneak your way in quietly");
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 3;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2]-=2;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] > 0)
                {
                    life[1]--;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to cast a spell.");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[2] -= 2;
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                    option = "N";
                }
            } 
            while (option != "A" && option != "B" && option != "C");
            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 3 senario 2 of the game
        private int[] displayQuestion3B(int[] life)
        {
            Console.WriteLine("The passage had traps, and you were injured by them, but you were able to enter the dungeon. Walking forward, you encounter a few goblins on your path. What choices will you make? (Health: -2)");

            Console.WriteLine("A) Attack them using your sword (-2 Str)");
            Console.WriteLine("B) Use magic earth bullet (-1 MP)");
            Console.WriteLine("C) Try to sneak your way in quietly");
             do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 3;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[2]-=2;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >0)
                {
                    life[1]--;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] <1)
                {
                    Console.WriteLine("You do not have enough magice to cast spell");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[2]-=2;
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }
                
            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 3 senario 3 of the game
        private int[] displayQuestion3C(int[] life)
        {
            Console.WriteLine("You broke open the entrance and entered. Although, it angered the dungeon and hit by a magic attack. Walking forward, you encounter a few goblins on your path. What choices will you make? (Strength: -2) ");
            Console.WriteLine("A) Attack them using your sword (-2 Str)");
            Console.WriteLine("B) Use magic earth bullet (-1 MP)");
            Console.WriteLine("C) Try to sneak your way in quietly");
             do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 3;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2]-=2;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >0)
                {
                    life[1]--;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] <1)
                {
                    Console.WriteLine("You do not have enough magice to cast spell");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[2]-=2;
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }
                
            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 4 senario 1 of the game
        private int[] displayQuestion4A(int[] life)
        {
            Console.WriteLine("You bravely attacked the goblins and slashed them down, but one goblin managed to hit you. Moving forward in a dark passage, you hear some strange sound and see shiny pearls moving around. What will you do? ");

            Console.WriteLine("A) Lit the torch and move forward");
            Console.WriteLine("B) Go in dark by hiding your presence");
            Console.WriteLine("C) Throw a fireball in that direction (-1 MP)");

            life[0]--;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 4;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[0]-=2;
                    life[4] = 1;
                }
                else if (option == "B")
                {
                    life[3]--;
                    life[4] = 2;
                }
                else if (option == "C" && life[1] >0)
                {
                    life[1]--;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] <1)
                {
                    Console.WriteLine("You do not have enough magice to cast spell");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }       

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 4 senario 2 of the game
        private int[] displayQuestion4B(int[] life)
        {
            Console.WriteLine("You shot down all the goblins in one swoop. Moving forward in a dark passage, you hear some strange sound and see shiny pearls moving around. What will you do? (Magic: -1)");

            Console.WriteLine("A) Lit the torch and move forward");
            Console.WriteLine("B) Go in dark by hiding your presence");
            Console.WriteLine("C) Throw a fireball in that direction (-1 MP)");

            life[3] = 4;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[0]-=2;
                    life[4] = 1;
                }
                else if (option == "B")
                {
                    life[3]--;
                    life[4] = 2;
                }
                else if (option == "C" && life[1] > 0)
                {
                    life[1]--;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to cast a spell");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                    }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 4 senario 3 of the game
        private int[] displayQuestion4C(int[] life)
        {
            Console.WriteLine("A Goblin noticed you while you were sneaking away and attacked you. How will you fight back? ");

            Console.WriteLine("A) Attack them using your sword (-1 Str)");
            Console.WriteLine("B) Use magic earth bullet (-1 MP)");

            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    life[3] = 4;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[2]--;
                    life[4] = 14;
                }
                else if (option == "B" && life[1] > 0)
                {
                    life[1]--;
                    life[4] = 15;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to cast a spell");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }

            } while (option != "A" && option != "B");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 5 senario 1 of the game
        private int[] displayQuestion5A(int[] life)
        {
            Console.WriteLine("You saw some fireflies in front of a chamber. Inside, you noticed a girl sealed in with magic, calling out for help, but the other doorway was closing slowly. What will you do?");

            Console.WriteLine("A) Free the girl by breaking the seal using magic (-2 MP)");
            Console.WriteLine("B) Try to stop the door from closing and then help her (-3 Str)");
            Console.WriteLine("C) Tell her to wait and move to the other door");
            do
            {
                life[3] = 5;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to break the seal");
                    option= "N";
                }
                else if (option == "B" )
                {
                    life[2] -= 3;
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 5 senario 2 of the game
        private int[] displayQuestion5B(int[] life)
        {
            Console.WriteLine("You tripped and fell, hurting your head, but you managed to reach a chamber. Inside, you noticed a girl sealed in with magic, calling out for help, but the other doorway was closing slowly. What will you do? ");

            Console.WriteLine("A) Free the girl by breaking the seal using magic (-2 MP)");
            Console.WriteLine("B) Try to stop the door from closing and then help her (-3 Str)");
            Console.WriteLine("C) Tell her to wait and move to the other door");

            do
            {
                life[3] = 5;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to break the seal");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[2] -= 3;
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 5 senario 3 of the game
        private int[] displayQuestion5C(int[] life)
        {
            Console.WriteLine("You burned down veins and fireflies in front of a chamber. Inside, you noticed a girl sealed in with magic, calling out for help, but the other doorway was closing slowly. What will you do? (Magic: -1)");

            Console.WriteLine("A) Free the girl by breaking the seal using magic (-2 MP)");
            Console.WriteLine("B) Try to stop the door from closing and then help her (-2 Str)");
            Console.WriteLine("C) Tell her to wait and move to the other door");

            do
            {
                life[3] = 5;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to break the seal");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[2] -= 2;
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 6 senario 1 of the game
        private int[] displayQuestion6A(int[] life)
        {
            Console.WriteLine("What a heroic person you are. After saving the girl, she gifted you divine blessings that enhance magic, strength, and health. She offers to lead you to the holy sword. Which choice will you make? (Magic: -2)");

            Console.WriteLine("A) Accept her offer and follow her");
            Console.WriteLine("B) Reject her offer and move forward");
            Console.WriteLine("C) Show her the way out of the labyrinth and move ahead");
            do
            {
                life[3] = 6;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[0]+=1;
                    life[1]+=1;
                    life[2]+=1;
                    life[4] = 1;
                    life[5] = 1;
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 6 senario 2 of the game
        private int[] displayQuestion6B(int[] life)
        {
            Console.WriteLine("You were unable to stop the door from closing. Few seconds till the door shuts, you only have two options now. What will you choose? (Strength: -2)");

            Console.WriteLine("A) Free the girl by breaking the seal using magic (-2 MP)");
            Console.WriteLine("B) Tell her to wait and move to the other door");

            life[2]-=2;
            do
            {
                life[3] = 6;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 14;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to break the seal");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 15;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }

            } while (option != "A" && option != "B");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 6 senario 3 of the game
        private int[] displayQuestion6C(int[] life)
        {
            Console.WriteLine("Leaving the maiden behind, you move forward. You found some vicious orcs on your way. They are as tall as trees and strong as boulders. What will you do?");

            Console.WriteLine("A) Use illusion magic to hide yourself and move forward (-1 MP)");
            Console.WriteLine("B) Use Lightning magic to paralyze them (-2 MP)");
            Console.WriteLine("C) Pick up your sword and fight them with your might");

            do
            {
                life[3] = 6;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 7;
                }
                else if (option == "A" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use illusion magic");
                    option= "N";
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 8;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use lightning magic");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[4] = 9;
                }
                else
                {
                    Console.WriteLine("Enter a valid input ");
                    option = "N";                
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 1 senario 1 of the game
        private int[] displayQuestion7_1_6A_A(int[] life)
        {
            Console.WriteLine("On your path, you encounter gyests, creatures made up of magic. You must defeat them to move forward. How will you attack?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Attack them using your sword");
            Console.WriteLine("C) Use light magic to blind them (-1 MP)");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use fire splash");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use light magic");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 1 senario 2 of the game
        private int[] displayQuestion7_1_6A_B(int[] life)
        {
            Console.WriteLine("You hide the girl in a safe place and move forward. On your path, you encounter gyests, creatures made up of magic. You must defeat them to move forward. How will you attack?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Attack them using your sword");
            Console.WriteLine("C) Use light magic to blind them (-1 MP)");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use fire splash");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use light magic");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 1 senario 3 of the game
        private int[] displayQuestion7_1_6A_C(int[] life)
        {
            Console.WriteLine("The girl refused to leave the labyrinth without you, so you hide the girl in a safe place and move forward. On your path, you encounter gyests, creatures made up of magic. You must defeat them to move forward. How will you attack?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Attack them using your sword");
            Console.WriteLine("C) Use light magic to blind them (-1 MP)");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use fire splash");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use light magic");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }
        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 2 senario 1 of the game
        private int[] displayQuestion7_1A(int[] life)
        {
            Console.WriteLine("On your path, you encounter gyests, creatures made up of magic. You must defeat them to move forward. How will you attack?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Attack them using your sword");
            Console.WriteLine("C) Use light magic to blind them (-1 MP)");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 4;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use fire splash");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 5;
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 6;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use light magic");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 2 senario 2 of the game
        private int[] displayQuestion7_1B(int[] life)
        {
            Console.WriteLine("You hide the girl in a safe place and move forward. On your path, you encounter gyests, creatures made up of magic. You must defeat them to move forward. How will you attack?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Attack them using your sword");
            Console.WriteLine("C) Use light magic to blind them (-1 MP)");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 4;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use fire splash");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 5;
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 6;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use light magic");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 2 senario 3 of the game
        private int[] displayQuestion7_1C(int[] life)
        {
            Console.WriteLine("The girl refused to leave the labyrinth without you, so you hide the girl in a safe place and move forward. On your path, you encounter gyests, creatures made up of magic. You must defeat them to move forward. How will you attack?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Attack them using your sword");
            Console.WriteLine("C) Use light magic to blind them (-1 MP)");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 4;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use fire splash");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 5;
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 6;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use light magic");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 3 senario 1 of the game
        private int[] displayQuestion7_2A(int[] life)
        {
            Console.WriteLine("You were able to fool orcs and move forward without a fight. Orcs are strong but not good with their sense. You reached the place where the sword is sealed. What choice will you make?");

            Console.WriteLine("A) Go into the chamber");
            Console.WriteLine("B) Use detection magic to search the place (-1 MP)");
            Console.WriteLine("C) Look around for clues and traps");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[4] = 7;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 8;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use detection magic");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[4] = 9;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 3 senario 2 of the game
        private int[] displayQuestion7_2B(int[] life)
        {
            Console.WriteLine("You stunned the orcs with lightning and move forward. You reached the place where the sword is sealed. What choice will you make?");

            Console.WriteLine("A) Go into the chamber");
            Console.WriteLine("B) Use detection magic to search the place (-1 MP)");
            Console.WriteLine("C) Look around for clues and traps");

            do
            {
                life[3] = 7;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[4] = 7;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 8;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use detection magic");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[4] = 9;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 7 case 3 senario 3 of the game
        private int[] displayQuestion7_2C(int[] life)
        {
            Console.WriteLine("An orc smashed you with a hammer. Orcs are strong creatures with skin as hard as a wall. You cannot defeat them with your sword alone. Which magic will you use?");

            Console.WriteLine("A) Use earth bullet (-1 MP)");
            Console.WriteLine("B) Use Lightning Bolt (-2 MP)");

            do
            {
                life[3] = 6;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[2] >= 2)
                {
                    life[2] -= 2;
                    life[4] = 7;
                }
                else if (option == "A" && life[2] < 2)
                {
                    Console.WriteLine("You do not have enough strength to use earth bullet");
                    option= "N";
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 8;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use Lightning Bolt");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 1 senario 1 of the game
        private int[] displayQuestion8_1_6A_A(int[] life)
        {
            Console.WriteLine("You vaporized the gyests into thin air using your fire magic. You see two pathways in front of you, but with the help of the maiden, you were able to find the correct path. However, you encounter a swamp of weak slimes. What will you do?");

            Console.WriteLine("A) Slash down the slime with your sword");
            Console.WriteLine("B) Use your water blade to cut down the slimes (-1 MP)");
            Console.WriteLine("C) Barge straight ahead with full speed");
            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1] -= 2;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use Water blade");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 1 senario 2 of the game
        private int[] displayQuestion8_1_6A_B(int[] life)
        {
            Console.WriteLine("Gyests are creatures made up of magic, physical attacks don’t work on them. Which magic will you use on them?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Use light magic to blind them (-1 str)");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    Console.WriteLine("You didn't have enough magic so you conver your life essence to magic power");
                    life[0]-=2;
                    life[4] = 1;
                }
                else if (option == "B")
                {
                    Console.WriteLine("You didn't have enough magic so you conver your life essence to magic power");
                    life[0] -= 1;
                    life[4] = 2;
                }
                else
                {
                    Console.WriteLine("Enter a valid input (A or.");
                }

            } while (option != "A" && option != "B");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 1 senario 3 of the game
        private int[] displayQuestion8_1_6A_C(int[] life)
        {
            Console.WriteLine("You temporarily blinded the gyests and were able to move on. You see two pathways in front of you, but with the help of the maiden, you were able to find the correct path. However, you encounter a swamp of weak slimes. What will you do?");

            Console.WriteLine("A) Slash down the slime with your sword");
            Console.WriteLine("B) Use your water blade to cut down the slimes (-1 MP)");
            Console.WriteLine("C) Barge straight ahead with full speed");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to use Water blade");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }


        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 2 senario 1 of the game
        private int[] displayQuestion8_1A(int[] life)
        {
            Console.WriteLine("You vaporized the gyests into thin air using your fire magic. You see two pathways, one with a dark path and some noise and the other a clear path. Which path will you take?");

            Console.WriteLine("A) Go toward the dark creepy path");
            Console.WriteLine("B) Go toward the clear path");
            Console.WriteLine("C) Use telepathy to ask for the maiden's help (-2 MP)");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[4] = 4;
                }
                else if (option == "B")
                {
                    life[4] = 5;
                }
                else if (option == "C" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 6;
                }
                else if (option == "C" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use telepathy");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 2 senario 2 of the game
        private int[] displayQuestion8_1B(int[] life)
        {
            Console.WriteLine("Gyests are creatures made up of magic, physical attacks don't work on them. Which magic will you use on them?");

            Console.WriteLine("A) Use fire splash on the gyests (-2 MP)");
            Console.WriteLine("B) Use light magic to blind them (-1 MP)");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A" && life[1] >=2)
                {
                    life[1]-=2;
                    life[4] = 4;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You didn't have enough magic so you conver your life essence to magic power");
                    life[0]-=2;
                    life[4] = 4;
                }
                else if (option == "B" && life[1] < 2)
                {
                    life[1] -= 1;
                    life[4] = 5;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You didn't have enough magic so you conver your life essence to magic power");
                    life[0] -= 1;
                    life[4] = 5;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 2 senario 3 of the game
        private int[] displayQuestion8_1C(int[] life)
        {
            Console.WriteLine("You temporarily blinded the gyests and were able to move on. You see two pathways, one with a dark path and some noise, and the other a clear path. Which path will you take?");

            Console.WriteLine("A) Go toward the dark creepy path");
            Console.WriteLine("B) Go toward the clear path");
            Console.WriteLine("C) Use telepathy to ask for the maiden's help (-2 MP)");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;                
                }
                if (option == "A")
                {
                    life[4] = 4;
                }
                else if (option == "B")
                {
                    life[4] = 5;
                }
                else if (option == "C" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 6;
                }
                else if (option == "C" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to use telepathy");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 3 senario 1 of the game
        private int[] displayQuestion8_2A(int[] life)
        {
            Console.WriteLine("As soon as you stepped into the chamber, you set off some traps and hurt yourself, but you reached the sword. Now you must break the seal. How will you do it?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-1 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-1 MP)");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[2] -= 2;
                    life[4] = 7;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 8;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[2]--;
                    life[4] = 9;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 3 senario 1 of the game
        private int[] displayQuestion8_2B(int[] life)
        {
            Console.WriteLine("You were able to find some traps and disabled them, and you reached the sword. Now you must break the seal. How will you do it?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-1 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-1 MP)");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[4] = 7;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 8;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[1]--;
                    life[4] = 9;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to enchant");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 8 case 3 senario 3 of the game
        private int[] displayQuestion8_2C(int[] life)
        {
            Console.WriteLine("You look around and found some traps, so you disabled them, but it took so much time and stamina. However, you reached the sword. Now you must break the seal. How will you do it?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-1 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-1 MP)");

            do
            {
                life[3] = 8;
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }
                if (option == "A")
                {
                    life[2] -= 2;
                    life[4] = 7;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1]--;
                    life[4] = 8;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[1]--;
                    life[4] = 9;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 1 senario 1 of the game
        private int[] displayQuestion9_1_6A_A(int[] life)
        {
            Console.WriteLine("You were able to slash the slime down, but the gooey fluid from the slime had weak toxin. Now you have reached the place where the sword was sealed. What choice will you make?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-1 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-1 MP)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2] -= 1;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option = "N";
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic for enchantment");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 1 senario 2 of the game
        private int[] displayQuestion9_1_6A_B(int[] life)
        {
            Console.WriteLine("You were able to slash the slime down, without contacting the gooey fluid from the slime which had weak toxin. Now you have reached the place where the sword was sealed. What choice will you make?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-1 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-1 MP)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2] -= 1;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic for enchantment");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 1 senario 3 of the game
        private int[] displayQuestion9_1_6A_C(int[] life)
        {
            Console.WriteLine("Holy maiden used protection spell, and you avoided the gooey fluid from the slime which had weak toxin. Now you have reached the place where the sword was sealed. What choice will you make?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-1 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-2 MP)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2] -= 1;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                    option = "N";
                }
                else if (option == "C" && life[1] >= 1)
                {
                    life[1] -= 1;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 1)
                {
                    Console.WriteLine("You do not have enough magic for enchantment");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 2 senario 1 of the game
        private int[] displayQuestion9_1_A(int[] life)
        {
            Console.WriteLine("The path was creepy and dark, but it led to the place where the holy sword was sealed. What choice will you make?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-2 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-2 MP)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2] -= 1;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                }
                else if (option == "C" && life[1] >= 2)
                {
                    life[2] -= 2;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic for enchantment");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 2 senario 2 of the game
        private int[] displayQuestion9_1_B(int[] life)
        {
            Console.WriteLine("The path was clear, but it was a longer and more tiresome path which led you to the place where the holy sword was sealed. What choice will you make? (Strength: -2)");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-2 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-2 MP)");

            life[3] = 9;
            life[2]--;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2] -= 1;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                }
                else if (option == "C" && life[1] >= 2)
                {
                    life[2] -= 2;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic for enchantment");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }


        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 2 senario 3 of the game
        private int[] displayQuestion9_1_C(int[] life)
        {
            Console.WriteLine("Holy maiden guided you to the correct path. Now, you have reached the place where the holy sword is sealed. What will you do?");

            Console.WriteLine("A) Pull the sword out with force");
            Console.WriteLine("B) Pass some of the magic into the sword (-2 MP)");
            Console.WriteLine("C) Spell some enchantment of unsealing (-2 MP)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[2] -= 1;
                    life[4] = 1;
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 2;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic to pass into the sword");
                    option= "N";
                }
                else if (option == "C" && life[1] >= 2)
                {
                    life[2] -= 2;
                    life[4] = 3;
                }
                else if (option == "C" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic for enchantment");
                    option= "N";
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 3 senario 1 of the game
        private int[] displayQuestion9_2_A(int[] life)
        {
            Console.WriteLine("Sword was hard to pull out. You hear a voice in your head tell you to get divine blessing from a holy maiden. Suddenly, the girl trapped in the seal appeared, and she is the real guardian of the sword. She offers divine blessing, but you must choose one of the penalties.");

            Console.WriteLine("A) Lose 1 health point (-1 HP)");
            Console.WriteLine("B) Lose 2 magic points (-2 MP)");
            Console.WriteLine("C) Lose 3 strength points (-3 Str)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[0] -= 1;
                    life[4] = 4;
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 5;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to lose");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[2] -= 3;
                    life[4] = 6;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 3 senario 2 of the game
        private int[] displayQuestion9_2_B(int[] life)
        {
            Console.WriteLine("Sword rejected you. You hear a voice in your head tell you to get divine blessing from a holy maiden. Suddenly, the girl trapped in the seal appeared, and she is the real guardian of the sword. She offers divine blessing, but you must choose one of the penalties. (Magic: -1)");

            Console.WriteLine("A) Lose 1 health point (-1 HP)");
            Console.WriteLine("B) Lose 2 magic points (-2 MP)");
            Console.WriteLine("C) Lose 3 strength points (-3 Str)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[0] -= 1;
                    life[4] = 4;
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 5;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to lose");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[2] -= 3;
                    life[4] = 6;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 9 case 3 senario 3 of the game
        private int[] displayQuestion9_2_C(int[] life)
        {
            Console.WriteLine("You found that there was no seal, and you hear a voice in your head tell you to get divine blessing from a holy maiden. Suddenly, the girl trapped in the seal appeared, and she is the real guardian of the sword. She offers divine blessing, but you must choose one of the penalties. (Magic: -1)");

            Console.WriteLine("A) Lose 1 health point (-1 HP)");
            Console.WriteLine("B) Lose 2 magic points (-2 MP)");
            Console.WriteLine("C) Lose 3 strength points (-3 Str)");

            life[3] = 9;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A")
                {
                    life[0] -= 1;
                    life[4] = 4;
                }
                else if (option == "B" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 5;
                }
                else if (option == "B" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to lose");
                    option= "N";
                }
                else if (option == "C")
                {
                    life[2] -= 3;
                    life[4] = 6;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 10 case 1&2 senario 1 of the game
        private int[] displayQuestion10_1_6A_A(int[] life)
        {
            Console.WriteLine("You pull out the sword with ease due to divine blessing from the holy maiden. Suddenly, you hear the maiden's voice and she tells you that you passed the trial, and then she suddenly disappeared. The dungeon is crumbling. How will you escape?");

            Console.WriteLine("A) Use Teleportation scroll to get out (-2 MP)");
            Console.WriteLine("B) Look around to find an exit");
            Console.WriteLine("C) Call out to the maiden for help");

            life[3] = 10;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to use the Teleportation scroll");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 10 case 1&2 senario 2 of the game
        private int[] displayQuestion10_1_6A_B(int[] life)
        {
            Console.WriteLine("You had divine blessing from the holy maiden, so the sword accepted you. Suddenly, you hear the maiden's voice and she tells you that you passed the trial, and then she suddenly disappeared. The dungeon is crumbling. How will you escape? (Magic: -1)");

            Console.WriteLine("A) Use Teleportation scroll to get out (-2 MP)");
            Console.WriteLine("B) Look around to find an exit");
            Console.WriteLine("C) Call out to the maiden for help");

            life[3] = 10;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to use the Teleportation scroll");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 10 case 1&2 senario 3 of the game
        private int[] displayQuestion10_1_6A_C(int[] life)
        {
            Console.WriteLine("There was no need for a spell as you had divine blessing, and you were able to get the sword. Suddenly, you hear the maiden's voice and she tells you that you passed the trial, and then she suddenly disappeared. The dungeon is crumbling. How will you escape? (Magic: -2)");

            Console.WriteLine("A) Use Teleportation scroll to get out (-2 MP)");
            Console.WriteLine("B) Look around to find an exit");
            Console.WriteLine("C) Call out to the maiden for help");

            life[3] = 10;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to use the Teleportation scroll");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 10 case 3 senario 1 of the game
        private int[] displayQuestion10_2_A(int[] life)
        {
            Console.WriteLine("After losing your health points, you were able to acquire the holy sword. Suddenly, you hear the maiden's voice and she tells you that you passed the trial, and then she suddenly disappeared. The dungeon is crumbling. How will you escape? ");

            Console.WriteLine("A) Use Teleportation scroll to get out (-2 MP)");
            Console.WriteLine("B) Look around to find an exit");
            Console.WriteLine("C) Call out to the maiden for help");

            life[3] = 10;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to use the Teleportation scroll");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 10 case 3 senario 2 of the game
        private int[] displayQuestion10_2_B(int[] life)
        {
            Console.WriteLine("After losing your magic points, you were able to acquire the holy sword. Suddenly, you hear the maiden's voice and she tells you that you passed the trial, and then she suddenly disappeared. The dungeon is crumbling. How will you escape? (Magic: -2)");

            Console.WriteLine("A) Use Teleportation scroll to get out (-2 MP)");
            Console.WriteLine("B) Look around to find an exit");
            Console.WriteLine("C) Call out to the maiden for help");

            life[3] = 10;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to use the Teleportation scroll");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // life[0] = health, life[1] = magic and life[2] = strength
        // This function display level 10 case 3 senario 3 of the game
        private int[] displayQuestion10_2_C(int[] life)
        {
            Console.WriteLine("After losing your strength points, you were able to acquire the holy sword. Suddenly, you hear the maiden's voice and she tells you that you passed the trial, and then she suddenly disappeared. The dungeon is crumbling. How will you escape? (Strength: -3)");

            Console.WriteLine("A) Use Teleportation scroll to get out (-2 MP)");
            Console.WriteLine("B) Look around to find an exit");
            Console.WriteLine("C) Call out to the maiden for help");

            life[3] = 10;
            do
            {
                try
                {
                    Console.Write("Enter your Choice (A) (B) or (C): ");
                    option = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid character.");
                    continue;
                }

                if (option == "A" && life[1] >= 2)
                {
                    life[1] -= 2;
                    life[4] = 1;
                }
                else if (option == "A" && life[1] < 2)
                {
                    Console.WriteLine("You do not have enough magic points to use the Teleportation scroll");
                    option= "N";
                }
                else if (option == "B")
                {
                    life[4] = 2;
                }
                else if (option == "C")
                {
                    life[4] = 3;
                }
                else
                {
                    Console.WriteLine("Enter a valid input");
                    option = "N";
                }

            } while (option != "A" && option != "B" && option != "C");

            return life;
        }

        // This function display final level case 1 senario 1 of the game
        private int[] displayQuestion11_1_A(int[] life)
        {
            Console.WriteLine("You managed to escape using your teleportation artifact. Now you move towards your final battle.");

            life[3] = 11;
            life[4] = 1;
            return life;
        }

        // This function display final level case 1 senario 2 of the game
        private int[] displayQuestion11_1_B(int[] life)
        {
            Console.WriteLine("You found an exit, but it had a defensive array set up which injured you while going out.");
        
            life[3] = 11;        
            life[4] = 2;
            return life;
        }

        // This function display final level case 1 senario 3 of the game
        private int[] displayQuestion11_1_C(int[] life)
        {
            Console.WriteLine("For your help, the maiden uses her last magic to bring you out of this place.");

            life[3] = 11;        
            life[4] = 3;
            return life;
        }
        // This function display final level case 1 senario 1 of the game
        private int[] displayQuestion11_2_A(int[] life)
        {
            Console.WriteLine("You managed to escape using your teleportation artifact. Now you move towards your final battle.");

            life[3] = 11;
            life[4] = 4;
            return life;
        }

        // This function display final level case 1 senario 2 of the game
        private int[] displayQuestion11_2_B(int[] life)
        {
            Console.WriteLine("You found an exit, but it had a defensive array set up which injured you while going out.");
        
            life[3] = 11;        
            life[4] = 5;
            return life;
        }

        // This function display final level case 1 senario 3 of the game
        private int[] displayQuestion11_2_C(int[] life)
        {
            Console.WriteLine("You sought the help of maiden, but she was long gone. Then you managed to find an exit but got hurt in process.");

            life[3] = 11;        
            life[4] = 6;
            return life;
        }

        // This function displays different questions according to players choice 
        public int[] toggleQuestion(int[] arr)
        {
            //level 1 questions
            if (arr[0] != 0 && arr[3] == 1 && arr[4]== 0)
            {
                return displayQuestion1(arr);
            }

            //level 2 questions
            else if (arr[0] != 0 && arr[3] == 1 && arr[4]== 1)
            {
                return displayQuestion2A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 1 && arr[4]== 2)
            {
                return displayQuestion2B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 1 && arr[4]== 3)
            {
                return displayQuestion2C(arr);
            }

            //level 3 questions
            else if (arr[0] != 0 && arr[3] == 2 && arr[4]== 1)
            {
                return displayQuestion3A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 2 && arr[4]== 2)
            {
                return displayQuestion3B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 2 && arr[4]== 3)
            {
                return displayQuestion3C(arr);
            }

            //level 4 questions
            else if (arr[0] != 0 && arr[3] == 3 && arr[4]== 1)
            {
                return displayQuestion4A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 3 && arr[4]== 2)
            {
                return displayQuestion4B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 3 && arr[4]== 3)
            {
                return displayQuestion4C(arr);
            }

            // if option c is chosen return back to option a or b
            else if (arr[0] != 0 && arr[3] == 4 && arr[4]== 14)
            {
                return displayQuestion4A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 4 && arr[4]== 15)
            {
                return displayQuestion4B(arr);
            }

            //level 5 questions
            else if (arr[0] != 0 && arr[3] == 4 && arr[4]== 1)
            {
                return displayQuestion5A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 4 && arr[4]== 2)
            {
                return displayQuestion5B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 4 && arr[4]== 3)
            {
                return displayQuestion5C(arr);
            }

            //level 6 questions
            else if (arr[0] != 0 && arr[3] == 5 && arr[4]== 1)
            {
                return displayQuestion6A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 5 && arr[4]== 2)
            {
                return displayQuestion6B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 5 && arr[4]== 3)
            {
                return displayQuestion6C(arr);
            }

            // if option b is chosen return back to option a or c
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 14)
            {
                return displayQuestion6A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 15)
            {
                return displayQuestion6C(arr);
            }
            

            //level 7 questions
            // senario 1
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 1 && arr[5] == 1)
            {
                return displayQuestion7_1_6A_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 2 && arr[5] == 1)
            {
                return displayQuestion7_1_6A_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 3 && arr[5] == 1)
            {
                return displayQuestion7_1_6A_C(arr);
            }

            // senario 2
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 1 && arr[5] == 0)
            {
                return displayQuestion7_1A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 2 && arr[5] == 0)
            {
                return displayQuestion7_1B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 3 && arr[5] == 0)
            {
                return displayQuestion7_1C(arr);
            }

            // senario 2
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 7)
            {
                return displayQuestion7_2A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 8)
            {
                return displayQuestion7_2B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 6 && arr[4]== 9)
            {
                return displayQuestion7_2C(arr);
            }

            //level 8 questions
            // senario 1
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 1)
            {
                return displayQuestion8_1_6A_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 2)
            {
                return displayQuestion8_1_6A_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 3)
            {
                return displayQuestion8_1_6A_C(arr);
            }

            // senario 2
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 4)
            {
                return displayQuestion8_1A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 5)
            {
                return displayQuestion8_1B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 6)
            {
                return displayQuestion8_1C(arr);
            }

            // senario 3
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 7)
            {
                return displayQuestion8_2A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 8)
            {
                return displayQuestion8_2B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 7 && arr[4]== 9)
            {
                return displayQuestion8_2C(arr);
            }

            // level 9
            // senario 1
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 1)
            {
                return displayQuestion9_1_6A_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 2)
            {
                return displayQuestion9_1_6A_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 3)
            {
                return displayQuestion9_1_6A_C(arr);
            }

            // senario 2
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 4)
            {
                return displayQuestion9_1_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 5)
            {
                return displayQuestion9_1_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 6)
            {
                return displayQuestion9_1_C(arr);
            }

            // senario 3
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 7)
            {
                return displayQuestion9_2_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 8)
            {
                return displayQuestion9_2_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 8 && arr[4]== 9)
            {
                return displayQuestion9_2_C(arr);
            }

            // level 10
            // senario 1 & 2
            else if (arr[0] != 0 && arr[3] == 9 && arr[4]== 1)
            {
                return displayQuestion10_1_6A_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 9 && arr[4]== 2)
            {
                return displayQuestion10_1_6A_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 9 && arr[4]== 3)
            {
                return displayQuestion10_1_6A_C(arr);
            }

            // senario 3
            else if (arr[0] != 0 && arr[3] == 9 && arr[4]== 4)
            {
                return displayQuestion10_2_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 9 && arr[4]== 5)
            {
                return displayQuestion10_2_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 9 && arr[4]== 6)
            {
                return displayQuestion10_2_C(arr);
            }

            // level 11 final
            // senario 1 
            else if (arr[0] != 0 && arr[3] == 10 && arr[4]== 1)
            {
                return displayQuestion11_1_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 10 && arr[4]== 2)
            {
                return displayQuestion11_1_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 10 && arr[4]== 3)
            {
                return displayQuestion11_1_C(arr);
            }

            // senario 3
            else if (arr[0] != 0 && arr[3] == 10 && arr[4]== 4)
            {
                return displayQuestion11_2_A(arr);
            }
            else if (arr[0] != 0 && arr[3] == 10 && arr[4]== 5)
            {
                return displayQuestion11_2_B(arr);
            }
            else if (arr[0] != 0 && arr[3] == 10 && arr[4]== 6)
            {
                return displayQuestion11_2_C(arr);
            }
            else 
            {
                return arr;
            }
            
        }

        // This function displays game over when player loses all their HP
        public int[] displayGameOver(int[] life)
        {
            string startGame = "S";
            if(life[0] <= 0)
            {
                Console.WriteLine("Game over!");
            }
            do
            {
            try
                {
                    Console.Write("Do you play again (Y/N): ");
                    startGame = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid character.");
                    continue;
                }
            }
            while (startGame!= "Y" && startGame != "N");
            if (startGame == "Y")
            {
                life[0] = 10;  
                life[1] = 10;  
                life[2] = 10;  
                life[3] = 1;  
                life[4] = 0;  
            }
            return life;
        }

        // This function prints the player status bar
        public void showStatus(int[] life)
        {
            Console.WriteLine($"HP:{life[0]} MP:{life[1]} STR:{life[2]}");
        }

        // Calculate health loss after strength reaches zero
        public int[] strengthCheck(int[] life)
        {
            Random rn = new Random();
            int hpLoss = 0;
            if(life[2] <=0)
            {
                hpLoss = rn.Next(1,4);
                life[0]-= hpLoss;
                Console.WriteLine($"You loss {hpLoss}HP because you don't have enough strength");
            }
            return life;
        }

        // This function displays good by message
        public void displayGoodbye(bool wantsToPlay)
        {
            if (wantsToPlay)
            {
                Console.WriteLine("Thank you for playing. Goodbye!");   
            }
            else
            {
                Console.WriteLine("Try the great challege next time");   
            }
        }
    }
}
