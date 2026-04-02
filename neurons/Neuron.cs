using neurons.ActivationFunctions;
using System;
using System.Collections.Generic;
using System.Text;

namespace neurons
{
    public class Neuron
    {
        public double[] Weights;
        public double Bias;

        public double Activate(int f, double[] inputs) { 
        
            double sum = Bias;

            for (int i = 0; i < Weights.Length; i++)
            {
                sum += Weights[i] * inputs[i];
            }

            switch (f)
            {
                // 0 = Funzione di attivazione Sigmoide
                case 0:
                    return Sigmoid.Activate(sum);
                default:
                    throw new ArgumentException("Funzione di attivazione non valida");
            }

        }

    }
}
