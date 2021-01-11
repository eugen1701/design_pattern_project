using System;
using System.Collections.Generic;
using System.Text;

namespace DPSDP_Project_Ex3
{
    class Player
    {
        readonly string name;
        int position;
        int nbRollsInARow;
        int money;
        State state;
        public Player(string name)
        {
            this.name = name;
            this.position = 0;
            this.nbRollsInARow = 0;
            state = new OutOfJailState();
        }
        public void setState(State newState)
        {
            state = newState;
        }
        public void playerTurn()
        {
            state.playerTurn(this);
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public int Position
        {
            get { return position; }
            set { position = value; }
        }
        public int NbRollsInARow
        {
            get { return nbRollsInARow; }
            set { nbRollsInARow = value; }
        }
    }
}
