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
        private bool ShowOrigin;
        private MainForn origin;
        private int vegcount;
        private int sodcount;
        private int bredcount;

        public Simulation(MainForn origin)
        {
            this.origin = origin;
            ShowOrigin = true;
            InitializeComponent();
            StoreAdministrator.Start();
            ReadImages();
            button2.Enabled = false;
            vegcount = 0;
            sodcount = 0;
            bredcount = 0;

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
            SingletonWriter.GetInstance().Write("Simulation Started");

        }
        void AppendText(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;
            
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                
            }
            box.SelectionLength = 0; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Dictionary<int, int> inventory = StoreAdministrator.InventoryTomorrow();

            //Chain
            ProductHandler veg = new VegetableTrucks((int)vegetablecount.Value);
            ProductHandler soda = new SodaTrucks((int)sodacount.Value);
            ProductHandler bread = new BreadTrucks((int)breadcount.Value);

            veg.SetSuccessor(soda);
            soda.SetSuccessor(bread);

            var simulationInv = veg.ProcessRequest(inventory);

            int validate = 0;
            foreach (var keyValuePair in inventory)
            {

                if(keyValuePair.Value > 0)
                    AppendText(richTextBox1, Color.Red, "The demand of product with ID " + keyValuePair.Key.ToString() + " cannot be supplied with " + keyValuePair.Value.ToString() + " products missing \n");
   
                else if (keyValuePair.Value == 0)
                {   
                    AppendText(richTextBox1, Color.LightGreen, "The demand of product with ID " + keyValuePair.Key.ToString() + " can be supplied " + "\n");
                    validate++;
                }
                    
                else
                {
                    AppendText(richTextBox1, Color.Green, "The demand of product with ID " + keyValuePair.Key.ToString() + " can be supplied with " + (keyValuePair.Value*-1).ToString() + " products left over \n");
                    validate++;
                }
            }
            //meaning the three products can be sent
            button2.Enabled = validate >= 3;

        }

        private void Simulation_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ShowOrigin)
            {
                origin.Show();
            }
            SingletonWriter.GetInstance().Write("Simulation Finished");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ShowOrigin = false;
            StoreRoute form = new StoreRoute(origin);
            form.Show();
            this.Close();
        }
        

        private void vegetablecount_ValueChanged(object sender, EventArgs e)
        {
            if((int)vegetablecount.Value > vegcount)
                SingletonWriter.GetInstance().Write("Added 1 Vegetable Truck");
            else
                SingletonWriter.GetInstance().Write("Removed 1 Vegetable Truck");

            vegcount = (int)vegetablecount.Value;
        }

        private void sodacount_ValueChanged(object sender, EventArgs e)
        {
            if ((int)sodacount.Value > sodcount)
                SingletonWriter.GetInstance().Write("Added 1 Soda Truck");
            else
                SingletonWriter.GetInstance().Write("Removed 1 Soda Truck");

            sodcount = (int)sodacount.Value;
        }

        private void breadcount_ValueChanged(object sender, EventArgs e)
        {
            if ((int)breadcount.Value > bredcount)
                SingletonWriter.GetInstance().Write("Added 1 Bread Truck");
            else
                SingletonWriter.GetInstance().Write("Removed 1 Bread Truck");

            bredcount = (int)breadcount.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SingletonLog.GetInstance().log.Show();
        }
    }
}
