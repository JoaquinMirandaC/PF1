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
            var b = new StoreBuilder("3 FloridaMarket2 1,a,1,3 2,a,2,4 3,a,3,10");
            var sd = new StoreDirector();
           sd.Construct(b);
            Store finalStore = b.GetStore();

            string json = JsonConvert.SerializeObject(new JsonFormat(finalStore));
            ClientAPI adapter = new ClientAPI();
            Image QR = adapter.Encode(finalStore);
            string path = "D:\\img3.jpg";
            QR.Save(path);
            QR.Dispose();
            //NEW method to create store object
            path = "D:\\img3.json";
            File.WriteAllText(path, json);

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
