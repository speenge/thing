using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    public class Bone
    {
        public bool Broken { get; set; }
        public bool Sprained { get; set; }

        public bool Missing { get; set; }
        public bool Dislocated { get; set; }

        public Bone()
        {
            Broken = false;
            Sprained = false;
            Missing = false;
            Dislocated = false;
        }

    }
}
