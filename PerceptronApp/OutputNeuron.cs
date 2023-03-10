using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronApp
{
    public class OutputNeuron
    {
        private int id;
        private double value;

        public int Id { get => id; set => id = value; }
        public double Value { get => value; set => this.value = value; }

        public OutputNeuron(int id)
        {
            this.id = id;
            this.value = 0;
        }
    }
}
