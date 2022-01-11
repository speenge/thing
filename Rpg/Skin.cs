using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    internal class Skin
    {
        public int Laceration { get; set; }
        public bool Torn { get; set; }

        public Skin()
        {
            Laceration = 0;
            Torn = false;
        }
    }
}
