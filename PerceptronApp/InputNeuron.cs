using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronApp
{
    public class InputNeuron
    {
        private int id;
        private double value;
        private double weight;
        private static Random? rand;

        public int Id { get => id; set => id = value; }
        public double Value { get => value; set => this.value = value; }
        public double Weight { get => weight; set => weight = value; }

        public InputNeuron(int id)
        {
            this.id = id;
            this.value = 0;
            this.weight = 1;
        }

        public double UpdateWeight(double learning_rate, double output, double predicted_output)
        {
            return this.weight + (learning_rate * (output - predicted_output) * this.value);
        }

        public double UpdateWeight(double learning_rate, double output)
        {
            return this.weight + (learning_rate * output * this.value);
        }
    }
}
