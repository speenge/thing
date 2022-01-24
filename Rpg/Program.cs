using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
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
            Dictionary<string, int> fingers = new()
            {
                {"Pinky", 3},
                {"Ring", 3},
                {"Middle", 3},
                {"Index", 3},
                {"Thumb", 2}
            };
            var hand = new Hand(fingers, "right");
           
            
            DrawHand(fingers, hand);
            Console.ReadLine();
        }

        private static void DrawHand(Dictionary<string, int> fingers, Hand hand)
        {
           for (var i = GetBiggest(fingers); i >= 0; i--)
           {
               Console.WriteLine(DrawJoints(fingers, hand, i));
           }
        }

        private static int GetBiggest(Dictionary<string, int> fingers)
        {
            var biggest = 0;
            foreach (var (key, value) in fingers)
            {
                if (value > biggest)
                {
                    biggest = value;
                }
            }
            return biggest;
        }

        private static string DrawJoints(Dictionary<string, int> fingers, Hand hand,int joint)
        {
            string output = null;
            for (var i = 0; i < fingers.Count; i++)
            { 
                hand.FingerDictionary.TryGetValue(fingers.ElementAt(i).Key, out var result);
               if (result is {FingerName: "Pinky"})
               {
                   if (joint >= result.Bones.Count) continue;
                   var sb = new StringBuilder(AddSpaces(result.Bones.Count));
                   output += sb.Insert(sb.Length - joint, result.Bones[joint].Illustration).ToString();
               }else if (result is { FingerName: "Thumb" })
               {
                   if (joint >= result.Bones.Count) continue;
                   var sb = new StringBuilder(AddSpaces(result.Bones.Count));
                   output += new string(sb.Insert(sb.Length - joint, result.Bones[joint].Illustration).ToString().Reverse().ToArray());
                }else if (result != null && joint < result.Bones.Count) output += result.Bones[joint].Illustration;
            }
            return output;
        }

        private static string AddSpaces(int joints)
        {
            string result = null;
            for (var i = 0; i < joints; i++)
            {
                result += " ";
            }

            return result;
        }
      /*  private static string DrawHand(Hand hand, ICollection fingers)
        {
            var drawHand = "";
            string[] fingerArr = {"Pinky", "Ring", "Middle", "Index", "Thumb"};
            for (var i = 0; i < hand.FingerDictionary.Keys.Count; i++)
            {
                var part = "\\";
                if (i + 1 % fingers.Count - 1 == 0) part = "\\";
                else if (i + 1 % fingers.Count - 1 == fingers.Count - 1) part = "/";
                else part = "|";

                hand.FingerDictionary.TryGetValue(fingerArr[i], out var val);
                for (var j = 0; j < val.Bones.Count; j++)
                {
                    drawHand += val.Bones[j].Missing ? "" : part;
                }

                drawHand += "\n";
            }

            return drawHand;
        }*/
    }
}
