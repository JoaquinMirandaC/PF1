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
    public partial class OrderForm : Form
    {
        private Store current;
        public OrderForm(int index)
        {
            InitializeComponent();
            current = StoreAdministrator.StoreListToday[index];
            //initialize
            idBox.Text = current.StoreId.ToString();
            nameBox.Text = current.StoreName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Store captured = new Store();
            captured.StoreOrder = new Order();
            captured.StoreId = Convert.ToInt32(idBox.Text);
            captured.StoreName = nameBox.Text;
            if (ValidateProducts())
            {
                if(Convert.ToInt32(nvegBox.Text) > 0)
                {
                    Product veg = new Vegetable(Convert.ToInt32(nvegBox.Text), Convert.ToDouble(pvegBox.Text));
                    captured.StoreOrder.AddItems(veg);
                }
                if (Convert.ToInt32(nsodaBox.Text) > 0)
                {
                    Product soda = new Soda(Convert.ToInt32(nsodaBox.Text), Convert.ToDouble(psodaBox.Text));
                    captured.StoreOrder.AddItems(soda);
                }
                if (Convert.ToInt32(nbreadBox.Text) > 0)
                {
                    Product bread = new Bread(Convert.ToInt32(nbreadBox.Text), Convert.ToDouble(pbreadBox.Text));
                    captured.StoreOrder.AddItems(bread);
                }
                //StoreAdministrator.StoreListTomorrow.Add(captured);
                //log start of order
                SingletonWriter.GetInstance().Write("Order created from store:" + captured.StoreName);

                foreach(Product p in captured.StoreOrder.ListOfProducts())
                {
                    SingletonWriter.GetInstance().Write("Added " + p.quantity + " products with ID " + p.idProduct);
                }

                //log end of order
                SingletonWriter.GetInstance().Write("Order finalized " );

                //log image creation
                //adapter to create image from json
                ClientAPI adapter = new ClientAPI();
                Image QR = adapter.Encode(captured);
                string path = current.LastOrderPath;           
                QR.Save( path );
                QR.Dispose();
                SingletonWriter.GetInstance().Write("Image from order created successfully");
                this.Close();
            }
            else
                label10.Visible = true;
        }

        private bool ValidateProducts()
        {
            bool Flag = true;
            try
            {
                if (Convert.ToInt32(nvegBox.Text) < 0 || Convert.ToInt32(nsodaBox.Text) < 0 || Convert.ToInt32(nbreadBox.Text) < 0)
                    Flag = false;
                if (Convert.ToInt32(pvegBox.Text) < 0 || Convert.ToInt32(psodaBox.Text) < 0 || Convert.ToInt32(pbreadBox.Text) < 0)
                    Flag = false;

            }
            catch
            {
                Flag = false;
            }
            return Flag;
        }
    }
}
