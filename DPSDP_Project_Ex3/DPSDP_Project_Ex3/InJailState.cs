using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project_Ex3
{
    class InJailState : State
    {
        public void playerTurn(Player p)
        {
            Random rnd = new Random();
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            p.NbRollsInARow++;
            Console.WriteLine("dice 1 : " + dice1);
            Console.WriteLine("dice 2 : " + dice2);
            if (dice1 == dice2 || p.NbRollsInARow == 3)
            {
                Console.WriteLine("out of jail");
                p.NbRollsInARow = 0;
                p.setState(new OutOfJailState());
                p.Position += dice1 + dice2;
            }
            else
            {
                Console.WriteLine("miss, try again next turn");
            }
            if (p.Position >= 40)
            {
                p.Position -= 40;
            }
        }
    }
}
