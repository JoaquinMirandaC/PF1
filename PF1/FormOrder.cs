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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sd = new StoreDirector();

            var b = new StoreBuilder("0 OXXO 0,a,1,3 1,a,2,4 2,a,3,10");
            sd.Construct(b);
            Store finalStore = b.GetStore();
            label1.Text = finalStore.ToString();
            double storeCost = finalStore.StoreOrder.OrderCost();
            label2.Text = $"{storeCost}";
        }
    }
}
