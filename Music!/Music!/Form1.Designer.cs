namespace Music_
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
            this.loopch = new System.Windows.Forms.CheckBox();
            this.playbt = new System.Windows.Forms.Button();
            this.stopbt = new System.Windows.Forms.Button();
            this.selectbt = new System.Windows.Forms.Button();
            this.playlistgp = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // loopch
            // 
            this.loopch.AutoSize = true;
            this.loopch.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loopch.Location = new System.Drawing.Point(12, 246);
            this.loopch.Name = "loopch";
            this.loopch.Size = new System.Drawing.Size(72, 22);
            this.loopch.TabIndex = 1;
            this.loopch.Text = "Loop";
            this.loopch.UseVisualStyleBackColor = true;
            this.loopch.CheckedChanged += new System.EventHandler(this.loopch_CheckedChanged);
            // 
            // playbt
            // 
            this.playbt.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playbt.Location = new System.Drawing.Point(26, 292);
            this.playbt.Name = "playbt";
            this.playbt.Size = new System.Drawing.Size(156, 45);
            this.playbt.TabIndex = 2;
            this.playbt.Text = "PLAY";
            this.playbt.UseVisualStyleBackColor = true;
            this.playbt.Click += new System.EventHandler(this.playbt_Click);
            // 
            // stopbt
            // 
            this.stopbt.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopbt.Location = new System.Drawing.Point(248, 292);
            this.stopbt.Name = "stopbt";
            this.stopbt.Size = new System.Drawing.Size(156, 45);
            this.stopbt.TabIndex = 3;
            this.stopbt.Text = "STOP";
            this.stopbt.UseVisualStyleBackColor = true;
            this.stopbt.Click += new System.EventHandler(this.stopbt_Click);
            // 
            // selectbt
            // 
            this.selectbt.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectbt.Location = new System.Drawing.Point(486, 292);
            this.selectbt.Name = "selectbt";
            this.selectbt.Size = new System.Drawing.Size(156, 45);
            this.selectbt.TabIndex = 4;
            this.selectbt.Text = "select files";
            this.selectbt.UseVisualStyleBackColor = true;
            this.selectbt.Click += new System.EventHandler(this.selectbt_Click);
            // 
            // playlistgp
            // 
            this.playlistgp.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playlistgp.Location = new System.Drawing.Point(12, 12);
            this.playlistgp.Name = "playlistgp";
            this.playlistgp.Size = new System.Drawing.Size(673, 219);
            this.playlistgp.TabIndex = 5;
            this.playlistgp.TabStop = false;
            this.playlistgp.Text = "Playlist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 364);
            this.Controls.Add(this.playlistgp);
            this.Controls.Add(this.selectbt);
            this.Controls.Add(this.stopbt);
            this.Controls.Add(this.playbt);
            this.Controls.Add(this.loopch);
            this.Name = "Form1";
            this.Text = "Music!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox loopch;
        private System.Windows.Forms.Button playbt;
        private System.Windows.Forms.Button stopbt;
        private System.Windows.Forms.Button selectbt;
        private System.Windows.Forms.GroupBox playlistgp;
    }
}

