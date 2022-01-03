using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electriken
{
    public partial class Form1 : Form
    {
        Pet pet;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fbutton.Enabled = false;
            Pbutton.Enabled = false;
            Cbutton.Enabled = false;
            Dbutton.Enabled = false;
            finish.Enabled = false;
            Moneylabel.Text = "0元";
            statuslabel.Text = string.Format("健康：  {0,4}%\n體重：  {0,4}g\n飽足感：{0,4}%\n心情：  {0,4}%",0);
            happenslabel.Text = "請幫寵物取名";
            message.Text = "";
            name.Text = "";
        }

        private void namebutton_Click(object sender, EventArgs e)
        {
            string n;
            if (name.Text.Equals("")) n = "電子雞";
            else n = name.Text;
            pet = new Pet(n);
            namebutton.Enabled = false;
            name.Enabled = false;
            Fbutton.Enabled = true;
            Pbutton.Enabled = true;
            Cbutton.Enabled = true;
            Dbutton.Enabled = true;
            finish.Enabled = true;
            message.Text += string.Format("你開始養了{0}\r\n", pet.name);
            message.Text += string.Format("第{0}天\r\n", pet.days);
            Moneylabel.Text = "100元";
            statuslabel.Text = string.Format("健康：  {0,4}%\n體重：  {1,4}g\n飽足感：{2,4}%\n心情：  {3,4}%", pet.health, pet.weight, pet.satisfaction, pet.kimoji);
            happenslabel.Text = string.Format("{0}出生了",pet.name);
        }

        private void Fbutton_Click(object sender, EventArgs e)
        {
            pet.Feed();
            Moneylabel.Text = string.Format("{0}元", pet.money);
            statuslabel.Text = string.Format("健康：  {0,4}%\n體重：  {1,4}g\n飽足感：{2,4}%\n心情：  {3,4}%", pet.health, pet.weight, pet.satisfaction, pet.kimoji);
            addtext(pet.text);
        }

        private void Pbutton_Click(object sender, EventArgs e)
        {
            pet.Play();
            Moneylabel.Text = string.Format("{0}元", pet.money);
            statuslabel.Text = string.Format("健康：  {0,4}%\n體重：  {1,4}g\n飽足感：{2,4}%\n心情：  {3,4}%", pet.health, pet.weight, pet.satisfaction, pet.kimoji);
            addtext(pet.text);
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            pet.Clean();
            Moneylabel.Text = string.Format("{0}元", pet.money);
            addtext(pet.text);
        }

        private void Dbutton_Click(object sender, EventArgs e)
        {
            pet.Doctor();
            Moneylabel.Text = string.Format("{0}元", pet.money);
            statuslabel.Text = string.Format("健康：  {0,4}%\n體重：  {1,4}g\n飽足感：{2,4}%\n心情：  {3,4}%", pet.health, pet.weight, pet.satisfaction, pet.kimoji);
            addtext(pet.text);
        }

        private void finish_Click(object sender, EventArgs e)
        {
            pet.EndDay();
            Moneylabel.Text = string.Format("{0}元", pet.money);
            statuslabel.Text = string.Format("健康：  {0,4}%\n體重：  {1,4}g\n飽足感：{2,4}%\n心情：  {3,4}%", pet.health, pet.weight, pet.satisfaction, pet.kimoji);
            happenslabel.Text = pet.issue;
            addtext(pet.text);
            if (pet.isdead)
            {
                Fbutton.Enabled = false;
                Pbutton.Enabled = false;
                Cbutton.Enabled = false;
                Dbutton.Enabled = false;
                finish.Enabled = false;
            }
        }

        private void addtext(string str)
        {
            message.Text += str;
            message.SelectionStart = message.Text.Length;
            message.ScrollToCaret();
        }
    }
}
