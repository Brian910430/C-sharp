using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electriken
{
    class Pet
    {
        public string name;
        public int money;
        public int days;
        public int health;
        public int weight;
        public int satisfaction;
        public int kimoji;
        public bool isdirty;
        public bool issick;
        public bool isdead;
        public string text;
        public string issue;
        Random ran = new Random();

        public Pet(string name)
        {
            this.name = name;
            days = 1;
            money = 100;
            health = 70;
            weight = 700;
            satisfaction = 70;
            kimoji = 50;
            isdirty = false;
            issick = false;
            isdead = false;
        }

        public void Feed()
        {
            if (money >= 10)
            {
                money -= 10;
                int a = ran.Next(20);
                if (satisfaction + a <= 100) satisfaction += a;
                else satisfaction = 100;

                int b = ran.Next(50, 100);
                if (weight + b <= 4000) weight += b;
                else weight = 4000;

                if (isdirty)
                {
                    if (health >= 10) health -= 10;
                    else health = 0;
                }
                text = string.Format("餵食了{0}\r\n", name);
            }
            else
            {
                text = "金錢不足無法餵食\r\n";
            }
        }

        public void Play()
        {
            if (money >= 5)
            {
                money -= 5;
                int a = ran.Next(20);
                if (health + a <= 100) health += a;
                else health = 100;

                int b = ran.Next(20);
                if (kimoji + b <= 100) kimoji += b;
                else kimoji = 100;

                int c = ran.Next(20);
                if (satisfaction - c >= 0) satisfaction -= c;
                else satisfaction = 0;
                text = string.Format("與{0}玩耍了\r\n", name);
            }
            else
            {
                text = "金錢不足無法玩耍\r\n";
            }
        }

        public void Clean()
        {
            if (money >= 5)
            {
                money -= 5;
                isdirty = false;
                text = string.Format("清掃了{0}\r\n", name);
            }
            else
            {
                text = "金錢不足無法清掃\r\n";
            }
        }

        public void Doctor()
        {
            if (money >= 20)
            {
                money -= 20;
                if (health <= 70) health += 30;
                else health = 100;
                if (kimoji >= 20) kimoji -= 20;
                else kimoji = 0;
                issick = false;
                text = string.Format("帶{0}去看醫生\r\n", name);
            }
            else
            {
                text = "金錢不足無法看醫生\r\n";
            }
        }

        public void EndDay()
        {
            bool egg = false;
            int earn = 0;
            days++;
            issue = "";
            text = string.Format("\r\n第{0}天\r\n", days);

            if (satisfaction >= 20) satisfaction -= 20;
            else if (satisfaction != 0) satisfaction = 0;
            else if (weight >= 800) weight -= 200;
            else weight = 600;

            if (days > 10)
            {
                if (health >= 10) health -= 10;
                else health = 0;
            }

            if (satisfaction >= 50)
                isdirty = true;

            if (health <= 50 && kimoji <= 50 && ran.Next(1, 100) > health)
                issick = true;

            if (weight > 1000 && health > 60 && ran.Next(1, 100) <= kimoji)
            {
                if (health >= 5) health -= 5;
                else health = 0;
                earn = ran.Next(15, 25);
                money += earn;
                egg = true;
            }

            if (health < 10 && weight < 1000 && ran.Next(1, 100) > kimoji)
                isdead = true;

            if (isdead)
            {
                text += string.Format("{0}死掉了，遊戲結束", name);
                issue = string.Format("{0}死掉了", name);
            }
            else
            {
                if (isdirty)
                {
                    if (health >= 30) health -= 30;
                    else health = 0;
                    text += string.Format("{0}大便了\r\n", name);
                    issue += string.Format("{0}大便了  ", name);
                }

                if (issick)
                {
                    if (weight >= 750) weight -= 150;
                    else weight = 600;

                    if (kimoji >= 20) kimoji -= 20;
                    else kimoji = 0;

                    text += string.Format("{0}生病了\r\n", name);
                    issue += string.Format("{0}生病了  ", name);
                }

                if (egg)
                {
                    text += string.Format("{0}下蛋了，賣出獲得{1}元\r\n", name, earn);
                    issue += string.Format("{0}今天很乖喔", name);
                }

                if (!issick && !isdirty && !egg)
                {
                    text += string.Format("一天又平安地過去了\r\n");
                    issue += string.Format("{0}今天很乖喔", name);
                }
            }
        }
    }
}
