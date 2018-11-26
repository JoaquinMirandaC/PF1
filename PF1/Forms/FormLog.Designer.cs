namespace PF1
{
    partial class FormLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ( )
        {
            this.NumericTxt = new System.Windows.Forms.NumericUpDown();
            this.NumericDataGrid = new System.Windows.Forms.NumericUpDown();
            this.NumericTextBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericTxt
            // 
            this.NumericTxt.Location = new System.Drawing.Point(191, 25);
            this.NumericTxt.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumericTxt.Name = "NumericTxt";
            this.NumericTxt.Size = new System.Drawing.Size(80, 23);
            this.NumericTxt.TabIndex = 0;
            // 
            // NumericDataGrid
            // 
            this.NumericDataGrid.Location = new System.Drawing.Point(191, 53);
            this.NumericDataGrid.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumericDataGrid.Name = "NumericDataGrid";
            this.NumericDataGrid.Size = new System.Drawing.Size(80, 23);
            this.NumericDataGrid.TabIndex = 1;
            // 
            // NumericTextBox
            // 
            this.NumericTextBox.Location = new System.Drawing.Point(191, 81);
            this.NumericTextBox.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumericTextBox.Name = "NumericTextBox";
            this.NumericTextBox.Size = new System.Drawing.Size(80, 23);
            this.NumericTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Write in txt.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Write in DataGrid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Write in TextBox";
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(320, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumericTextBox);
            this.Controls.Add(this.NumericDataGrid);
            this.Controls.Add(this.NumericTxt);
            this.Font = new System.Drawing.Font("Verdana", 7.8F);
            this.Name = "FormLog";
            this.Text = "Log Settings";
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericTxt;
        private System.Windows.Forms.NumericUpDown NumericDataGrid;
        private System.Windows.Forms.NumericUpDown NumericTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}