using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
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

        public string Illustration { get; set; }

        public Bone(string handDirection, string fingerName)
        {
            Illustration = IllustrationOfBone(handDirection, fingerName);
            Broken = false;
            Sprained = false;
            Missing = false;
            Dislocated = false;
        }

        private static string IllustrationOfBone(string handDirection,string fingerName)
        {
            string result;
            switch (handDirection)
            {
                case "left" when fingerName == "Pinky":
                    result = "\\";
                    break;
                case "right" when fingerName == "Pinky":
                case "left" when fingerName == "Thumb":
                    result = "/";
                    break;
                case "right" when fingerName == "Thumb":
                    result = "\\";
                    break;
                default:
                    result = "|";
                    break;
            }
            return result;
        }
    }
}


          
