namespace PokerMan
{
    partial class FormPokerMan
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPlayerA = new System.Windows.Forms.Label();
            this.labelPlayerB = new System.Windows.Forms.Label();
            this.buttonPlayerA = new System.Windows.Forms.Button();
            this.buttonPlayerB = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelResultA = new System.Windows.Forms.Label();
            this.labelResultB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlayerA
            // 
            this.labelPlayerA.AutoSize = true;
            this.labelPlayerA.Location = new System.Drawing.Point(39, 58);
            this.labelPlayerA.Name = "labelPlayerA";
            this.labelPlayerA.Size = new System.Drawing.Size(53, 12);
            this.labelPlayerA.TabIndex = 0;
            this.labelPlayerA.Text = "准备就绪";
            // 
            // labelPlayerB
            // 
            this.labelPlayerB.AutoSize = true;
            this.labelPlayerB.Location = new System.Drawing.Point(173, 58);
            this.labelPlayerB.Name = "labelPlayerB";
            this.labelPlayerB.Size = new System.Drawing.Size(53, 12);
            this.labelPlayerB.TabIndex = 1;
            this.labelPlayerB.Text = "准备就绪";
            // 
            // buttonPlayerA
            // 
            this.buttonPlayerA.Location = new System.Drawing.Point(27, 112);
            this.buttonPlayerA.Name = "buttonPlayerA";
            this.buttonPlayerA.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayerA.TabIndex = 2;
            this.buttonPlayerA.Text = "玩家A";
            this.buttonPlayerA.UseVisualStyleBackColor = true;
            this.buttonPlayerA.Click += new System.EventHandler(this.buttonPlayerA_Click);
            // 
            // buttonPlayerB
            // 
            this.buttonPlayerB.Location = new System.Drawing.Point(164, 112);
            this.buttonPlayerB.Name = "buttonPlayerB";
            this.buttonPlayerB.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayerB.TabIndex = 3;
            this.buttonPlayerB.Text = "玩家B";
            this.buttonPlayerB.UseVisualStyleBackColor = true;
            this.buttonPlayerB.Click += new System.EventHandler(this.buttonPlayerB_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Enabled = false;
            this.buttonOpen.Location = new System.Drawing.Point(98, 178);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "开牌";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelResultA
            // 
            this.labelResultA.AutoSize = true;
            this.labelResultA.Location = new System.Drawing.Point(39, 149);
            this.labelResultA.Name = "labelResultA";
            this.labelResultA.Size = new System.Drawing.Size(0, 12);
            this.labelResultA.TabIndex = 5;
            // 
            // labelResultB
            // 
            this.labelResultB.AutoSize = true;
            this.labelResultB.Location = new System.Drawing.Point(185, 149);
            this.labelResultB.Name = "labelResultB";
            this.labelResultB.Size = new System.Drawing.Size(0, 12);
            this.labelResultB.TabIndex = 6;
            // 
            // FormPokerMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelResultB);
            this.Controls.Add(this.labelResultA);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonPlayerB);
            this.Controls.Add(this.buttonPlayerA);
            this.Controls.Add(this.labelPlayerB);
            this.Controls.Add(this.labelPlayerA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPokerMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Poker Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayerA;
        private System.Windows.Forms.Label labelPlayerB;
        private System.Windows.Forms.Button buttonPlayerA;
        private System.Windows.Forms.Button buttonPlayerB;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelResultA;
        private System.Windows.Forms.Label labelResultB;
    }
}

