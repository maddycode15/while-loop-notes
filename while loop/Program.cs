using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10; //player position
            int y = 10; // player position


            bool gameOver = false;

            //initialize your game here Start()

            while(gameOver !=true)
            {
                // this is the update, in unity it runs every frame
                //... this makes the "player" move up and down
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.W)
                {
                    y = y - 1;
                }

                input = Console.ReadKey();
                if (input.Key == ConsoleKey.S)
                {
                    y = y + 1;
                }



                //...
                //...


                // 3. draw -- in unity this happens automaticly

                Console.SetCursorPosition(x, y);
                Console.WriteLine("@");

            }


        }
    }
}
