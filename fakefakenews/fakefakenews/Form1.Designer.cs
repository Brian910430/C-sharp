namespace fakefakenews
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.up = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Label();
            this.pre = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.fontfamily = new System.Windows.Forms.GroupBox();
            this.family3 = new System.Windows.Forms.RadioButton();
            this.family2 = new System.Windows.Forms.RadioButton();
            this.family1 = new System.Windows.Forms.RadioButton();
            this.bold = new System.Windows.Forms.CheckBox();
            this.incline = new System.Windows.Forms.CheckBox();
            this.location = new System.Windows.Forms.GroupBox();
            this.buttright = new System.Windows.Forms.RadioButton();
            this.buttmid = new System.Windows.Forms.RadioButton();
            this.topright = new System.Windows.Forms.RadioButton();
            this.buttleft = new System.Windows.Forms.RadioButton();
            this.topmid = new System.Windows.Forms.RadioButton();
            this.topleft = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textsize = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.fontfamily.SuspendLayout();
            this.location.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(70, 85);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(432, 271);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // up
            // 
            this.up.Font = new System.Drawing.Font("新細明體", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.up.Location = new System.Drawing.Point(52, 19);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(469, 63);
            this.up.TabIndex = 1;
            this.up.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // down
            // 
            this.down.Font = new System.Drawing.Font("新細明體", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.down.Location = new System.Drawing.Point(52, 353);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(469, 71);
            this.down.TabIndex = 2;
            // 
            // pre
            // 
            this.pre.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pre.Location = new System.Drawing.Point(101, 432);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(91, 28);
            this.pre.TabIndex = 3;
            this.pre.Text = "前一張";
            this.pre.UseVisualStyleBackColor = true;
            this.pre.Click += new System.EventHandler(this.pre_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.next.Location = new System.Drawing.Point(374, 432);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(92, 28);
            this.next.TabIndex = 4;
            this.next.Text = "後一張";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // fontfamily
            // 
            this.fontfamily.Controls.Add(this.family3);
            this.fontfamily.Controls.Add(this.family2);
            this.fontfamily.Controls.Add(this.family1);
            this.fontfamily.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.fontfamily.Location = new System.Drawing.Point(527, 34);
            this.fontfamily.Name = "fontfamily";
            this.fontfamily.Size = new System.Drawing.Size(261, 125);
            this.fontfamily.TabIndex = 5;
            this.fontfamily.TabStop = false;
            this.fontfamily.Text = "字體";
            // 
            // family3
            // 
            this.family3.AutoSize = true;
            this.family3.Location = new System.Drawing.Point(27, 80);
            this.family3.Name = "family3";
            this.family3.Size = new System.Drawing.Size(125, 23);
            this.family3.TabIndex = 8;
            this.family3.Text = "微軟正黑體";
            this.family3.UseVisualStyleBackColor = true;
            this.family3.CheckedChanged += new System.EventHandler(this.family3_CheckedChanged);
            // 
            // family2
            // 
            this.family2.AutoSize = true;
            this.family2.Location = new System.Drawing.Point(140, 38);
            this.family2.Name = "family2";
            this.family2.Size = new System.Drawing.Size(106, 23);
            this.family2.TabIndex = 7;
            this.family2.Text = "新細明體";
            this.family2.UseVisualStyleBackColor = true;
            this.family2.CheckedChanged += new System.EventHandler(this.family2_CheckedChanged);
            // 
            // family1
            // 
            this.family1.AutoSize = true;
            this.family1.Checked = true;
            this.family1.Location = new System.Drawing.Point(27, 38);
            this.family1.Name = "family1";
            this.family1.Size = new System.Drawing.Size(87, 23);
            this.family1.TabIndex = 6;
            this.family1.TabStop = true;
            this.family1.Text = "標楷體";
            this.family1.UseVisualStyleBackColor = true;
            this.family1.CheckedChanged += new System.EventHandler(this.family1_CheckedChanged);
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bold.Location = new System.Drawing.Point(554, 165);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(69, 23);
            this.bold.TabIndex = 6;
            this.bold.Text = "粗體";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.Click += new System.EventHandler(this.bold_Click);
            // 
            // incline
            // 
            this.incline.AutoSize = true;
            this.incline.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.incline.Location = new System.Drawing.Point(687, 165);
            this.incline.Name = "incline";
            this.incline.Size = new System.Drawing.Size(69, 23);
            this.incline.TabIndex = 7;
            this.incline.Text = "斜體";
            this.incline.UseVisualStyleBackColor = true;
            this.incline.Click += new System.EventHandler(this.incline_Click);
            // 
            // location
            // 
            this.location.Controls.Add(this.buttright);
            this.location.Controls.Add(this.buttmid);
            this.location.Controls.Add(this.topright);
            this.location.Controls.Add(this.buttleft);
            this.location.Controls.Add(this.topmid);
            this.location.Controls.Add(this.topleft);
            this.location.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.location.Location = new System.Drawing.Point(527, 194);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(261, 125);
            this.location.TabIndex = 8;
            this.location.TabStop = false;
            this.location.Text = "位置";
            // 
            // buttright
            // 
            this.buttright.AutoSize = true;
            this.buttright.Location = new System.Drawing.Point(178, 82);
            this.buttright.Name = "buttright";
            this.buttright.Size = new System.Drawing.Size(68, 23);
            this.buttright.TabIndex = 11;
            this.buttright.Text = "右下";
            this.buttright.UseVisualStyleBackColor = true;
            this.buttright.CheckedChanged += new System.EventHandler(this.buttright_CheckedChanged);
            // 
            // buttmid
            // 
            this.buttmid.AutoSize = true;
            this.buttmid.Location = new System.Drawing.Point(93, 82);
            this.buttmid.Name = "buttmid";
            this.buttmid.Size = new System.Drawing.Size(68, 23);
            this.buttmid.TabIndex = 10;
            this.buttmid.Text = "中下";
            this.buttmid.UseVisualStyleBackColor = true;
            this.buttmid.CheckedChanged += new System.EventHandler(this.buttmid_CheckedChanged);
            // 
            // topright
            // 
            this.topright.AutoSize = true;
            this.topright.Location = new System.Drawing.Point(178, 38);
            this.topright.Name = "topright";
            this.topright.Size = new System.Drawing.Size(68, 23);
            this.topright.TabIndex = 9;
            this.topright.Text = "右上";
            this.topright.UseVisualStyleBackColor = true;
            this.topright.CheckedChanged += new System.EventHandler(this.topright_CheckedChanged);
            // 
            // buttleft
            // 
            this.buttleft.AutoSize = true;
            this.buttleft.Location = new System.Drawing.Point(6, 82);
            this.buttleft.Name = "buttleft";
            this.buttleft.Size = new System.Drawing.Size(68, 23);
            this.buttleft.TabIndex = 8;
            this.buttleft.Text = "左下";
            this.buttleft.UseVisualStyleBackColor = true;
            this.buttleft.CheckedChanged += new System.EventHandler(this.buttleft_CheckedChanged);
            // 
            // topmid
            // 
            this.topmid.AutoSize = true;
            this.topmid.Location = new System.Drawing.Point(93, 38);
            this.topmid.Name = "topmid";
            this.topmid.Size = new System.Drawing.Size(68, 23);
            this.topmid.TabIndex = 7;
            this.topmid.Text = "中上";
            this.topmid.UseVisualStyleBackColor = true;
            this.topmid.CheckedChanged += new System.EventHandler(this.topmid_CheckedChanged);
            // 
            // topleft
            // 
            this.topleft.AutoSize = true;
            this.topleft.Checked = true;
            this.topleft.Location = new System.Drawing.Point(6, 38);
            this.topleft.Name = "topleft";
            this.topleft.Size = new System.Drawing.Size(68, 23);
            this.topleft.TabIndex = 6;
            this.topleft.TabStop = true;
            this.topleft.Text = "左上";
            this.topleft.UseVisualStyleBackColor = true;
            this.topleft.CheckedChanged += new System.EventHandler(this.topleft_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(557, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "字體大小：";
            // 
            // textsize
            // 
            this.textsize.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textsize.Location = new System.Drawing.Point(667, 328);
            this.textsize.Name = "textsize";
            this.textsize.Size = new System.Drawing.Size(100, 28);
            this.textsize.TabIndex = 10;
            this.textsize.Text = "12";
            this.textsize.TextChanged += new System.EventHandler(this.textsize_TextChanged);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input.Location = new System.Drawing.Point(554, 372);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(261, 88);
            this.input.TabIndex = 11;
            this.input.Text = "歐拉歐拉歐拉";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(520, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 38);
            this.label2.TabIndex = 12;
            this.label2.Text = "內\r\n文";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input);
            this.Controls.Add(this.textsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.location);
            this.Controls.Add(this.incline);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.fontfamily);
            this.Controls.Add(this.next);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.picture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.fontfamily.ResumeLayout(false);
            this.fontfamily.PerformLayout();
            this.location.ResumeLayout(false);
            this.location.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label down;
        private System.Windows.Forms.Button pre;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.GroupBox fontfamily;
        private System.Windows.Forms.RadioButton family3;
        private System.Windows.Forms.RadioButton family2;
        private System.Windows.Forms.RadioButton family1;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox incline;
        private System.Windows.Forms.GroupBox location;
        private System.Windows.Forms.RadioButton buttleft;
        private System.Windows.Forms.RadioButton topmid;
        private System.Windows.Forms.RadioButton topleft;
        private System.Windows.Forms.RadioButton topright;
        private System.Windows.Forms.RadioButton buttright;
        private System.Windows.Forms.RadioButton buttmid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsize;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label2;
    }
}

