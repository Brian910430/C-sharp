namespace Gobang
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
            this.P2label = new System.Windows.Forms.Label();
            this.P1label = new System.Windows.Forms.Label();
            this.P2Worrior = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P2Archer = new System.Windows.Forms.RadioButton();
            this.P2Mage = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.P1Archer = new System.Windows.Forms.RadioButton();
            this.P1Mage = new System.Windows.Forms.RadioButton();
            this.P1Worrior = new System.Windows.Forms.RadioButton();
            this.start = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.P2numD = new System.Windows.Forms.RadioButton();
            this.P2numC = new System.Windows.Forms.RadioButton();
            this.P2numB = new System.Windows.Forms.RadioButton();
            this.P2numA = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.P1numB = new System.Windows.Forms.RadioButton();
            this.P1numD = new System.Windows.Forms.RadioButton();
            this.P1numC = new System.Windows.Forms.RadioButton();
            this.P1numA = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // P2label
            // 
            this.P2label.AutoSize = true;
            this.P2label.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2label.Location = new System.Drawing.Point(12, 52);
            this.P2label.Name = "P2label";
            this.P2label.Size = new System.Drawing.Size(66, 24);
            this.P2label.TabIndex = 0;
            this.P2label.Text = "P2：";
            // 
            // P1label
            // 
            this.P1label.AutoSize = true;
            this.P1label.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1label.Location = new System.Drawing.Point(739, 52);
            this.P1label.Name = "P1label";
            this.P1label.Size = new System.Drawing.Size(63, 24);
            this.P1label.TabIndex = 1;
            this.P1label.Text = "P1：";
            // 
            // P2Worrior
            // 
            this.P2Worrior.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.P2Worrior.Appearance = System.Windows.Forms.Appearance.Button;
            this.P2Worrior.AutoSize = true;
            this.P2Worrior.Checked = true;
            this.P2Worrior.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2Worrior.Location = new System.Drawing.Point(16, 23);
            this.P2Worrior.Name = "P2Worrior";
            this.P2Worrior.Size = new System.Drawing.Size(79, 39);
            this.P2Worrior.TabIndex = 2;
            this.P2Worrior.TabStop = true;
            this.P2Worrior.Text = "戰士";
            this.P2Worrior.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.P2Archer);
            this.panel1.Controls.Add(this.P2Mage);
            this.panel1.Controls.Add(this.P2Worrior);
            this.panel1.Location = new System.Drawing.Point(12, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 313);
            this.panel1.TabIndex = 5;
            // 
            // P2Archer
            // 
            this.P2Archer.Appearance = System.Windows.Forms.Appearance.Button;
            this.P2Archer.AutoSize = true;
            this.P2Archer.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2Archer.Location = new System.Drawing.Point(3, 251);
            this.P2Archer.Name = "P2Archer";
            this.P2Archer.Size = new System.Drawing.Size(107, 39);
            this.P2Archer.TabIndex = 4;
            this.P2Archer.Text = "弓箭手";
            this.P2Archer.UseVisualStyleBackColor = true;
            // 
            // P2Mage
            // 
            this.P2Mage.Appearance = System.Windows.Forms.Appearance.Button;
            this.P2Mage.AutoSize = true;
            this.P2Mage.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2Mage.Location = new System.Drawing.Point(16, 134);
            this.P2Mage.Name = "P2Mage";
            this.P2Mage.Size = new System.Drawing.Size(79, 39);
            this.P2Mage.TabIndex = 3;
            this.P2Mage.Text = "法師";
            this.P2Mage.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.P1Archer);
            this.panel2.Controls.Add(this.P1Mage);
            this.panel2.Controls.Add(this.P1Worrior);
            this.panel2.Location = new System.Drawing.Point(743, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 313);
            this.panel2.TabIndex = 6;
            // 
            // P1Archer
            // 
            this.P1Archer.Appearance = System.Windows.Forms.Appearance.Button;
            this.P1Archer.AutoSize = true;
            this.P1Archer.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1Archer.Location = new System.Drawing.Point(14, 251);
            this.P1Archer.Name = "P1Archer";
            this.P1Archer.Size = new System.Drawing.Size(107, 39);
            this.P1Archer.TabIndex = 4;
            this.P1Archer.Text = "弓箭手";
            this.P1Archer.UseVisualStyleBackColor = true;
            // 
            // P1Mage
            // 
            this.P1Mage.Appearance = System.Windows.Forms.Appearance.Button;
            this.P1Mage.AutoSize = true;
            this.P1Mage.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1Mage.Location = new System.Drawing.Point(28, 134);
            this.P1Mage.Name = "P1Mage";
            this.P1Mage.Size = new System.Drawing.Size(79, 39);
            this.P1Mage.TabIndex = 3;
            this.P1Mage.Text = "法師";
            this.P1Mage.UseVisualStyleBackColor = true;
            // 
            // P1Worrior
            // 
            this.P1Worrior.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
            this.P1Worrior.Appearance = System.Windows.Forms.Appearance.Button;
            this.P1Worrior.AutoSize = true;
            this.P1Worrior.Checked = true;
            this.P1Worrior.Font = new System.Drawing.Font("王漢宗中隸書繁", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1Worrior.Location = new System.Drawing.Point(28, 23);
            this.P1Worrior.Name = "P1Worrior";
            this.P1Worrior.Size = new System.Drawing.Size(79, 39);
            this.P1Worrior.TabIndex = 2;
            this.P1Worrior.TabStop = true;
            this.P1Worrior.Text = "戰士";
            this.P1Worrior.UseVisualStyleBackColor = true;
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(363, 436);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(116, 34);
            this.start.TabIndex = 7;
            this.start.Text = "開始遊戲";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.P2numD);
            this.panel3.Controls.Add(this.P2numC);
            this.panel3.Controls.Add(this.P2numB);
            this.panel3.Controls.Add(this.P2numA);
            this.panel3.Location = new System.Drawing.Point(3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 313);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // P2numD
            // 
            this.P2numD.Appearance = System.Windows.Forms.Appearance.Button;
            this.P2numD.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2numD.Location = new System.Drawing.Point(8, 251);
            this.P2numD.Name = "P2numD";
            this.P2numD.Size = new System.Drawing.Size(139, 39);
            this.P2numD.TabIndex = 3;
            this.P2numD.TabStop = true;
            this.P2numD.Text = "覆蓋棋子";
            this.P2numD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2numD.UseVisualStyleBackColor = true;
            this.P2numD.Click += new System.EventHandler(this.choose_click);
            // 
            // P2numC
            // 
            this.P2numC.Appearance = System.Windows.Forms.Appearance.Button;
            this.P2numC.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2numC.Location = new System.Drawing.Point(8, 179);
            this.P2numC.Name = "P2numC";
            this.P2numC.Size = new System.Drawing.Size(139, 39);
            this.P2numC.TabIndex = 2;
            this.P2numC.TabStop = true;
            this.P2numC.Text = "縱向棋子";
            this.P2numC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2numC.UseVisualStyleBackColor = true;
            this.P2numC.Click += new System.EventHandler(this.choose_click);
            // 
            // P2numB
            // 
            this.P2numB.Appearance = System.Windows.Forms.Appearance.Button;
            this.P2numB.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2numB.Location = new System.Drawing.Point(8, 99);
            this.P2numB.Name = "P2numB";
            this.P2numB.Size = new System.Drawing.Size(139, 39);
            this.P2numB.TabIndex = 1;
            this.P2numB.TabStop = true;
            this.P2numB.Text = "橫向棋子";
            this.P2numB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2numB.UseVisualStyleBackColor = true;
            this.P2numB.Click += new System.EventHandler(this.choose_click);
            // 
            // P2numA
            // 
            this.P2numA.Appearance = System.Windows.Forms.Appearance.Button;
            this.P2numA.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P2numA.Location = new System.Drawing.Point(8, 23);
            this.P2numA.Name = "P2numA";
            this.P2numA.Size = new System.Drawing.Size(139, 39);
            this.P2numA.TabIndex = 0;
            this.P2numA.TabStop = true;
            this.P2numA.Text = "普通棋子";
            this.P2numA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P2numA.UseVisualStyleBackColor = true;
            this.P2numA.Click += new System.EventHandler(this.choose_click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.P1numB);
            this.panel4.Controls.Add(this.P1numD);
            this.panel4.Controls.Add(this.P1numC);
            this.panel4.Controls.Add(this.P1numA);
            this.panel4.Location = new System.Drawing.Point(720, 109);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 313);
            this.panel4.TabIndex = 9;
            this.panel4.Visible = false;
            // 
            // P1numB
            // 
            this.P1numB.Appearance = System.Windows.Forms.Appearance.Button;
            this.P1numB.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1numB.Location = new System.Drawing.Point(3, 99);
            this.P1numB.Name = "P1numB";
            this.P1numB.Size = new System.Drawing.Size(141, 39);
            this.P1numB.TabIndex = 10;
            this.P1numB.TabStop = true;
            this.P1numB.Text = "橫向棋子";
            this.P1numB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1numB.UseVisualStyleBackColor = true;
            this.P1numB.Click += new System.EventHandler(this.choose_click);
            // 
            // P1numD
            // 
            this.P1numD.Appearance = System.Windows.Forms.Appearance.Button;
            this.P1numD.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1numD.Location = new System.Drawing.Point(3, 254);
            this.P1numD.Name = "P1numD";
            this.P1numD.Size = new System.Drawing.Size(139, 39);
            this.P1numD.TabIndex = 3;
            this.P1numD.TabStop = true;
            this.P1numD.Text = "覆蓋棋子";
            this.P1numD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1numD.UseVisualStyleBackColor = true;
            this.P1numD.Click += new System.EventHandler(this.choose_click);
            // 
            // P1numC
            // 
            this.P1numC.Appearance = System.Windows.Forms.Appearance.Button;
            this.P1numC.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1numC.Location = new System.Drawing.Point(3, 182);
            this.P1numC.Name = "P1numC";
            this.P1numC.Size = new System.Drawing.Size(139, 39);
            this.P1numC.TabIndex = 2;
            this.P1numC.TabStop = true;
            this.P1numC.Text = "縱向棋子";
            this.P1numC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1numC.UseVisualStyleBackColor = true;
            this.P1numC.Click += new System.EventHandler(this.choose_click);
            // 
            // P1numA
            // 
            this.P1numA.Appearance = System.Windows.Forms.Appearance.Button;
            this.P1numA.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.P1numA.Location = new System.Drawing.Point(3, 24);
            this.P1numA.Name = "P1numA";
            this.P1numA.Size = new System.Drawing.Size(139, 42);
            this.P1numA.TabIndex = 0;
            this.P1numA.TabStop = true;
            this.P1numA.Text = "普通棋子";
            this.P1numA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.P1numA.UseVisualStyleBackColor = true;
            this.P1numA.Click += new System.EventHandler(this.choose_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 544);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.start);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.P1label);
            this.Controls.Add(this.P2label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P2label;
        private System.Windows.Forms.Label P1label;
        private System.Windows.Forms.RadioButton P2Worrior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton P2Archer;
        private System.Windows.Forms.RadioButton P2Mage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton P1Archer;
        private System.Windows.Forms.RadioButton P1Mage;
        private System.Windows.Forms.RadioButton P1Worrior;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton P2numD;
        private System.Windows.Forms.RadioButton P2numC;
        private System.Windows.Forms.RadioButton P2numB;
        private System.Windows.Forms.RadioButton P2numA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton P1numD;
        private System.Windows.Forms.RadioButton P1numC;
        private System.Windows.Forms.RadioButton P1numA;
        private System.Windows.Forms.RadioButton P1numB;
    }
}

