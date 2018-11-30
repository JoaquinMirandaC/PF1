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
            logStream = File.Open( Path.Combine( Directory.GetParent( Directory.GetCurrentDirectory() ).Parent.FullName, @"Logs\\text.txt" ), FileMode.Append );
            streamWriter = new StreamWriter( logStream );
            streamWriter.WriteLine( $"New Session: {DateTime.Now.ToString()} \n" );
            streamWriter.Close();
            StoreRoute ruta = new StoreRoute(this);
            ruta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simulation sim = new Simulation(this);
            sim.Show();
            this.Hide();
        }
    }
}
