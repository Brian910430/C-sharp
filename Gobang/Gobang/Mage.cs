using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gobang
{
    class Mage : Character
    {
        public Mage(Color c)
        {
            numA = 361;
            numB = 1;
            numC = 2;
            numD = 2;
            color = c;
        }
    }
}
