using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerMan
{
    public class Game
    {
        private Box _box;
        private bool _isBreak;
        private readonly int endScore = Box.ALL_COUNT / 4;
        public Box Box
        {
            get { return this._box; }
        }
        public bool IsOver(Player playerA, Player playerB)
        {
            bool b = false;
            if (playerA.Score > endScore || playerB.Score > endScore)
            {
                b = true;
            }
            else if (playerA.Score == endScore && playerB.Score == endScore)
            {
                b = true;
            }
            else if (this._isBreak)
            {
                b = true;
            }
            return b;
        }
        public Game()
        {
            this._box = new Box();
            this._isBreak = false;
        }
        public void Restart(Player playerA,Player playerB)
        {
            this._box = new Box();
            playerA.Reset();
            playerB.Reset();
        }
        public void Break()
        {
            this._isBreak = true;
        }
        public void DealCardToPlayer(Player player)
        {
            Poker p = this.Box.Deal();
            if (p != null)
            {
                player.CurrentPoker = p;
            }
        }
        public Player WhoIsWinner(Player playerA,Player playerB)
        {
            Player p = null;
            if (playerA.Score > playerB.Score)
            {
                p = playerA;
            }
            else if (playerB.Score > playerA.Score)
            {
                p = playerB;
            }
            return p;
        }

        public void OpenOnce(Player playerA, Player playerB)
        {
            if (playerA.CurrentPoker.Value > playerB.CurrentPoker.Value)
            {
                playerA.WinOnce();
            }
            else if (playerA.CurrentPoker.Value == playerB.CurrentPoker.Value)
            {
                if (playerA.CurrentPoker.Suit > playerB.CurrentPoker.Suit)
                {
                    playerA.WinOnce();
                }
                else
                {
                    playerB.WinOnce();
                }
            }
            else
            {
                playerB.WinOnce();
            }
            playerA.CurrentPoker = null;
            playerB.CurrentPoker = null;
        }
    }
}