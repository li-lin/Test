using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PokerMan
{
    public partial class FormPokerMan : Form
    {
        private Game game;
        private Player pa;
        private Player pb;
        public FormPokerMan()
        {
            InitializeComponent();
            this.game = new Game();
            this.pa = new Player("Tom");
            this.pb = new Player("Jerry");
            this.buttonPlayerA.Text = this.pa.Name;
            this.buttonPlayerB.Text = this.pb.Name;
        }

        private void buttonPlayerA_Click(object sender, EventArgs e)
        {
            this.game.DealCardToPlayer(this.pa);
            this.labelPlayerA.Text = "选定";
            this.buttonPlayerA.Enabled = false;
            if (this.buttonPlayerA.Enabled == false && this.buttonPlayerB.Enabled == false)
            {
                this.buttonOpen.Enabled = true;
            }
        }

        private void buttonPlayerB_Click(object sender, EventArgs e)
        {
            this.game.DealCardToPlayer(this.pb);
            this.labelPlayerB.Text = "选定";
            this.buttonPlayerB.Enabled = false;
            if (this.buttonPlayerA.Enabled == false && this.buttonPlayerB.Enabled == false)
            {
                this.buttonOpen.Enabled = true;
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            this.labelPlayerA.Text = this.pa.CurrentPoker.ToString();
            this.labelPlayerB.Text = this.pb.CurrentPoker.ToString();
            this.game.OpenOnce(this.pa, this.pb);

            this.labelResultA.Text = string.Format("得分：{0}", this.pa.Score);
            this.labelResultB.Text = string.Format("得分：{0}", this.pb.Score);
            this.buttonPlayerA.Enabled = true;
            this.buttonPlayerB.Enabled = true;
            this.buttonOpen.Enabled = false;

            if (this.game.IsOver(this.pa, this.pb) == true)
            {
                Player winner = this.game.WhoIsWinner(this.pa, this.pb);
                if (winner != null)
                {
                    MessageBox.Show(string.Format("{0} 胜利!", winner), "游戏结束");
                }
                else
                {
                    MessageBox.Show(string.Format("平局"), "游戏结束");
                }
                this.restart();
            }
        }
        private void restart()
        {
            DialogResult dr = MessageBox.Show("是否重新再来一局？", "提示", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this.game.Restart(this.pa,this.pb);
                this.buttonPlayerA.Enabled = this.buttonPlayerB.Enabled = true;
                this.buttonOpen.Enabled = false;
                this.labelPlayerA.Text = this.labelPlayerB.Text = "准备就绪";
                this.labelResultA.Text = this.labelResultB.Text = "";
            }
            else
            {
                this.Close();
            }
        }
    }
}
