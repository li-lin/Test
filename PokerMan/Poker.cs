using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerMan
{
    public class Poker
    {
        public Suit Suit { get; private set; }
        public Value Value { get; private set; }
        public Poker(Suit suit, Value value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}", this.Suit, this.Value.ToString().Substring(1));
        }
    }
}
