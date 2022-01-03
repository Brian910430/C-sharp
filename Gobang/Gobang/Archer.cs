using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Gobang
{
    class Archer : Character
    {
        public Archer(Color c)
        {
            numA = 361;
            numB = 1;
            numC = 1;
            numD = 3;
            color = c;
        }
    }
}
