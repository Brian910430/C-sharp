using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenSegment
{
    public partial class Form1 : Form
    {
        int r = 0;
        int c = 0;
        int[] light1 = { 0, 0, 0, 0, 0, 0, 0 };
        int[] light2 = { 0, 0, 0, 0, 0, 0, 0 };
        bool first = true;
        char[] num = new char[2];
        Button[] btn1;
        Button[] btn2;
        public Form1()
        {
            InitializeComponent();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            try
            {
                r = int.Parse(row.Text);
                c = int.Parse(column.Text);
                if (r < 7 || r > 15 || c < 5 || c > 10)
                {
                    MessageBox.Show("請輸入範圍內的數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else if (r % 2 == 0)
                {
                    MessageBox.Show("高不能為偶數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                input.Enabled = true;
            }
            catch
            {
                MessageBox.Show("請輸入數字", "警告", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            generatebutton(r, c);
        }

        public void generatebutton(int row, int col)
        {
            if (!first)
            {
                foreach (Button btn in btn1)
                    Controls.Remove(btn);
                foreach (Button btn in btn2)
                    Controls.Remove(btn);
            }

            btn1 = new Button[row * col];
            btn2 = new Button[row * col];
            int width = 250 / col;
            int height = 350 / row;
            int count = 0;

            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < col; i++)
                {
                    btn1[count] = new Button();
                    btn1[count].SetBounds(200 + width * i, 20 + height * j, width, height);
                    btn1[count].BackColor = Color.White;
                    btn1[count].Enabled = false;
                    Controls.Add(btn1[count]);

                    btn2[count] = new Button();
                    btn2[count].SetBounds(500 + width * i, 20 + height * j, width, height);
                    btn2[count].BackColor = Color.White;
                    btn2[count].Enabled = false;
                    Controls.Add(btn2[count]);

                    count++;
                }
            }
            ignite();
            first = false;
        }

        public void ignite()
        {
            num[0] = 'a';
            num[1] = 'a';
            if (input.Text.Length == 2)
            {
                num[0] = input.Text[0];
                num[1] = input.Text[1];
            }
            else if (input.Text.Length == 1 && (input.Text[0] <= '9' && input.Text[0] >= '0')) 
            {
                num[0] = '0';
                num[1] = input.Text[0];
            }

            if (num[0] == '-' && num[1] == '0')
            {
                num[0] = '0';
                num[1] = '0';
            }

            switch (num[0])
            {
                case '-':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 0;
                    light1[6] = 1;
                    break;
                case '0':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    light1[6] = 0;
                    break;
                case '1':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 0;
                    light1[1] = 1;
                    light1[2] = 1;
                    break;
                case '2':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    light1[2] = 0;
                    light1[5] = 0;
                    break;
                case '3':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    light1[4] = 0;
                    light1[5] = 0;
                    break;
                case '4':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    light1[0] = 0;
                    light1[3] = 0;
                    light1[4] = 0;
                    break;
                case '5':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    light1[1] = 0;
                    light1[4] = 0;
                    break;
                case '6':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    light1[1] = 0;
                    break;
                case '7':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 0;
                    light1[0] = 1;
                    light1[1] = 1;
                    light1[2] = 1;
                    break;
                case '8':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    break;
                case '9':
                    for (int i = 0; i < 7; i++)
                        light1[i] = 1;
                    light1[4] = 0;
                    break;
                default:
                    for (int i = 0; i < 7; i++)
                        light1[i] = 0;
                    break;
            }

            switch (num[1])
            {
                case '0':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    light2[6] = 0;
                    break;
                case '1':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 0;
                    light2[1] = 1;
                    light2[2] = 1;
                    break;
                case '2':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    light2[2] = 0;
                    light2[5] = 0;
                    break;
                case '3':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    light2[4] = 0;
                    light2[5] = 0;
                    break;
                case '4':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    light2[0] = 0;
                    light2[3] = 0;
                    light2[4] = 0;
                    break;
                case '5':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    light2[1] = 0;
                    light2[4] = 0;
                    break;
                case '6':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    light2[1] = 0;
                    break;
                case '7':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 0;
                    light2[0] = 1;
                    light2[1] = 1;
                    light2[2] = 1;
                    break;
                case '8':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    break;
                case '9':
                    for (int i = 0; i < 7; i++)
                        light2[i] = 1;
                    light2[4] = 0;
                    break;
                default:
                    for (int i = 0; i < 7; i++)
                        light2[i] = 0;
                    break;
            }

            if (light1[0] == 1)for (int i=1;i<c-1;i++)                  btn1[i].BackColor = Color.Blue;
            else               for (int i=1;i<c-1;i++)                  btn1[i].BackColor = Color.White;
            if (light1[1] == 1)for (int i=2*c-1;i<c*(r/2);i+=c)         btn1[i].BackColor = Color.Blue;
            else               for (int i=2*c-1;i<c*(r/2);i+=c)         btn1[i].BackColor = Color.White;
            if (light1[2] == 1)for (int i=(r/2+2)*c-1;i<r*c-1;i+=c)     btn1[i].BackColor = Color.Blue;
            else               for (int i=(r/2+2)*c-1;i<r*c-1;i+=c)     btn1[i].BackColor = Color.White;
            if (light1[3] == 1)for (int i=(r-1)*c+1;i<r*c-1;i++)        btn1[i].BackColor = Color.Blue;
            else               for (int i=(r-1)*c+1;i<r*c-1;i++)        btn1[i].BackColor = Color.White;
            if (light1[4] == 1)for (int i=(r/2+1)*c;i<(r-2)*c+1;i+=c)   btn1[i].BackColor = Color.Blue;
            else               for (int i=(r/2+1)*c;i<(r-2)*c+1;i+=c)   btn1[i].BackColor = Color.White;
            if (light1[5] == 1)for (int i=c;i<(r/2-1)*c+1;i+=c)         btn1[i].BackColor = Color.Blue;
            else               for (int i=c;i<(r/2-1)*c+1;i+=c)         btn1[i].BackColor = Color.White;
            if (light1[6] == 1)for (int i=(r/2)*c+1;i<(r/2+1)*c-1;i++)  btn1[i].BackColor = Color.Blue;
            else               for (int i=(r/2)*c+1;i<(r/2+1)*c-1;i++)  btn1[i].BackColor = Color.White;

            if (light2[0] == 1)for (int i=1;i<c-1;i++)                  btn2[i].BackColor = Color.Blue;
            else               for (int i=1;i<c-1;i++)                  btn2[i].BackColor = Color.White;
            if (light2[1] == 1)for (int i=2*c-1;i<c*(r/2);i+=c)         btn2[i].BackColor = Color.Blue;
            else               for (int i=2*c-1;i<c*(r/2);i+=c)         btn2[i].BackColor = Color.White;
            if (light2[2] == 1)for (int i=(r/2+2)*c-1;i<r*c-1;i+=c)     btn2[i].BackColor = Color.Blue;
            else               for (int i=(r/2+2)*c-1;i<r*c-1;i+=c)     btn2[i].BackColor = Color.White;
            if (light2[3] == 1)for (int i=(r-1)*c+1;i<r*c-1;i++)        btn2[i].BackColor = Color.Blue;
            else               for (int i=(r-1)*c+1;i<r*c-1;i++)        btn2[i].BackColor = Color.White;
            if (light2[4] == 1)for (int i=(r/2+1)*c;i<(r-2)*c+1;i+=c)   btn2[i].BackColor = Color.Blue;
            else               for (int i=(r/2+1)*c;i<(r-2)*c+1;i+=c)   btn2[i].BackColor = Color.White;
            if (light2[5] == 1)for (int i=c;i<(r/2-1)*c+1;i+=c)         btn2[i].BackColor = Color.Blue;
            else               for (int i=c;i<(r/2-1)*c+1;i+=c)         btn2[i].BackColor = Color.White;
            if (light2[6] == 1)for (int i=(r/2)*c+1;i<(r/2+1)*c-1;i++)  btn2[i].BackColor = Color.Blue;
            else               for (int i=(r/2)*c+1;i<(r/2+1)*c-1;i++)  btn2[i].BackColor = Color.White;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            ignite();
        }
    }
}