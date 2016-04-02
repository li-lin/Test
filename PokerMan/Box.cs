using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerMan
{
    public class Box
    {
        public const int ALL_COUNT = 52;
        private List<Poker> Pokers { get; set; }
        public int Count
        {
            get { return this.Pokers.Count; }
        }
        public Box()
        {
            this.Pokers = new List<Poker>();
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value v in Enum.GetValues(typeof(Value)))
                {
                    this.Pokers.Add(new Poker(s, v));
                }
            }
        }
        public Poker Deal()
        {
            Poker p = null;
            Random random = new Random();
            if (this.Pokers.Count > 0)
            {
                int selectedIndex = random.Next(0, this.Pokers.Count);
                p = this.Pokers[selectedIndex];
                this.Pokers.RemoveAt(selectedIndex);
            }
            return p;
        }

    }
}
