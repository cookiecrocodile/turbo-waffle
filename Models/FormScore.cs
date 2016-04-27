using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class FormScore
    {
        public int ScoreA { get; set; }
        public int ScoreB { get; set; }

        public int ScoreC { get; set; }


        public override string ToString()
        {
            string result = "A: " + ScoreA + "\nB: " + ScoreB + "\nC: " + ScoreC;
            return result;
        }
    }
}