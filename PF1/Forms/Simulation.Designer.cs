namespace PF1
{
    partial class Simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vegetablecount = new System.Windows.Forms.NumericUpDown();
            this.breadcount = new System.Windows.Forms.NumericUpDown();
            this.sodacount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vegetablecount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sodacount)).BeginInit();
            this.SuspendLayout();
            // 
            // vegetablecount
            // 
            this.vegetablecount.Location = new System.Drawing.Point(204, 144);
            this.vegetablecount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.vegetablecount.Name = "vegetablecount";
            this.vegetablecount.ReadOnly = true;
            this.vegetablecount.Size = new System.Drawing.Size(120, 23);
            this.vegetablecount.TabIndex = 0;
            this.vegetablecount.ValueChanged += new System.EventHandler(this.vegetablecount_ValueChanged);
            // 
            // breadcount
            // 
            this.breadcount.Location = new System.Drawing.Point(204, 274);
            this.breadcount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.breadcount.Name = "breadcount";
            this.breadcount.ReadOnly = true;
            this.breadcount.Size = new System.Drawing.Size(120, 23);
            this.breadcount.TabIndex = 1;
            this.breadcount.ValueChanged += new System.EventHandler(this.breadcount_ValueChanged);
            // 
            // sodacount
            // 
            this.sodacount.Location = new System.Drawing.Point(204, 209);
            this.sodacount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sodacount.Name = "sodacount";
            this.sodacount.ReadOnly = true;
            this.sodacount.Size = new System.Drawing.Size(120, 23);
            this.sodacount.TabIndex = 2;
            this.sodacount.ValueChanged += new System.EventHandler(this.sodacount_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(466, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Deliver the next day";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vegetable Trucks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bread Trucks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soda Trucks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last simulation results";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(413, 150);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(164, 129);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of trucks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 15F);
            this.label6.Location = new System.Drawing.Point(167, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Simulation of Route";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(34, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "Show Logs";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(615, 411);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sodacount);
            this.Controls.Add(this.breadcount);
            this.Controls.Add(this.vegetablecount);
            this.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.Name = "Simulation";
            this.Text = "Simulation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Simulation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.vegetablecount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breadcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sodacount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown vegetablecount;
        private System.Windows.Forms.NumericUpDown breadcount;
        private System.Windows.Forms.NumericUpDown sodacount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}