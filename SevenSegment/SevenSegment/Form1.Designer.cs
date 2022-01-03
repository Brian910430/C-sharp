namespace SevenSegment
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
            this.row = new System.Windows.Forms.TextBox();
            this.column = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "高(7~15)\r\n\r\n\r\n寬(5~10)";
            // 
            // row
            // 
            this.row.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.row.Location = new System.Drawing.Point(124, 91);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(100, 28);
            this.row.TabIndex = 1;
            // 
            // column
            // 
            this.column.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.column.Location = new System.Drawing.Point(124, 159);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(100, 28);
            this.column.TabIndex = 2;
            // 
            // confirm
            // 
            this.confirm.AutoSize = true;
            this.confirm.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.confirm.Location = new System.Drawing.Point(50, 228);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(100, 34);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "確定";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("王漢宗中隸書繁", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "請輸入數字(-9~99)";
            // 
            // input
            // 
            this.input.Enabled = false;
            this.input.Font = new System.Drawing.Font("王漢宗中隸書繁", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.input.Location = new System.Drawing.Point(16, 388);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(213, 28);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 468);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.column);
            this.Controls.Add(this.row);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.TextBox column;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input;
    }
}

