using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secretcode
{
    public partial class Form1 : Form
    {
        theTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new theTable();
            trans.Text = table.Random();
            YesorNo.Text = table.Confirm(trans.Text);
            message.Text += table.message;
            translatetable.Visible = true;
            encrypttable.Visible = false;
            decrypttable.Visible = false;
            historytable.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            translatetable.Visible = true;
            encrypttable.Visible = false;
            decrypttable.Visible = false;
            historytable.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            translatetable.Visible = false;
            encrypttable.Visible = true;
            decrypttable.Visible = false;
            historytable.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            translatetable.Visible = false;
            encrypttable.Visible = false;
            decrypttable.Visible = true;
            historytable.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            translatetable.Visible = false;
            encrypttable.Visible = false;
            decrypttable.Visible = false;
            historytable.Visible = true;
            message.SelectionStart = message.Text.Length;
            message.ScrollToCaret();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trans.Text = table.Random();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YesorNo.Text = table.Confirm(trans.Text);
            if(table.ch)
                message.Text += table.message;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            output1.Text = table.Encrypt(input1.Text);
            message.Text += table.message;
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            output2.Text = table.Decrypt(input2.Text);
            message.Text += table.message;
        }
    }
}
