using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerMan
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; private set; }
        public Player(string name)
        {
            this.Name = name;
        }
        public void GetOne()
        {
            this.Score += 1;
        }
        public Poker CurrentPokcer { get; set; }
    }
}
