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
        private Box _box;
        private Player pa;
        private Player pb;
        public FormPokerMan()
        {
            InitializeComponent();
            this._box = new Box();
            this.pa = new Player("Player A");
            this.pb = new Player("Player B");
        }

        private void buttonPlayerA_Click(object sender, EventArgs e)
        {
            this.pa.CurrentPokcer = this._box.Deal();
            this.labelPlayerA.Text = "选定";
            this.buttonPlayerA.Enabled = false;
            if (this.buttonPlayerA.Enabled == false && this.buttonPlayerB.Enabled == false)
            {
                this.buttonOpen.Enabled = true;
            }
        }

        private void buttonPlayerB_Click(object sender, EventArgs e)
        {
            this.pb.CurrentPokcer = this._box.Deal();
            this.labelPlayerB.Text = "选定";
            this.buttonPlayerB.Enabled = false;
            if (this.buttonPlayerA.Enabled == false && this.buttonPlayerB.Enabled == false)
            {
                this.buttonOpen.Enabled = true;
            }
        }

        private Player openOne(Player a, Player b)
        {
            Player p = null;
            if (a.CurrentPokcer.Value > b.CurrentPokcer.Value)
            {
                p = a;
            }
            else if (a.CurrentPokcer.Value == b.CurrentPokcer.Value)
            {
                if (a.CurrentPokcer.Suit > b.CurrentPokcer.Suit)
                {
                    p = a;
                }
                else
                {
                    p = b;
                }
            }
            else
            {             
                p = b;
            }
            return p;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            int r = Box.ALL_COUNT / 4;
            this.labelPlayerA.Text = this.pa.CurrentPokcer.ToString();
                this.labelPlayerB.Text = this.pb.CurrentPokcer.ToString();
                Player winer = this.openOne(this.pa, this.pb);
                winer.GetOne();
                this.labelResultA.Text = string.Format("得分：{0}", this.pa.Score);
                this.labelResultB.Text = string.Format("得分：{0}", this.pb.Score);
                this.buttonPlayerA.Enabled = true;
                this.buttonPlayerB.Enabled = true;
                this.buttonOpen.Enabled = false;
            if (this.pa.Score > r)
            {
                MessageBox.Show(string.Format("{0} 胜利!", this.pa.Name));
            }
            else if (this.pb.Score > r)
            {
                MessageBox.Show(string.Format("{0} 胜利!", this.pb.Name));
            }
            else if (this.pa.Score == r && this.pb.Score == r)
            {
                MessageBox.Show("平局！");
            }
            else 
            {                
                return;
            }

            this.reset();
        }
        private void reset()
        {
            DialogResult dr = MessageBox.Show("是否重新再来一局？", "提示", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                this._box = new Box();
                this.pa = new Player("Tom");
                this.pb = new Player("Jerry");
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
