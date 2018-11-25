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
            SingletonLog singleton = SingletonLog.GetInstance();
            singleton.SaveLogs( (int) NumericTxt.Value, (int) NumericDataGrid.Value, (int) NumericTextBox.Value );

        }
    }
}
