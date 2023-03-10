namespace PerceptronApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.create_model_btn = new System.Windows.Forms.Button();
            this.learn_btn = new System.Windows.Forms.Button();
            this.logic_gate_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_1_txt = new System.Windows.Forms.TextBox();
            this.input_2_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.output_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.result_btn = new System.Windows.Forms.Button();
            this.learn_rate_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.epoch_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // create_model_btn
            // 
            this.create_model_btn.Location = new System.Drawing.Point(21, 51);
            this.create_model_btn.Name = "create_model_btn";
            this.create_model_btn.Size = new System.Drawing.Size(100, 30);
            this.create_model_btn.TabIndex = 0;
            this.create_model_btn.Text = "Create Model";
            this.create_model_btn.UseVisualStyleBackColor = true;
            this.create_model_btn.Click += new System.EventHandler(this.create_model_btn_Click);
            // 
            // learn_btn
            // 
            this.learn_btn.Enabled = false;
            this.learn_btn.Location = new System.Drawing.Point(22, 145);
            this.learn_btn.Name = "learn_btn";
            this.learn_btn.Size = new System.Drawing.Size(100, 30);
            this.learn_btn.TabIndex = 1;
            this.learn_btn.Text = "Learn";
            this.learn_btn.UseVisualStyleBackColor = true;
            this.learn_btn.Click += new System.EventHandler(this.learn_btn_Click);
            // 
            // logic_gate_box
            // 
            this.logic_gate_box.FormattingEnabled = true;
            this.logic_gate_box.Items.AddRange(new object[] {
            "AND",
            "OR",
            "NOR",
            "NAND"});
            this.logic_gate_box.Location = new System.Drawing.Point(22, 116);
            this.logic_gate_box.Name = "logic_gate_box";
            this.logic_gate_box.Size = new System.Drawing.Size(120, 23);
            this.logic_gate_box.TabIndex = 2;
            this.logic_gate_box.Text = "Logic Gate";
            this.logic_gate_box.SelectedIndexChanged += new System.EventHandler(this.logic_gate_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input 1: ";
            // 
            // input_1_txt
            // 
            this.input_1_txt.Location = new System.Drawing.Point(77, 34);
            this.input_1_txt.Name = "input_1_txt";
            this.input_1_txt.Size = new System.Drawing.Size(100, 23);
            this.input_1_txt.TabIndex = 4;
            // 
            // input_2_txt
            // 
            this.input_2_txt.Location = new System.Drawing.Point(77, 63);
            this.input_2_txt.Name = "input_2_txt";
            this.input_2_txt.Size = new System.Drawing.Size(100, 23);
            this.input_2_txt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input 2: ";
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(77, 92);
            this.output_txt.Name = "output_txt";
            this.output_txt.ReadOnly = true;
            this.output_txt.Size = new System.Drawing.Size(100, 23);
            this.output_txt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output: ";
            // 
            // result_btn
            // 
            this.result_btn.Location = new System.Drawing.Point(21, 121);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(100, 30);
            this.result_btn.TabIndex = 9;
            this.result_btn.Text = "Result";
            this.result_btn.UseVisualStyleBackColor = true;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // learn_rate_txt
            // 
            this.learn_rate_txt.Location = new System.Drawing.Point(113, 22);
            this.learn_rate_txt.Name = "learn_rate_txt";
            this.learn_rate_txt.Size = new System.Drawing.Size(100, 23);
            this.learn_rate_txt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Learning Rate: ";
            // 
            // epoch_txt
            // 
            this.epoch_txt.Location = new System.Drawing.Point(74, 87);
            this.epoch_txt.Name = "epoch_txt";
            this.epoch_txt.Size = new System.Drawing.Size(100, 23);
            this.epoch_txt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Epoch: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.create_model_btn);
            this.groupBox1.Controls.Add(this.epoch_txt);
            this.groupBox1.Controls.Add(this.learn_btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.logic_gate_box);
            this.groupBox1.Controls.Add(this.learn_rate_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 200);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model Creation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.input_1_txt);
            this.groupBox2.Controls.Add(this.result_btn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.output_txt);
            this.groupBox2.Controls.Add(this.input_2_txt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 174);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button create_model_btn;
        private Button learn_btn;
        private ComboBox logic_gate_box;
        private Label label1;
        private TextBox input_1_txt;
        private TextBox input_2_txt;
        private Label label2;
        private TextBox output_txt;
        private Label label3;
        private Button result_btn;
        private TextBox learn_rate_txt;
        private Label label4;
        private TextBox epoch_txt;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}