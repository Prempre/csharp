using System;

namespace ConsoleApps
{
    //create the pattern of a chess board that is 8 x 8.  Use X and O to represent the squares
    public static class OXGame
    {
        public static void PlayGame()
        {
            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter the length: ");
            int length = int.Parse(Console.ReadLine());
            char[] cards = {'O','X'};

            int count = 0;

            while(count < length)
            {
                for(int i = 0; i < width; i++)
                {
                    foreach(char letter in cards)
                    {
                        Console.Write(letter);
                    }
                }

                count++;

                if(count%2 == 0)
                {
                    cards[0] = 'O';
                    cards[1] = 'X';
                }
                else
                {
                    cards[0] = 'X';
                    cards[1] = 'O';
                }

                Console.WriteLine();
                
            }

        }


    }
}