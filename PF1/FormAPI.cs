using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace PF1
{
    public partial class FormAPI : Form
    {
        public FormAPI ( )
        {
            InitializeComponent();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            var client = new WebClient();
            var url = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=Eample";
            var request = HttpWebRequest.Create( url );
            var response = request.GetResponse();
            var ad = response.GetResponseStream();
            Image img = Image.FromStream( ad );
            pictureBox1.Image = img;
            pictureBox1.Image.Save( @"C:\Users\Usuario\Downloads\IMAGEJPEG.jpeg" ); //,System.Drawing.Imaging.ImageFormat.Jpeg);
            MessageBox.Show( img.GetType().ToString() );
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            pictureBox1.Image = Image.FromFile( @"C:\Users\Usuario\Downloads\IMAGEJPEG.jpeg" );
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            pictureBox1.Image = null;
        }
    }
}
