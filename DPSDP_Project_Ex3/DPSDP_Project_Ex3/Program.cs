using System;
using System.Collections.Generic;

namespace DPSDP_Project_Ex3
{
    class Program
    {
        static void Main()
        {
            List<Player> players = new List<Player>() { new Player("Player 1"), new Player("Player 2") };
            Console.WriteLine("************MONOPOLY************");
            string cond = "1";
            while (cond=="1")
            {
                foreach (Player p in players)
                {
                    Console.WriteLine(p.Name + "'s turn :");
                    Console.WriteLine("1. Roll the dices | 2. Stop playing");
                    cond = Console.ReadLine();
                    if (cond == "1")
                    {
                        p.playerTurn();
                        Console.WriteLine("Position : " + p.Position);
                        Console.WriteLine("Money : " + p.Money + "\n");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("Press a key to stop the process...");
            Console.ReadKey();
        }
    }
}
