namespace PerceptronApp
{
    public partial class Form1 : Form
    {
        double[][] x;
        double[] y;
        Network perceptron;

        public Form1()
        {
            InitializeComponent();
            x = new double[][]
            {
                new double[] { 1, 1, -1, -1 },
                new double[] { 1, -1, 1, -1 }
            };
        }

        private void create_model_btn_Click(object sender, EventArgs e)
        {
            if(learn_rate_txt.Text == "")
                perceptron = new Network(2);
            else
                perceptron = new Network(2, Convert.ToDouble(learn_rate_txt.Text));
        }

        private void logic_gate_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            // AND Logic Gate
            if (logic_gate_box.SelectedIndex == 0)
                y = new double[] { 1, -1, -1, -1 };
            // OR Logic Gate
            if (logic_gate_box.SelectedIndex == 1)
                y = new double[] { 1, 1, 1, -1 };
            // NOR Logic Gate
            if (logic_gate_box.SelectedIndex == 2)
                y = new double[] { -1, -1, -1, 1 };
            // NAND Logic Gate
            if (logic_gate_box.SelectedIndex == 3)
                y = new double[] { -1, 1, 1, 1 };

            learn_btn.Enabled = true;
        }

        private void learn_btn_Click(object sender, EventArgs e)
        {
            int epoch = 1;
            if (epoch_txt.Text != "")
            {
                epoch = Convert.ToInt32(epoch_txt.Text);
                for(int i = 0; i < epoch; i++)
                {
                    for(int a = 0; a < 4; a++)
                    {
                        perceptron.SetInputNeuron(0, x[0][a]);
                        perceptron.SetInputNeuron(1, x[1][a]);
                        perceptron.SetOutputNeuron(y[a]);
                        perceptron.Learn();
                    }
                }
            }
        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(input_1_txt.Text);
            double input2 = Convert.ToDouble(input_2_txt.Text);

            perceptron.SetInputNeuron(0, input1);
            perceptron.SetInputNeuron(1, input2);
            output_txt.Text = perceptron.Run().ToString();
        }
    }
}