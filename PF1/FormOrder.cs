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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var b = new StoreBuilder("0 OXXO 0,a,1,3 1,a,2,4 2,a,3,10");
            var sd = new StoreDirector();
           sd.Construct(b);
            Store finalStore = b.GetStore();
            
            //double storeCost = finalStore.StoreOrder.OrderCost();
            //label2.Text = $"{storeCost}";
            
          

            string json = JsonConvert.SerializeObject(new JsonFormat(finalStore));
            label1.Text = json;

            //NEW method to create store object
            sd = new StoreDirector();
            var ba = new StoreJBuilder(json);
            sd.Construct(ba);
            finalStore = ba.GetStore();
            string json2 = JsonConvert.SerializeObject(new JsonFormat(finalStore));
            string path = "D:\\res.json";
            File.WriteAllText(path, json2);
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
