using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWindowsApp
{
    public class Prediction
    {
        public bool isPositive { get; set; }
        public float PosScore { get; set; }
        public float NegScore { get; set; }
    }
}
