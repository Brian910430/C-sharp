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
            this.selectbt = new System.Windows.Forms.Button();
            this.stopbt = new System.Windows.Forms.Button();
            this.playbt = new System.Windows.Forms.Button();
            this.loopch = new System.Windows.Forms.CheckBox();
            this.playlistgp = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playlistitem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveitem = new System.Windows.Forms.ToolStripMenuItem();
            this.loaditem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloritem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontitem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectbt
            // 
            this.selectbt.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectbt.Location = new System.Drawing.Point(486, 361);
            this.selectbt.Name = "selectbt";
            this.selectbt.Size = new System.Drawing.Size(156, 45);
            this.selectbt.TabIndex = 16;
            this.selectbt.Text = "select files";
            this.selectbt.UseVisualStyleBackColor = true;
            this.selectbt.Click += new System.EventHandler(this.selectbt_Click);
            // 
            // stopbt
            // 
            this.stopbt.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stopbt.Location = new System.Drawing.Point(248, 361);
            this.stopbt.Name = "stopbt";
            this.stopbt.Size = new System.Drawing.Size(156, 45);
            this.stopbt.TabIndex = 15;
            this.stopbt.Text = "STOP";
            this.stopbt.UseVisualStyleBackColor = true;
            this.stopbt.Click += new System.EventHandler(this.stopbt_Click);
            // 
            // playbt
            // 
            this.playbt.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playbt.Location = new System.Drawing.Point(26, 361);
            this.playbt.Name = "playbt";
            this.playbt.Size = new System.Drawing.Size(156, 45);
            this.playbt.TabIndex = 14;
            this.playbt.Text = "PLAY";
            this.playbt.UseVisualStyleBackColor = true;
            this.playbt.Click += new System.EventHandler(this.playbt_Click);
            // 
            // loopch
            // 
            this.loopch.AutoSize = true;
            this.loopch.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loopch.Location = new System.Drawing.Point(12, 315);
            this.loopch.Name = "loopch";
            this.loopch.Size = new System.Drawing.Size(72, 22);
            this.loopch.TabIndex = 13;
            this.loopch.Text = "Loop";
            this.loopch.UseVisualStyleBackColor = true;
            this.loopch.CheckedChanged += new System.EventHandler(this.loopch_CheckedChanged);
            // 
            // playlistgp
            // 
            this.playlistgp.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playlistgp.Location = new System.Drawing.Point(12, 45);
            this.playlistgp.Name = "playlistgp";
            this.playlistgp.Size = new System.Drawing.Size(673, 264);
            this.playlistgp.TabIndex = 12;
            this.playlistgp.TabStop = false;
            this.playlistgp.Text = "Playlist";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistitem,
            this.coloritem,
            this.fontitem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playlistitem
            // 
            this.playlistitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveitem,
            this.loaditem});
            this.playlistitem.Font = new System.Drawing.Font("王漢宗中隸書繁", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playlistitem.Name = "playlistitem";
            this.playlistitem.Size = new System.Drawing.Size(70, 24);
            this.playlistitem.Text = "Playlist";
            // 
            // saveitem
            // 
            this.saveitem.Name = "saveitem";
            this.saveitem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveitem.Size = new System.Drawing.Size(255, 26);
            this.saveitem.Text = "Save To File";
            this.saveitem.Click += new System.EventHandler(this.saveitem_Click);
            // 
            // loaditem
            // 
            this.loaditem.Name = "loaditem";
            this.loaditem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loaditem.Size = new System.Drawing.Size(255, 26);
            this.loaditem.Text = "Load From File";
            this.loaditem.Click += new System.EventHandler(this.loaditem_Click);
            // 
            // coloritem
            // 
            this.coloritem.Font = new System.Drawing.Font("王漢宗中隸書繁", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.coloritem.Name = "coloritem";
            this.coloritem.Size = new System.Drawing.Size(57, 20);
            this.coloritem.Text = "Color";
            this.coloritem.Click += new System.EventHandler(this.coloritem_Click);
            // 
            // fontitem
            // 
            this.fontitem.Font = new System.Drawing.Font("王漢宗中隸書繁", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fontitem.Name = "fontitem";
            this.fontitem.Size = new System.Drawing.Size(54, 20);
            this.fontitem.Text = "Font";
            this.fontitem.Click += new System.EventHandler(this.fontitem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 421);
            this.Controls.Add(this.selectbt);
            this.Controls.Add(this.stopbt);
            this.Controls.Add(this.playbt);
            this.Controls.Add(this.loopch);
            this.Controls.Add(this.playlistgp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Music!Advance";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectbt;
        private System.Windows.Forms.Button stopbt;
        private System.Windows.Forms.Button playbt;
        private System.Windows.Forms.CheckBox loopch;
        private System.Windows.Forms.GroupBox playlistgp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playlistitem;
        private System.Windows.Forms.ToolStripMenuItem saveitem;
        private System.Windows.Forms.ToolStripMenuItem loaditem;
        private System.Windows.Forms.ToolStripMenuItem coloritem;
        private System.Windows.Forms.ToolStripMenuItem fontitem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

