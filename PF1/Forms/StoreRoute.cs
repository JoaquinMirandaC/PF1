using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PF1
{
    public partial class StoreRoute : Form
    {
        private bool ShowOrigin;
        private bool ShowWarning;
        private MainForn origin;

        public StoreRoute ( MainForn origin )
        {
            this.origin = origin;
            ShowOrigin = true;
            ShowWarning = true;
            InitializeComponent();
            StoreAdministrator.Start();
            ReadImages();
        }

        private void ReadImages ( )
        {
            ClientAPI adapter = new ClientAPI();
            string folderPath = Path.Combine( Directory.GetParent( Directory.GetCurrentDirectory() ).Parent.FullName, @"Images\" );
            foreach (string path in Directory.EnumerateFiles( folderPath, "*.jpg" ))
            {
                Image QR = Image.FromFile( path );
                
                Store converted = adapter.Decode( QR );
                QR.Dispose();

                if (converted != null)
                {
                    converted.LastOrderPath = path;
                    StoreAdministrator.StoreListToday.Add( converted );
                }
            }
            //decide route
            StoreAdministrator.UpdateDeliverToday();
            //show datagrid
            ShowTable();
        }

        public void ShowTable ( )
        {
            dataGridView1.Rows.Clear();
            object [] buffer = new object [4];
            List<DataGridViewRow> rows = new List<DataGridViewRow>();
            foreach (var slave in StoreAdministrator.StoreListToday)
            {

                buffer [0] = slave.StoreId;
                buffer [1] = slave.StoreName;
                buffer [2] = slave.StoreOrder.OrderValue;

                rows.Add( new DataGridViewRow() );
                rows [rows.Count - 1].CreateCells( dataGridView1, buffer );
            }
            dataGridView1.Rows.AddRange( rows.ToArray() );
        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (StoreAdministrator.StoreListToday.Count > 0)
            {
                int col = e.ColumnIndex;
                int fil = e.RowIndex;
                if (col == 3 && fil < StoreAdministrator.StoreListToday.Count && fil >= 0)
                {
                    OrderForm orderForm = new OrderForm( fil );
                    orderForm.Show();
                }
            }
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            ShowOrigin = false;
            ShowWarning = false;
            Simulation form = new Simulation( origin );
            form.Show();
            this.Close();
        }

        private void StoreRoute_FormClosed ( object sender, FormClosedEventArgs e )
        {
            if (ShowOrigin)
                origin.Show();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            new FormLog().Show();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            SingletonLog.GetInstance().log.Show();
        }

        private void StoreRoute_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ShowWarning)
            {
                var window = MessageBox.Show("You are missing the simulation, are you sure?",
                "Simmulation Missing",
                MessageBoxButtons.YesNo);

                e.Cancel = (window == DialogResult.No);
            }
        }
    }
}
