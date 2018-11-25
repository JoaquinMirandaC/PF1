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
using Newtonsoft.Json;

namespace PF1
{
    public partial class StoreRoute : Form
    {
        private bool ShowOrigin;
        private MainForn origin;
        public StoreRoute(MainForn origin)
        {
            this.origin = origin;
            ShowOrigin = true;
            InitializeComponent();
            StoreAdministrator.Start();
            ReadImages();

        }
        private void ReadImages()
        {
            string folderPath = Path.Combine(Environment.CurrentDirectory,  @"Images\");
            foreach (string path in Directory.EnumerateFiles(folderPath, "*.jpg"))
            {

                //get response from adapter
                //if not null, validate in adapter //if valid, add to store administrator StoreToday
                var b = new StoreBuilder("0 OXXO 0,a,1,3 1,a,2,4 2,a,3,10");
                var sd = new StoreDirector();
                sd.Construct(b);
                Store finalStore = b.GetStore();
                string json = JsonConvert.SerializeObject(new JsonFormat(finalStore));
                StoreAdministrator.AddStoreFromString(json, path);

            }
            //decide route
            StoreAdministrator.UpadateDeliverToday();
            //show datagrid
            ShowTable();
        }
        public void ShowTable()
        {
            dataGridView1.Rows.Clear();
            object[] buffer = new object[4];
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var slave in StoreAdministrator.StoreListToday)
            {
                
                buffer[0] = slave.StoreId;
                buffer[1] = slave.StoreName;
                buffer[2] = slave.StoreOrder.orderValue;

                rows.Add(new DataGridViewRow());
                rows[rows.Count - 1].CreateCells(dataGridView1, buffer);
            }
            dataGridView1.Rows.AddRange(rows.ToArray());

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(StoreAdministrator.StoreListToday.Count >0)
            {
                int col = e.ColumnIndex;
                int fil = e.RowIndex;
                if (col == 3 && fil < StoreAdministrator.StoreListToday.Count && fil>=0)
                {
                    OrderForm orderForm = new OrderForm(fil);
                    orderForm.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StoreAdministrator.OrdersReady())
            {
                ShowOrigin = false;
                StoreRoute form = new StoreRoute(origin);
                form.Show();
                this.Close();
            }
            else
                label2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StoreRoute_Load(object sender, EventArgs e)
        {

        }

        private void StoreRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ShowOrigin)
            {
                origin.Show();
            }
           
               
        }
    }
}
