using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gobang
{
    public partial class Form1 : Form
    {
        Pin[,] board = new Pin[19, 19];
        Character[] Player = new Character[2];
        int[] pinChoose = new int[2];
        string[] p = new string[2];
        int playerswitch = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (P2Worrior.Checked == true)  { P2label.Text = "P2：戰士";    Player[1] = new Worrior(Color.Aqua); }
            if (P2Mage.Checked == true)     { P2label.Text = "P2：法師";    Player[1] = new Mage(Color.DarkBlue); }
            if (P2Archer.Checked == true)   { P2label.Text = "P2：弓箭手";  Player[1] = new Archer(Color.DarkOrange); }
            if (P1Worrior.Checked == true)  { P1label.Text = "P1：戰士";    Player[0] = new Worrior(Color.Gold); }
            if (P1Mage.Checked == true)     { P1label.Text = "P1：法師";    Player[0] = new Mage(Color.BlueViolet); }
            if (P1Archer.Checked == true)   { P1label.Text = "P1：弓箭手";  Player[0] = new Archer(Color.Green); }

            Player[1].numD++;
            p[0] = "P1";
            p[1] = "P2";

            pinChoose[0] = 1;
            pinChoose[1] = 1;

            panel1.Visible = false;
            panel2.Visible = false;
            start.Visible = false;
            panel3.Visible = true;
            panel4.Visible = true;

            P2numB.Text = string.Format("橫向棋子:{0}顆", Player[1].numB);
            P2numC.Text = string.Format("縱向棋子:{0}顆", Player[1].numC);
            P2numD.Text = string.Format("覆蓋棋子:{0}顆", Player[1].numD);
            P1numB.Text = string.Format("橫向棋子:{0}顆", Player[0].numB);
            P1numC.Text = string.Format("縱向棋子:{0}顆", Player[0].numC);
            P1numD.Text = string.Format("覆蓋棋子:{0}顆", Player[0].numD);

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    board[i, j] = new Pin();
                    board[i, j].row = i;
                    board[i, j].col = j;
                    board[i, j].SetBounds(125 + j * 21, 20 + i * 21, 21, 21);
                    board[i, j].Click += button_Click;
                    Controls.Add(board[i, j]);
                }
            }

            if (Player[0].numB == 0) P1numB.Enabled = false;
            if (Player[0].numC == 0) P1numC.Enabled = false;
            if (Player[0].numD == 0) P1numD.Enabled = false;
            P2numA.Enabled = false;
            P2numB.Enabled = false;
            P2numC.Enabled = false;
            P2numD.Enabled = false;
        }

        private void choose_click(object sender, EventArgs e)
        {
            if (playerswitch == 0)
            {
                if (P1numA.Checked == true) pinChoose[0] = 1;
                if (P1numB.Checked == true) pinChoose[0] = 2;
                if (P1numC.Checked == true) pinChoose[0] = 3;
                if (P1numD.Checked == true) pinChoose[0] = 4;
            }
            if (playerswitch == 1)
            {
                if (P2numA.Checked == true) pinChoose[1] = 1;
                if (P2numB.Checked == true) pinChoose[1] = 2;
                if (P2numC.Checked == true) pinChoose[1] = 3;
                if (P2numD.Checked == true) pinChoose[1] = 4;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Pin pin = (Pin)sender;
            bool ch = false;
            int i = pin.row;
            int j = pin.col;
            if (pinChoose[playerswitch] == 1)
            {
                if (board[i, j].BackColor == Control.DefaultBackColor)
                {
                    pin.changeColor(Player[playerswitch]);
                    ch = true;
                    check(i, j);
                }
            }
            else if (pinChoose[playerswitch] == 2)
            {
                if (board[i, j].BackColor == Control.DefaultBackColor)
                {
                    board[i, j].changeColor(Player[playerswitch]);
                    ch = true;
                    Player[playerswitch].numB--;
                    if (j != 18)
                    {
                        if (board[i, j + 1].BackColor == Control.DefaultBackColor)
                        {
                            board[i, j + 1].changeColor(Player[playerswitch]);
                            check(i, j + 1);
                        }
                    }
                    check(i, j);
                }
            }
            else if (pinChoose[playerswitch] == 3)
            {
                if (board[i, j].BackColor == Control.DefaultBackColor)
                {
                    board[i, j].changeColor(Player[playerswitch]);
                    ch = true;
                    Player[playerswitch].numC--;
                    if (i != 18)
                    {
                        if (board[i + 1, j].BackColor == Control.DefaultBackColor)
                        {
                            board[i + 1, j].changeColor(Player[playerswitch]);
                            check(i + 1, j);
                        }
                    }
                    check(i, j);
                }
            }
            else
            {
                pin.changeColor(Player[playerswitch]);
                ch = true;
                Player[playerswitch].numD--;
                check(i, j);
            }

            if (ch)
            {
                if (playerswitch == 0)
                {
                    P1numB.Text = string.Format("橫向棋子:{0}顆", Player[0].numB);
                    P1numC.Text = string.Format("縱向棋子:{0}顆", Player[0].numC);
                    P1numD.Text = string.Format("覆蓋棋子:{0}顆", Player[0].numD);

                    P2numA.Enabled = true;
                    if (Player[1].numB > 0) P2numB.Enabled = true;
                    if (Player[1].numC > 0) P2numC.Enabled = true;
                    if (Player[1].numD > 0) P2numD.Enabled = true;

                    P1numA.Enabled = false;
                    P1numB.Enabled = false;
                    P1numC.Enabled = false;
                    P1numD.Enabled = false;

                    playerswitch = 1;
                    pinChoose[playerswitch] = 1;
                }
                else
                {
                    P2numB.Text = string.Format("橫向棋子:{0}顆", Player[1].numB);
                    P2numC.Text = string.Format("縱向棋子:{0}顆", Player[1].numC);
                    P2numD.Text = string.Format("覆蓋棋子:{0}顆", Player[1].numD);

                    P2numA.Enabled = false;
                    P2numB.Enabled = false;
                    P2numC.Enabled = false;
                    P2numD.Enabled = false;

                    P1numA.Enabled = true;
                    if (Player[0].numB > 0) P1numB.Enabled = true;
                    if (Player[0].numC > 0) P1numC.Enabled = true;
                    if (Player[0].numD > 0) P1numD.Enabled = true;

                    playerswitch = 0;
                    pinChoose[playerswitch] = 1;
                }
            }
        }
        void check(int i, int j)
        {
            Color C = Player[playerswitch].color;
            int lengthP = 1;
            int lengthO = 1;
            int lengthR = 1;
            int lengthN = 1;
            int count = 1;
            while (i + count < 19 && board[i + count, j].BackColor == C)
            {
                count++;
                lengthP++;
            }
            count = 1;
            while (i - count != 0 && board[i - count, j].BackColor == C)
            {
                count++;
                lengthP++;
            }
            count = 1;
            while (j + count < 19 && board[i, j + count].BackColor == C)
            {
                lengthO++;
                count++;
            }
            count = 1;
            while (j - count != 0 && board[i, j - count].BackColor == C)
            {
                lengthO++;
                count++;
            }
            count = 1;
            while (i + count < 19 && j + count < 19 && board[i + count, j + count].BackColor == C)
            {
                lengthR++;
                count++;
            }
            count = 1;
            while (i - count != 0 && j - count != 0 && board[i - count, j - count].BackColor == C)
            {
                lengthR++;
                count++;
            }
            count = 1;
            while (i - count != 0 && j + count < 19 && board[i - count, j + count].BackColor == C)
            {
                lengthN++;
                count++;
            }
            count = 1;
            while (i + count != 0 && j - count < 19 && board[i + count, j - count].BackColor == C)
            {
                lengthN++;
                count++;
            }
            if (lengthP >= 5 || lengthO >= 5 || lengthR >= 5 || lengthN >= 5)
            {
                MessageBox.Show(string.Format("{0}獲勝", p[playerswitch]), "遊戲結束");
                Application.Exit();
            }
        }
    }
}
