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
        public List<Poker> Pokers { get; private set; }
        private Poker _currentPoker;
        public Poker CurrentPoker
        {
            get { return this._currentPoker; }
            set
            {
                this._currentPoker = value;
                if (value != null)
                {
                    this.Pokers.Add(value);
                }
            }
        }
        /// <summary>
        /// 玩家构造函数
        /// </summary>
        /// <param name="name">玩家姓名</param>
        public Player(string name)
        {
            this.Name = name;
            this.Pokers = new List<Poker>();
        }
        /// <summary>
        /// 玩家赢得一次计一分
        /// </summary>
        public void WinOnce()
        {
            this.Score += 1;
        }

        public void Reset()
        {
            this.CurrentPoker = null;
            this.Pokers.Clear();
            this.Score = 0;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
