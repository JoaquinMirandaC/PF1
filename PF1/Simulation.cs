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
    public partial class Simulation : Form
    {       
        private MainForn origin;
        public Simulation(MainForn origin)
        {
            this.origin = origin;
            InitializeComponent();
            StoreAdministrator.Start();
            ReadImages();
        }
        private void ReadImages()
        {
            ClientAPI adapter = new ClientAPI();
            string folderPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Images\");
            foreach (string path in Directory.EnumerateFiles(folderPath, "*.jpg"))
            {
                Image QR = Image.FromFile(path);

                Store converted = adapter.Decode(QR);
                QR.Dispose();

                if (converted != null)
                {
                    converted.LastOrderPath = path;
                    StoreAdministrator.StoreListTomorrow.Add(converted);
                }
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> inventory = StoreAdministrator.InventoryTomorrow();
            //foreach(Store s in StoreAdministrator.StoreListTomorrow)
            //{
            //    foreach(Product p in s.StoreOrder.NumberOfProducts())
            //        MessageBox.Show(p.idProduct.ToString() + " " + p.quantity.ToString());
            //}
            foreach (var keyValuePair in inventory)
            {
                MessageBox.Show(keyValuePair.Key.ToString() + " " + keyValuePair.Value.ToString());

            }
        }

        private void Simulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            origin.Show();
        }
    }
}
