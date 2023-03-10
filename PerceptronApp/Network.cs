using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronApp
{
    public class Network
    {
        private double bias;
        private double learning_rate;
        private InputNeuron[]? input_neuron;
        private OutputNeuron output_neuron;

        public Network(int input_neuron_size)
        {
            this.bias = -1;
            this.learning_rate = 1.5;
            this.input_neuron = new InputNeuron[input_neuron_size];
            this.InitializeNeurons();
        }

        public Network(int input_neuron_size, double learning_rate)
        {
            this.bias = -1;
            this.learning_rate = learning_rate;
            this.input_neuron = new InputNeuron[input_neuron_size];
            this.InitializeNeurons();
        }

        public static double GenerateNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2);
        }

        private void InitializeNeurons()
        {
            // Create Input Neurons
            for (int i = 0; i < this.input_neuron.Length; i++)
                this.input_neuron[i] = new InputNeuron(i);
            this.output_neuron = new OutputNeuron(0);
        }

        public void SetInputNeuron(int position, double value)
        {
            this.input_neuron[position].Value = value;
        }

        public void SetOutputNeuron(double value)
        {
            this.output_neuron.Value = value;
        }

        private double UpdateBias(double output)
        {
            return this.bias + (this.learning_rate * output);
        }

        private double Activation()
        {
            double activate = 0;

            for (int i = 0; i < input_neuron?.Length; i++)
                activate += this.input_neuron[i].Value * this.input_neuron[i].Weight;
            activate += this.bias;

            return activate;
        }
        
        private double Threshold()
        {
            if (this.Activation() <= 0)
                return -1;
            return 1;
        }

        public bool Learn()
        {
            double activate = this.Threshold();

            if (activate != this.output_neuron.Value)
            {
                for (int i = 0; i < input_neuron.Length; i++)
                    input_neuron[i].Weight = input_neuron[i].UpdateWeight(this.learning_rate, this.output_neuron.Value);
                this.bias = this.UpdateBias(this.output_neuron.Value);

                return false;
            }
            return true;
        }

        public double Run()
        {
            return this.Threshold();
        }
    }
}
