using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Xml;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"\  |||
 \ |||
  \||| /
      /");
            Console.WriteLine("\n\n");
            //var lhand = new Hand(false);
            //var rhand = new Hand(true);

            //lhand.PrintHand();
            //Console.WriteLine(lhand.Fingers.BMiddleBase.Missing);

            //lhand.Fingers.BMiddleMid.Missing = true;
            //lhand.Fingers.BMiddleTip.Missing = true;
            //Console.WriteLine("\n\n");
            //lhand.PrintHand();
            //rhand.PrintHand();
            Dictionary<string, int> fingers = new();
            fingers.Add("Pinky", 3);
            fingers.Add("Ring", 3);
            fingers.Add("Middle", 3);
            fingers.Add("Index", 3);
            fingers.Add("Thumb", 2);
            var hand = new Hand(fingers);
            var drawHand = "";
            string[] fingerArr = {"Pinky", "Ring", "Middle", "Index", "Thumb"};
            string part = "\\";
            for (int i = 0; i < hand.FingerDictionary.Keys.Count; i++)
            {
                if (i+1 % fingers.Count-1 == 0) part = "\\";
                else if (i + 1 % fingers.Count-1 == fingers.Count-1) part = "/";
                else part = "|";

                    hand.FingerDictionary.TryGetValue(fingerArr[i], out var val);
                for (int j = 0; j < val.Bones.Count; j++)
                {
                    drawHand += val.Bones[j].Missing ? "" : part;
                }

                drawHand += "\n";
            }

            Console.WriteLine(drawHand);
        }

    }
}
