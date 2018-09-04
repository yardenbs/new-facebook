using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookWindowsApp
{
    public class Prediction
    {
        public bool isPositive { get; set; }
        public double PosScore { get; set; }
        public double NegScore { get; set; }
    }
}
