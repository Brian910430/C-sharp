namespace electriken
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.message = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.namebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.happenslabel = new System.Windows.Forms.Label();
            this.Fbutton = new System.Windows.Forms.Button();
            this.Pbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.Dbutton = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.Moneylabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(88, 52);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem2.Text = "3";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem3.Text = "3";
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.message.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.message.Location = new System.Drawing.Point(22, 23);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message.Size = new System.Drawing.Size(339, 341);
            this.message.TabIndex = 1;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.name.Location = new System.Drawing.Point(22, 379);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(233, 32);
            this.name.TabIndex = 2;
            // 
            // namebutton
            // 
            this.namebutton.AutoSize = true;
            this.namebutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.namebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.namebutton.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.namebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.namebutton.Location = new System.Drawing.Point(261, 379);
            this.namebutton.Name = "namebutton";
            this.namebutton.Size = new System.Drawing.Size(100, 32);
            this.namebutton.TabIndex = 3;
            this.namebutton.Text = "輸入名字";
            this.namebutton.UseVisualStyleBackColor = false;
            this.namebutton.Click += new System.EventHandler(this.namebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(397, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "金錢";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(397, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "狀態";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // statuslabel
            // 
            this.statuslabel.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.statuslabel.Location = new System.Drawing.Point(434, 133);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(250, 117);
            this.statuslabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(397, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "事件";
            this.label3.UseCompatibleTextRendering = true;
            // 
            // happenslabel
            // 
            this.happenslabel.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.happenslabel.Location = new System.Drawing.Point(434, 294);
            this.happenslabel.Name = "happenslabel";
            this.happenslabel.Size = new System.Drawing.Size(265, 30);
            this.happenslabel.TabIndex = 8;
            // 
            // Fbutton
            // 
            this.Fbutton.AutoSize = true;
            this.Fbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Fbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fbutton.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Fbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Fbutton.Location = new System.Drawing.Point(386, 343);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(75, 32);
            this.Fbutton.TabIndex = 9;
            this.Fbutton.Text = "餵食";
            this.Fbutton.UseVisualStyleBackColor = false;
            this.Fbutton.Click += new System.EventHandler(this.Fbutton_Click);
            // 
            // Pbutton
            // 
            this.Pbutton.AutoSize = true;
            this.Pbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pbutton.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pbutton.Location = new System.Drawing.Point(476, 343);
            this.Pbutton.Name = "Pbutton";
            this.Pbutton.Size = new System.Drawing.Size(75, 32);
            this.Pbutton.TabIndex = 10;
            this.Pbutton.Text = "玩耍";
            this.Pbutton.UseVisualStyleBackColor = false;
            this.Pbutton.Click += new System.EventHandler(this.Pbutton_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.AutoSize = true;
            this.Cbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Cbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cbutton.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cbutton.Location = new System.Drawing.Point(567, 343);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(75, 32);
            this.Cbutton.TabIndex = 11;
            this.Cbutton.Text = "清掃";
            this.Cbutton.UseVisualStyleBackColor = false;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // Dbutton
            // 
            this.Dbutton.AutoSize = true;
            this.Dbutton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Dbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Dbutton.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Dbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dbutton.Location = new System.Drawing.Point(660, 343);
            this.Dbutton.Name = "Dbutton";
            this.Dbutton.Size = new System.Drawing.Size(79, 32);
            this.Dbutton.TabIndex = 12;
            this.Dbutton.Text = "看醫生";
            this.Dbutton.UseVisualStyleBackColor = false;
            this.Dbutton.Click += new System.EventHandler(this.Dbutton_Click);
            // 
            // finish
            // 
            this.finish.AutoSize = true;
            this.finish.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.finish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finish.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.finish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.finish.Location = new System.Drawing.Point(620, 393);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(159, 32);
            this.finish.TabIndex = 13;
            this.finish.Text = "結束這天";
            this.finish.UseVisualStyleBackColor = false;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // Moneylabel
            // 
            this.Moneylabel.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Moneylabel.Location = new System.Drawing.Point(434, 68);
            this.Moneylabel.Name = "Moneylabel";
            this.Moneylabel.Size = new System.Drawing.Size(152, 30);
            this.Moneylabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Moneylabel);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.Dbutton);
            this.Controls.Add(this.Cbutton);
            this.Controls.Add(this.Pbutton);
            this.Controls.Add(this.Fbutton);
            this.Controls.Add(this.happenslabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namebutton);
            this.Controls.Add(this.name);
            this.Controls.Add(this.message);
            this.Name = "Form1";
            this.Text = "電子雞";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button namebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label happenslabel;
        private System.Windows.Forms.Button Fbutton;
        private System.Windows.Forms.Button Pbutton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button Dbutton;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label Moneylabel;
    }
}

