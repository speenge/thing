using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Rpg
{
    internal class Hand
    {
        public Dictionary<string, Finger> FingerDictionary = new();
        

        public Hand(Dictionary<string, int> fingerDictionary)
        {
            foreach (var (fingerNameKey, jointsValue) in fingerDictionary)
            {
                FingerDictionary.Add(fingerNameKey, new Finger(fingerNameKey, jointsValue));

            }

        }
    }
}
