using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF1
{
    public partial class MainForn : Form
    {
        private FileStream logStream;
        private StreamWriter streamWriter;

        public MainForn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logStream = File.Open( Path.Combine( Directory.GetParent( Directory.GetCurrentDirectory() ).Parent.FullName, @"Logs\\text.txt" ), FileMode.Create );
            streamWriter = new StreamWriter( logStream );
            streamWriter.Write( "Cambio" );
            streamWriter.Close();

            MessageBox.Show( Path.Combine( Directory.GetParent( Directory.GetCurrentDirectory() ).Parent.FullName, @"Logs" ));

            StoreRoute ruta = new StoreRoute(this);
            ruta.Show();
            this.Hide();
        }
    }
}
