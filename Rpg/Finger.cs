using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg
{
    class Finger
    {
        public List<Bone> Bones = new ();
        public string FingerName;

        public Finger(string fingerName, int joints)
        {
            for (var i = 0; i < joints; i++)
            {
                Bones.Add(new Bone());
            }

            FingerName = fingerName;
        }
    }
}
