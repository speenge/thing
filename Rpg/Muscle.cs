using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Muscle
    {
        public int Damage { get; set; }
        public bool Stretched { get; set; }
        public bool Torn { get; set; }

        public Muscle()
        {
            Damage = 0;
            Stretched = false;
            Torn = false;
        
        }
    }
}
