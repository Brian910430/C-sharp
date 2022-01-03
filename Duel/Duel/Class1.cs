using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel
{
    class Card : System.Windows.Forms.Button
    {
        public int number;

        public Card(int a)
        {
            number = a;
            Text = number + "";
        }

        public void hideNumber()
        {
            Text = "";
        }

        public void revealNumber()
        {
            Text = number + "";
        }
    }
}
