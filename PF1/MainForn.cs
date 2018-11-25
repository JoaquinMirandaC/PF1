using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF1
{
    public partial class MainForn : Form
    {
        public MainForn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoreRoute ruta = new StoreRoute(this);
            ruta.Show();
            this.Hide();
        }
    }
}
