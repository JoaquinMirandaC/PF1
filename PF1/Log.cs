using System;
using System.Windows.Forms;

namespace PF1
{
    public partial class Log : Form
    {
        public Log ( )
        {
            InitializeComponent();
        }

        public void WriteTextBox ( string Text )
        {
            richTextBox1.AppendText( Text + "\n" );
            richTextBox1.Update();
            richTextBox1.Refresh();
        }

        public void WriteDataGrid ( string Text )
        {
            dataGridView1.Rows.Add( Text );
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            SingletonWriter.GetInstance().SaveLogs( 0, 1, 1 );
            SingletonWriter.GetInstance().Write( "PRUEBA" );
        }

        private void Log_FormClosed ( object sender, FormClosedEventArgs e )
        {
            SingletonLog.GetInstance().log = new Log();
        }
    }
}
