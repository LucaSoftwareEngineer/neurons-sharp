using System;
using System.Collections.Generic;
using System.Text;

namespace neurons.ActivationFunctions
{
    public class Sigmoid
    {
        public static double Activate(double sum)
        {
            return 1.0 / (1.0 + Math.Exp(-sum));
        }

        public static double Derivative(double sigmoidOutput)
        {
            return sigmoidOutput * (1.0 - sigmoidOutput);
        }
    }
}
