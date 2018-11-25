using QRCodeEncoderDecoderLibrary;
using System;
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
            label1.Text = new APIAdapter().Decode( System.Drawing.Image.FromFile( @"C:\Users\Usuario\Downloads\UML-class-diagram-for-Interpreter-pattern.png" ) );

            //QRCode.ByteArrayToStr( new QRDecoder().ImageDecoder( new System.Drawing.Bitmap( System.Drawing.Image.FromFile( @"C:\Users\Usuario\Downloads\QR CODE.bmp" ) ) ) [0] );

            //var client = new WebClient();
            //var url = "https://api.qrserver.com/v1/create-qr-code/?size=150x150&data=Eample";
            //var request = HttpWebRequest.Create( url );
            //var response = request.GetResponse();
            //var ad = response.GetResponseStream();
            //Image img = Image.FromStream( ad );
            //pictureBox1.Image = img;
            //pictureBox1.Image.Save( @"C:\Users\Usuario\Downloads\IMAGEJPEG.jpeg" ); //,System.Drawing.Imaging.ImageFormat.Jpeg);
            //MessageBox.Show( img.GetType().ToString() );
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            var s = new ClientAPI();
            var a = new APIAdapter().Encode( "APIAdapter" );
            var b = new APIAdapter().Decode( a );
            pictureBox1.Image = a;
            label1.Text = b;
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            pictureBox1.Image = null;
        }

        private void FormAPI_Load ( object sender, EventArgs e )
        {
            
        }

        private void FormAPI_FormClosed ( object sender, FormClosedEventArgs e )
        {
            
        }
    }
}
