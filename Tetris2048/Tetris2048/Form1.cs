using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris2048
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[4, 6];
        int Q = 5, W = 5, E = 5, R = 5;
        int point = 0, next = 0;
        int second = 3;
        bool gamestart = false;
        bool iseasy = true;
        Random ran = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gamestart)
            {
                if (iseasy)
                {
                    if (e.KeyCode == Keys.A) next = 2;
                    else if (e.KeyCode == Keys.S) next = 4;
                    else if (e.KeyCode == Keys.D) next = 8;
                }
                if (e.KeyCode == Keys.Q)
                {
                    putblock(0, Q);
                    int temp = ran.Next(1, 4);
                    switch (temp)
                    {
                        case 1:
                            next = 2;
                            break;
                        case 2:
                            next = 4;
                            break;
                        case 3:
                            next = 8;
                            break;
                    }
                    Q--;
                    if (!iseasy)
                    {
                        timer1.Enabled = false;
                        timer1.Enabled = true;
                        timer2.Enabled = false;
                        timer2.Enabled = true;
                        second = 3;
                        countdown.Text = "倒數計時：" + second;
                    }
                }
                else if (e.KeyCode == Keys.W)
                {
                    putblock(1, W);
                    int temp = ran.Next(1, 4);
                    switch (temp)
                    {
                        case 1:
                            next = 2;
                            break;
                        case 2:
                            next = 4;
                            break;
                        case 3:
                            next = 8;
                            break;
                    }
                    W--;
                    if (!iseasy)
                    {
                        timer1.Enabled = false;
                        timer1.Enabled = true;
                        timer2.Enabled = false;
                        timer2.Enabled = true;
                        second = 3;
                        countdown.Text = "倒數計時：" + second;
                    }
                }
                else if (e.KeyCode == Keys.E)
                {
                    putblock(2, E);
                    int temp = ran.Next(1, 4);
                    switch (temp)
                    {
                        case 1:
                            next = 2;
                            break;
                        case 2:
                            next = 4;
                            break;
                        case 3:
                                next = 8;
                                break;
                    }
                    E--;
                    if (!iseasy)
                    {
                        timer1.Enabled = false;
                        timer1.Enabled = true;
                        timer2.Enabled = false;
                        timer2.Enabled = true;
                        second = 3;
                        countdown.Text = "倒數計時：" + second;
                    }
                }
                else if (e.KeyCode == Keys.R)
                {
                    putblock(3, R);
                    int temp = ran.Next(1, 4);
                    switch (temp)
                    {
                        case 1:
                            next = 2;
                            break;
                        case 2:
                            next = 4;
                            break;
                        case 3:
                            next = 8;
                            break;
                    }
                    R--;
                    if (!iseasy)
                    {
                        timer1.Enabled = false;
                        timer1.Enabled = true;
                        timer2.Enabled = false;
                        timer2.Enabled = true;
                        second = 3;
                        countdown.Text = "倒數計時：" + second;
                    }
                }
                nextint.Text = "當前數字：" + next;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            easybutton.Visible = true;
            hardbutton.Visible = true;
            score.Visible = false;
            nextint.Visible = false;
            countdown.Visible = false;
            timer1.Interval = 3000;
            timer2.Interval = 1000;

            int temp = ran.Next(1, 4);
            switch (temp)
            {
                case 1:
                    next = 2;
                    break;
                case 2:
                    next = 4;
                    break;
                case 3:
                    next = 8;
                    break;
            }
            score.Text += point;
            nextint.Text += next;
            countdown.Text += second;

            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].SetBounds(50 + 65 * i, 40 + 45 * j, 40, 40);
                    Controls.Add(btn[i, j]);
                    btn[i, j].Visible = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            putblock(1, W);
            int temp = ran.Next(1, 4);
            switch (temp)
            {
                case 1:
                    next = 2;
                    break;
                case 2:
                    next = 4;
                    break;
                case 3:
                    next = 8;
                    break;
            }
            nextint.Text = "當前數字：" + next;
            W--;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            second--;
            countdown.Text = "倒數計時：" + second;
            if (second == 1) second = 4;
        }

        private void easybutton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false;
            hardbutton.Visible = false;
            score.Visible = true;
            nextint.Visible = true;
            gamestart = true;
            iseasy = true;
        }

        private void hardbutton_Click(object sender, EventArgs e)
        {
            easybutton.Visible = false;
            hardbutton.Visible = false;
            score.Visible = true;
            nextint.Visible = true;
            countdown.Visible = true;
            gamestart = true;
            iseasy = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        void putblock(int col, int row)
        {
            btn[col, row].Text = "" + next;
            btn[col, row].Visible = true;
            judge(col, row);
        }

        void judge(int col, int row)
        {
            int[] A = new int[4];

            for (int i = 0; i < 4; i++)
                A[i] = 1 + i * 2;
            
            if (row != 5)
            {
                if (btn[col, row].Text == btn[col, row + 1].Text)
                {
                    btn[col, row + 1].Text = "" + int.Parse(btn[col, row + 1].Text) * 2;
                    for (int i = row; i > 0; i--)
                        btn[col, i].Text = btn[col, i - 1].Text;
                    btn[col, 0].Text = "";
                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 6; j++)
                            if (btn[i, j].Text == "")
                                btn[i, j].Visible = false;
                    switch (col)
                    {
                        case 0:
                            Q++;
                            break;
                        case 1:
                            W++;
                            break;
                        case 2:
                            E++;
                            break;
                        case 3:
                            R++;
                            break;
                    }
                    judge(col, row + 1);
                }
            }

            for (int i = 0; i < 4; i++)
                if (btn[i, row].Text != "")
                    A[i] = int.Parse(btn[i, row].Text);

            if (A[0] == A[1] && A[1] == A[2] && A[2] == A[3])
            {
                point += int.Parse(btn[0, row].Text) * int.Parse(btn[0, row].Text);
                Q++;W++;E++;R++;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = row; j > 0; j--)
                    {
                        btn[i, j].Text = btn[i, j - 1].Text;
                        btn[i, 0].Text = "";
                        if (btn[i, j].Text == "")
                            btn[i, j].Visible = false;
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (btn[i, row].Text != "")
                        judge(i, row);
                }
            }

            score.Text = "你的分數：" + point;

            for (int i = 0; i < 4; i++)
            {
                if (btn[i, 0].Visible == true)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    MessageBox.Show("遊戲結束!!!\r\n" + score.Text, "", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
        }
    }
}
