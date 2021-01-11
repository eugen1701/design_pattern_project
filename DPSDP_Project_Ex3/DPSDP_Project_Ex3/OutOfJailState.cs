using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project_Ex3
{
    class OutOfJailState : State
    {
        public void playerTurn(Player p)
        {
            p.NbRollsInARow = 0;
            int dice1, dice2;
            do
            {
                Random rnd = new Random();
                dice1 = rnd.Next(1, 7);
                dice2 = rnd.Next(1, 7);
                p.NbRollsInARow++;
                if (p.NbRollsInARow <= 3)
                {
                    Console.WriteLine("dice 1 : " + dice1);
                    Console.WriteLine("dice 2 : " + dice2);
                }
                if (dice1 == dice2)
                {
                    Console.WriteLine("DOUBLE ! Re-rolling the dices...");
                }
                p.Position += dice1 + dice2;
                if (p.Position == 30 || p.NbRollsInARow == 4)
                {
                    if (p.Position == 30)
                    {
                        Console.WriteLine("Position 30 : Go to jail ! You lose 100$");
                    }
                    else
                    {
                        Console.WriteLine("Three doubles in a row ! You go to jail ! You lose 100$");
                    }
                    p.Money -= 100;
                    p.setState(new InJailState());
                    p.Position = 10;
                    break;
                }
                if (p.Position >= 40)
                {
                    p.Position -= 40;
                    p.Money += 50;
                    Console.WriteLine("You went through position 0 ! You earn 50$");
                }
                if (p.Position == 0)
                {
                    p.Money += 400;
                    Console.WriteLine("Position 0 !! Jackpot ! You earn 200$ !");
                }
            } while (dice1 == dice2);
            p.NbRollsInARow = 0;
        }
    }
}
