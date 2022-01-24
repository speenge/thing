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
        public string HandDirection { get; set; }

        public Hand(Dictionary<string, int> fingerDictionary, string handDirection)
        {
            HandDirection = handDirection;
            foreach (var (fingerNameKey, jointsValue) in fingerDictionary)
            {
                FingerDictionary.Add(fingerNameKey,
                    fingerNameKey is "Pinky" or "Thumb"
                        ? new Finger(fingerNameKey, jointsValue, handDirection)
                        : new Finger(fingerNameKey, jointsValue, handDirection));
            }
        }
    }
}
