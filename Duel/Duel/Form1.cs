using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Duel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string filename = @"..\..\bin\debug\card.map";
        StreamReader sr = new StreamReader(filename);
        Card[,] cards;
        Card[] chosen = new Card[2];
        string[] player = new string[2];
        int miss = 0;
        int col, row;
        int round = 1;
        int playerSwitch = 0;
        int[] playerScore = new int[2];
        int count = -1;
        bool islarge = false;

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer2.Interval = 2000;
            start.Visible = false;
            P1.Visible = true;
            P2.Visible = true;
            player[0] = "P1";
            player[1] = "P2";
            roundlabel.Visible = true;
            playerScore[0] = 0;
            playerScore[1] = 0;
            string[] l = sr.ReadLine().Split(' ');
            row = int.Parse(l[0]);
            col = int.Parse(l[1]);
            int a = 280 / col;
            int b = 280 / row;
            cards = new Card[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] w = sr.ReadLine().Split(' ');
                for (int j = 0; j < col; j++)
                {
                    int n = int.Parse(w[j]);
                    cards[i, j] = new Card(n);
                    cards[i, j].SetBounds(150 + a * i, 60 + b * j, a, b);
                    cards[i, j].Enabled = false;
                    Controls.Add(cards[i, j]);
                    cards[i, j].Click += button_Click;
                }
            }
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Card C in cards)
            {
                C.Enabled = true;
                C.hideNumber();
            }
            timer1.Enabled = false;
        }

        private void button_Click(object sender, EventArgs e)
        {
            count++;
            Card card = (Card)sender;
            chosen[count] = card;
            card.revealNumber();

            if (count == 1)
            {
                count = -1;
                if (int.Parse(chosen[0].Text) > int.Parse(chosen[1].Text))
                    islarge = false;
                else islarge = true;
                foreach (Card C in cards)
                    C.Enabled = false;
                chosen[0].Enabled = true;
                chosen[1].Enabled = true;
                timer2.Enabled = true;
            }
            else
            {
                if (playerSwitch == 0) playerSwitch = 1;
                else playerSwitch = 0;
            }
            roundlabel.Text = string.Format("第{0}回合 輪到{1}", round, player[playerSwitch]);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (islarge)
            {
                playerScore[round % 2] += (int.Parse(chosen[1].Text) - int.Parse(chosen[0].Text));
                miss += 2;
                Controls.Remove(chosen[0]);
                Controls.Remove(chosen[1]);
            }
            else
            { 
                chosen[0].hideNumber();
                chosen[1].hideNumber();
            }
            foreach (Card C in cards)
            {
                C.Enabled = true;
            }
            P1.Text = string.Format("P1：{0}分", playerScore[0]);
            P2.Text = string.Format("P2：{0}分", playerScore[1]);
            round++;
            roundlabel.Text = string.Format("第{0}回合 輪到{1}", round, player[playerSwitch]);
            timer2.Enabled = false;

            if (miss == col * row / 2)
            {
                if (playerScore[0] > playerScore[1])
                {
                    MessageBox.Show("P1獲勝", "遊戲結束");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("P2獲勝", "遊戲結束");
                    Application.Exit();
                }
            }
        }
    }
}
