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
            ((System.ComponentModel.ISupportInitialize)(this.NumericTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NumericTxt
            // 
            this.NumericTxt.Location = new System.Drawing.Point(156, 12);
            this.NumericTxt.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumericTxt.Name = "NumericTxt";
            this.NumericTxt.Size = new System.Drawing.Size(80, 22);
            this.NumericTxt.TabIndex = 0;
            // 
            // NumericDataGrid
            // 
            this.NumericDataGrid.Location = new System.Drawing.Point(156, 40);
            this.NumericDataGrid.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumericDataGrid.Name = "NumericDataGrid";
            this.NumericDataGrid.Size = new System.Drawing.Size(80, 22);
            this.NumericDataGrid.TabIndex = 1;
            // 
            // NumericTextBox
            // 
            this.NumericTextBox.Location = new System.Drawing.Point(156, 68);
            this.NumericTextBox.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.NumericTextBox.Name = "NumericTextBox";
            this.NumericTextBox.Size = new System.Drawing.Size(80, 22);
            this.NumericTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 148);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumericTextBox);
            this.Controls.Add(this.NumericDataGrid);
            this.Controls.Add(this.NumericTxt);
            this.Name = "FormLog";
            this.Text = "Log Settings";
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericTxt;
        private System.Windows.Forms.NumericUpDown NumericDataGrid;
        private System.Windows.Forms.NumericUpDown NumericTextBox;
        private System.Windows.Forms.Button button1;
    }
}