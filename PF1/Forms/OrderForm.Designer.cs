namespace PF1
{
    partial class OrderForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nvegBox = new System.Windows.Forms.TextBox();
            this.pvegBox = new System.Windows.Forms.TextBox();
            this.pbreadBox = new System.Windows.Forms.TextBox();
            this.nbreadBox = new System.Windows.Forms.TextBox();
            this.psodaBox = new System.Windows.Forms.TextBox();
            this.nsodaBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Place  Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(254, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store Info.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Store ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Store Name:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(304, 109);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(100, 23);
            this.idBox.TabIndex = 4;
            this.idBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(304, 161);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(100, 23);
            this.nameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vegetables:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bread:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sodas:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F);
            this.label8.Location = new System.Drawing.Point(254, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Products";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Price";
            // 
            // nvegBox
            // 
            this.nvegBox.Location = new System.Drawing.Point(252, 294);
            this.nvegBox.Name = "nvegBox";
            this.nvegBox.Size = new System.Drawing.Size(79, 23);
            this.nvegBox.TabIndex = 13;
            this.nvegBox.TextChanged += new System.EventHandler(this.nvegBox_TextChanged);
            // 
            // pvegBox
            // 
            this.pvegBox.Location = new System.Drawing.Point(367, 294);
            this.pvegBox.Name = "pvegBox";
            this.pvegBox.Size = new System.Drawing.Size(86, 23);
            this.pvegBox.TabIndex = 14;
            // 
            // pbreadBox
            // 
            this.pbreadBox.Location = new System.Drawing.Point(367, 341);
            this.pbreadBox.Name = "pbreadBox";
            this.pbreadBox.Size = new System.Drawing.Size(86, 23);
            this.pbreadBox.TabIndex = 16;
            // 
            // nbreadBox
            // 
            this.nbreadBox.Location = new System.Drawing.Point(252, 341);
            this.nbreadBox.Name = "nbreadBox";
            this.nbreadBox.Size = new System.Drawing.Size(79, 23);
            this.nbreadBox.TabIndex = 15;
            // 
            // psodaBox
            // 
            this.psodaBox.Location = new System.Drawing.Point(367, 389);
            this.psodaBox.Name = "psodaBox";
            this.psodaBox.Size = new System.Drawing.Size(86, 23);
            this.psodaBox.TabIndex = 18;
            // 
            // nsodaBox
            // 
            this.nsodaBox.Location = new System.Drawing.Point(252, 389);
            this.nsodaBox.Name = "nsodaBox";
            this.nsodaBox.Size = new System.Drawing.Size(79, 23);
            this.nsodaBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(390, 454);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Invalid data!";
            this.label10.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(626, 511);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.psodaBox);
            this.Controls.Add(this.nsodaBox);
            this.Controls.Add(this.pbreadBox);
            this.Controls.Add(this.nbreadBox);
            this.Controls.Add(this.pvegBox);
            this.Controls.Add(this.nvegBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.Name = "OrderForm";
            this.Text = "New Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox nvegBox;
        private System.Windows.Forms.TextBox pvegBox;
        private System.Windows.Forms.TextBox pbreadBox;
        private System.Windows.Forms.TextBox nbreadBox;
        private System.Windows.Forms.TextBox psodaBox;
        private System.Windows.Forms.TextBox nsodaBox;
        private System.Windows.Forms.Label label10;
    }
}