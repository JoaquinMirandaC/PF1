using Newtonsoft.Json;
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

            var b = new StoreBuilder( "0 OXXO 0,a,1,3 1,a,2,4 2,a,3,10" );
            var sd = new StoreDirector();
            sd.Construct( b );
            Store finalStore = b.GetStore();
            string json = JsonConvert.SerializeObject( new JsonFormat( finalStore ) );


            var c = new ClientAPI();
            var a = c.Encode(finalStore);
            pictureBox1.Image = a;
            //label1.Text = b;
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
