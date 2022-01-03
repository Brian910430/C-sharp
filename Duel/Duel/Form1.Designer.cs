namespace Duel
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start = new System.Windows.Forms.Button();
            this.roundlabel = new System.Windows.Forms.Label();
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(334, 204);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(99, 30);
            this.start.TabIndex = 0;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // roundlabel
            // 
            this.roundlabel.AutoSize = true;
            this.roundlabel.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.roundlabel.Location = new System.Drawing.Point(272, 35);
            this.roundlabel.Name = "roundlabel";
            this.roundlabel.Size = new System.Drawing.Size(217, 29);
            this.roundlabel.TabIndex = 1;
            this.roundlabel.Text = "第1回合 輪到P1";
            this.roundlabel.Visible = false;
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1.Location = new System.Drawing.Point(676, 204);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(86, 20);
            this.P1.TabIndex = 2;
            this.P1.Text = "P1：0分";
            this.P1.Visible = false;
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2.Location = new System.Drawing.Point(27, 204);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(89, 20);
            this.P2.TabIndex = 3;
            this.P2.Text = "P2：0分";
            this.P2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.roundlabel);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label roundlabel;
        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

