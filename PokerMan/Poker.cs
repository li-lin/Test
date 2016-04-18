using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerMan
{
    /// <summary>
    /// 扑克牌类，通过花色和数值描述一张扑克牌。
    /// 花色和数值均为枚举类型。
    /// </summary>
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
