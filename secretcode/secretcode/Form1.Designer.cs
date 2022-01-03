namespace secretcode
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
            this.label1 = new System.Windows.Forms.Label();
            this.alphabets = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.translatetable = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.YesorNo = new System.Windows.Forms.Label();
            this.trans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encrypttable = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.output1 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.decrypttable = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.output2 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.historytable = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.translatetable.SuspendLayout();
            this.encrypttable.SuspendLayout();
            this.decrypttable.SuspendLayout();
            this.historytable.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("王漢宗中隸書繁", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "轉換表";
            // 
            // alphabets
            // 
            this.alphabets.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.alphabets.Location = new System.Drawing.Point(23, 105);
            this.alphabets.Name = "alphabets";
            this.alphabets.Size = new System.Drawing.Size(567, 20);
            this.alphabets.TabIndex = 1;
            this.alphabets.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(647, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "轉換表";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(647, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "加密";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button3.Font = new System.Drawing.Font("王漢宗中隸書繁", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(647, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "解密";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button4.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(647, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "歷史紀錄";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // translatetable
            // 
            this.translatetable.Controls.Add(this.button6);
            this.translatetable.Controls.Add(this.button5);
            this.translatetable.Controls.Add(this.YesorNo);
            this.translatetable.Controls.Add(this.trans);
            this.translatetable.Controls.Add(this.label2);
            this.translatetable.Controls.Add(this.alphabets);
            this.translatetable.Controls.Add(this.label1);
            this.translatetable.Location = new System.Drawing.Point(12, 12);
            this.translatetable.Name = "translatetable";
            this.translatetable.Size = new System.Drawing.Size(629, 381);
            this.translatetable.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button6.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(491, 288);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "確定";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button5.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(364, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "隨機生成";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // YesorNo
            // 
            this.YesorNo.AutoSize = true;
            this.YesorNo.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.YesorNo.Location = new System.Drawing.Point(37, 290);
            this.YesorNo.Name = "YesorNo";
            this.YesorNo.Size = new System.Drawing.Size(0, 24);
            this.YesorNo.TabIndex = 4;
            // 
            // trans
            // 
            this.trans.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.trans.Location = new System.Drawing.Point(26, 219);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(513, 25);
            this.trans.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(266, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "↓";
            // 
            // encrypttable
            // 
            this.encrypttable.Controls.Add(this.button7);
            this.encrypttable.Controls.Add(this.output1);
            this.encrypttable.Controls.Add(this.input1);
            this.encrypttable.Controls.Add(this.label5);
            this.encrypttable.Controls.Add(this.label4);
            this.encrypttable.Controls.Add(this.label3);
            this.encrypttable.Location = new System.Drawing.Point(12, 12);
            this.encrypttable.Name = "encrypttable";
            this.encrypttable.Size = new System.Drawing.Size(629, 381);
            this.encrypttable.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button7.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(491, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 30);
            this.button7.TabIndex = 7;
            this.button7.Text = "確定";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // output1
            // 
            this.output1.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output1.Location = new System.Drawing.Point(149, 217);
            this.output1.Name = "output1";
            this.output1.ReadOnly = true;
            this.output1.Size = new System.Drawing.Size(441, 35);
            this.output1.TabIndex = 4;
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input1.Location = new System.Drawing.Point(149, 109);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(441, 35);
            this.input1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(37, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "加密結果";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(37, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "輸入字串";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("王漢宗中隸書繁", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "加密";
            // 
            // decrypttable
            // 
            this.decrypttable.Controls.Add(this.button8);
            this.decrypttable.Controls.Add(this.output2);
            this.decrypttable.Controls.Add(this.input2);
            this.decrypttable.Controls.Add(this.label7);
            this.decrypttable.Controls.Add(this.label8);
            this.decrypttable.Controls.Add(this.label6);
            this.decrypttable.Location = new System.Drawing.Point(12, 12);
            this.decrypttable.Name = "decrypttable";
            this.decrypttable.Size = new System.Drawing.Size(629, 381);
            this.decrypttable.TabIndex = 8;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button8.Font = new System.Drawing.Font("王漢宗中隸書繁", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(491, 288);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(99, 30);
            this.button8.TabIndex = 12;
            this.button8.Text = "確定";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // output2
            // 
            this.output2.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.output2.Location = new System.Drawing.Point(149, 217);
            this.output2.Name = "output2";
            this.output2.ReadOnly = true;
            this.output2.Size = new System.Drawing.Size(441, 35);
            this.output2.TabIndex = 11;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input2.Location = new System.Drawing.Point(149, 107);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(441, 35);
            this.input2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(37, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "解密結果";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(37, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "輸入密文";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("王漢宗中隸書繁", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(19, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "解密";
            // 
            // historytable
            // 
            this.historytable.Controls.Add(this.message);
            this.historytable.Controls.Add(this.label9);
            this.historytable.Location = new System.Drawing.Point(12, 12);
            this.historytable.Name = "historytable";
            this.historytable.Size = new System.Drawing.Size(629, 381);
            this.historytable.TabIndex = 9;
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("王漢宗中隸書繁", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.message.Location = new System.Drawing.Point(37, 85);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.message.Size = new System.Drawing.Size(553, 274);
            this.message.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("王漢宗中隸書繁", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(19, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 39);
            this.label9.TabIndex = 2;
            this.label9.Text = "歷史紀錄";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 405);
            this.Controls.Add(this.historytable);
            this.Controls.Add(this.decrypttable);
            this.Controls.Add(this.encrypttable);
            this.Controls.Add(this.translatetable);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "替換密碼";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.translatetable.ResumeLayout(false);
            this.translatetable.PerformLayout();
            this.encrypttable.ResumeLayout(false);
            this.encrypttable.PerformLayout();
            this.decrypttable.ResumeLayout(false);
            this.decrypttable.PerformLayout();
            this.historytable.ResumeLayout(false);
            this.historytable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label alphabets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel translatetable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox trans;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label YesorNo;
        private System.Windows.Forms.Panel encrypttable;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox output1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel decrypttable;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox output2;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel historytable;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Label label9;
    }
}

