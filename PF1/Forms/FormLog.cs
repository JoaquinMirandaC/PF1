using System;
using System.Windows.Forms;

namespace PF1
{
    public partial class FormLog : Form
    {
        public FormLog ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            SingletonWriter singleton = SingletonWriter.GetInstance();
            singleton.SaveLogs( (int) NumericTxt.Value, (int) NumericDataGrid.Value, (int) NumericTextBox.Value );
            this.Close();
        }

        private void FormLog_Load ( object sender, EventArgs e )
        {
            NumericTxt.Value = SingletonWriter.GetInstance().Txt;
            NumericTextBox.Value = SingletonWriter.GetInstance().RichTextBox;
            NumericDataGrid.Value = SingletonWriter.GetInstance().DataGrid;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
