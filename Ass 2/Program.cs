using System;

namespace Ass_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int choice;
            Int32 gennum;
            Random number = new Random();
            char newgame;
            do {
                gennum = number.Next(1, 4);
                Console.WriteLine("Welcome to Rope Paper Scissor");

            Console.WriteLine("\n\n  ");
            Console.WriteLine("\n 1. Rock ");
            Console.WriteLine("\n 2. Paper ");
            Console.WriteLine("\n 3. Scissor ");
            Console.WriteLine("\n\n  ");

            Console.WriteLine(" Select one of then using the given no.  ");
            Console.Write("\n Your Choice: ");
          
                choice = int.Parse(Console.ReadLine());

                while (choice < 1 || choice > 3)
                {
                    Console.Write("\n Your Choice: ");
                    choice = int.Parse(Console.ReadLine());
                    
                }

            if (choice == 1)
            {
                if (gennum == 1)
                {
                    Console.Write("You And Me both picked Rock , So it's a Tie");
                }
                else if (gennum == 2)
                {
                    Console.Write("You picked Rock And I Picked Paper, So I Win :) ");
                }
                else
                {
                    Console.Write("You picked Rock And I Picked Scissor, So You Win :( ");
                }
            }

            else if (choice == 2)
            {
                if (gennum == 1)
                {
                    Console.Write("You picked Paper And I Picked Rock, So You Win :( ");
                }
                else if (gennum == 2)
                {
                    Console.Write("You And Me both picked Paper , So it's a Tie");
                }
                else
                {
                    Console.Write("You picked Paper And I Picked Scissor, So I Win :) ");
                }
            }
            else
            {
                if (gennum == 1)
                {
                    Console.Write("You picked Scissor And I Picked Rock, So I Win :) ");
                }
                else if (gennum == 2)
                {
                    Console.Write("You picked Scissor And I Picked Paper, So You Win :( ");
                }
                else
                {
                    Console.Write("You And Me both picked Rock , So it's a Tie  ");
                }
            }

                Console.WriteLine("\n \n Do You Want to Play again? \n Y/y to play \n Press 'any key to stop'  ");
                newgame = char.Parse(Console.ReadLine());
        }while(newgame == 'Y' || newgame == 'y');
        }

    }
}
