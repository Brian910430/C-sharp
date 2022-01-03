using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_
{
    public partial class Form1 : Form
    {
        MusicPlayer player = new MusicPlayer();
        RadioButton[] songlist = new RadioButton[10];
        bool notFirst = false;
        Color color;
        Font font;
        Form Form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void selectbt_Click(object sender, EventArgs e)
        {
            if (notFirst)
            {
                foreach (RadioButton rb in songlist)
                {
                    if (rb != null)
                        playlistgp.Controls.Remove(rb);
                }
            }
            int i = 0;
            player.SelectFiles();
            if (player.playlist == null)
                return;
            foreach (string s in player.playlist)
            {
                if (s.Length != 0)
                {
                    songlist[i] = new RadioButton();
                    songlist[i].Text = s;
                    songlist[i].Location = new Point(10, 20 + 50 * i);
                    songlist[i].AutoSize = true;
                    songlist[i].AutoCheck = true;
                    songlist[i].CheckedChanged += rb_CheckChanged;
                    playlistgp.Controls.Add(songlist[i]);
                    i++;
                }
            }
            if (notFirst)
            {
                ChangeFont();
            }
            notFirst = true;
        }

        private void rb_CheckChanged(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void playbt_Click(object sender, EventArgs e)
        {
            string song = "";
            foreach (RadioButton rb in songlist)
            {
                if (rb != null)
                {
                    if (rb.Checked)
                        song = rb.Text;
                }
            }
            if (song != "")
            {
                if (player.loop)
                {
                    player.PlayLoop(song);
                    Form2.Show();
                }
                else
                {
                    player.PlaySong(song);
                }
            }
        }

        private void stopbt_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void loopch_CheckedChanged(object sender, EventArgs e)
        {
            if (loopch.Checked) player.loop = true;
            else player.loop = false;
        }

        private void coloritem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
            ChangeFont();
        }

        private void fontitem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                font = fontDialog1.Font;
            }
            ChangeFont();
        }

        void ChangeFont()
        {
            foreach (RadioButton rb in songlist)
            {
                if (rb != null)
                {
                    rb.ForeColor = color;
                    rb.Font = font;
                }
            }
        }

        private void saveitem_Click(object sender, EventArgs e)
        {
            player.SaveList();
        }

        private void loaditem_Click(object sender, EventArgs e)
        {
            player.LoadList();
            int i = 0;
            if (notFirst)
            {
                foreach (RadioButton rb in songlist)
                {
                    if (rb != null)
                        playlistgp.Controls.Remove(rb);
                }
            }
            foreach (string s in player.playlist)
            {
                if (s.Length != 0)
                {
                    songlist[i] = new RadioButton();
                    songlist[i].Text = s;
                    songlist[i].Location = new Point(10, 20 + 50 * i);
                    songlist[i].AutoSize = true;
                    songlist[i].AutoCheck = true;
                    songlist[i].CheckedChanged += rb_CheckChanged;
                    playlistgp.Controls.Add(songlist[i]);
                    i++;
                }
            }
            notFirst = true;
        }
    }
}