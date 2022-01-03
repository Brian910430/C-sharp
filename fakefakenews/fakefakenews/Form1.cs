using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fakefakenews
{
    public partial class Form1 : Form
    {
        Words content;
        int sequence;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            content = new Words(input.Text);
            changelabel();
            sequence = 1;
            picture.Image = Image.FromFile(@"..\..\Resources\pictures\pic_0" + sequence + ".png");
        }

        private void pre_Click(object sender, EventArgs e)
        {
            if (sequence == 1)
                sequence = 5;
            else
                sequence--;
            picture.Image = Image.FromFile(@"..\..\Resources\pictures\pic_0" + sequence + ".png");
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (sequence == 5)
                sequence = 1;
            else
                sequence++;
            picture.Image = Image.FromFile(@"..\..\Resources\pictures\pic_0" + sequence + ".png");
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            content.words = input.Text;
            changelabel();
        }

        private void family1_CheckedChanged(object sender, EventArgs e)
        {
            content.family = new FontFamily(family1.Text);
            changelabel();
        }

        private void family2_CheckedChanged(object sender, EventArgs e)
        {
            content.family = new FontFamily(family2.Text);
            changelabel();
        }

        private void family3_CheckedChanged(object sender, EventArgs e)
        {
            content.family = new FontFamily(family3.Text);
            changelabel();
        }

        private void topleft_CheckedChanged(object sender, EventArgs e)
        {
            content.isup = true;
            content.alignment = ContentAlignment.BottomLeft;
            changelabel();
        }

        private void topmid_CheckedChanged(object sender, EventArgs e)
        {
            content.isup = true;
            content.alignment = ContentAlignment.BottomCenter;
            changelabel();
        }

        private void topright_CheckedChanged(object sender, EventArgs e)
        {
            content.isup = true;
            content.alignment = ContentAlignment.BottomRight;
            changelabel();
        }

        private void buttleft_CheckedChanged(object sender, EventArgs e)
        {
            content.isup = false;
            content.alignment = ContentAlignment.TopLeft;
            changelabel();
        }

        private void buttmid_CheckedChanged(object sender, EventArgs e)
        {
            content.isup = false;
            content.alignment = ContentAlignment.TopCenter;
            changelabel();
        }

        private void buttright_CheckedChanged(object sender, EventArgs e)
        {
            content.isup = false;
            content.alignment = ContentAlignment.TopRight;
            changelabel();
        }

        private void textsize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                content.size = int.Parse(textsize.Text);
            }
            catch
            {
                content.size = 12;
            }
            if (content.size > 32 || content.size < 1)
                content.size = 12;
            changelabel();
        }
        
        private void bold_Click(object sender, EventArgs e)
        {
            if (bold.Checked)
            {
                if (incline.Checked)    content.style = FontStyle.Bold | FontStyle.Italic;
                else                    content.style = FontStyle.Bold;
            }
            else
            {
                if (incline.Checked)    content.style = FontStyle.Italic;
                else                    content.style = FontStyle.Regular;
            }
            changelabel();
        }

        private void incline_Click(object sender, EventArgs e)
        {
            if (incline.Checked)
            {
                if (bold.Checked)   content.style = FontStyle.Bold | FontStyle.Italic;
                else                content.style = FontStyle.Italic;
            }
            else
            {
                if (bold.Checked)   content.style = FontStyle.Bold;
                else                content.style = FontStyle.Regular;
            }
            changelabel();
        }

        public void changelabel()
        {
            content.change();
            if (content.isup)
            {
                down.Text = "";
                up.Font = content.font;
                up.Text = content.words;
                up.TextAlign = content.alignment;
            }
            else
            {
                up.Text = "";
                down.Font = content.font;
                down.Text = content.words;
                down.TextAlign = content.alignment;
            }
        }

    }
}
