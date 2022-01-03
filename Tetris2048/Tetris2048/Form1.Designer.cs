namespace Tetris2048
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
            this.easybutton = new System.Windows.Forms.Button();
            this.hardbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.nextint = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // easybutton
            // 
            this.easybutton.AutoSize = true;
            this.easybutton.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.easybutton.Location = new System.Drawing.Point(294, 147);
            this.easybutton.Name = "easybutton";
            this.easybutton.Size = new System.Drawing.Size(99, 30);
            this.easybutton.TabIndex = 0;
            this.easybutton.Text = "簡單模式";
            this.easybutton.UseVisualStyleBackColor = true;
            this.easybutton.Click += new System.EventHandler(this.easybutton_Click);
            // 
            // hardbutton
            // 
            this.hardbutton.AutoSize = true;
            this.hardbutton.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hardbutton.Location = new System.Drawing.Point(294, 195);
            this.hardbutton.Name = "hardbutton";
            this.hardbutton.Size = new System.Drawing.Size(99, 30);
            this.hardbutton.TabIndex = 1;
            this.hardbutton.Text = "普通模式";
            this.hardbutton.UseVisualStyleBackColor = true;
            this.hardbutton.Click += new System.EventHandler(this.hardbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.score.Location = new System.Drawing.Point(555, 40);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(104, 19);
            this.score.TabIndex = 2;
            this.score.Text = "你的分數：";
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countdown.Location = new System.Drawing.Point(555, 104);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(104, 19);
            this.countdown.TabIndex = 3;
            this.countdown.Text = "倒數計時：";
            // 
            // nextint
            // 
            this.nextint.AutoSize = true;
            this.nextint.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nextint.Location = new System.Drawing.Point(555, 72);
            this.nextint.Name = "nextint";
            this.nextint.Size = new System.Drawing.Size(104, 19);
            this.nextint.TabIndex = 4;
            this.nextint.Text = "當前數字：";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 406);
            this.Controls.Add(this.nextint);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.score);
            this.Controls.Add(this.hardbutton);
            this.Controls.Add(this.easybutton);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Tetris2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easybutton;
        private System.Windows.Forms.Button hardbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label nextint;
        private System.Windows.Forms.Timer timer2;
    }
}

