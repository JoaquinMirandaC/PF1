using QRCodeEncoderDecoderLibrary;
using System.Drawing;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace PF1
{
    class Adapter : Target
    {

        public override bool Check ( string JSON )
        {
            try
            {
                JsonFormat j = new JavaScriptSerializer().Deserialize<JsonFormat>( JSON );
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override Store Decode ( Image QR )
        {
            QRDecoder Decoder = new QRDecoder();
            byte [] [] Data = Decoder.ImageDecoder( (Bitmap) QR );
            if (Data == null)
                return null;
            string code = QRCode.ByteArrayToStr( Data [0] );
            if (Check( code ))
            {
                StoreJBuilder builder = new StoreJBuilder( code );
                StoreDirector director = new StoreDirector();
                director.Construct(builder);
                Store s = builder.GetStore();
                return s;
            }
            else return null;
        }

        public override Image Encode ( Store Code )
        {
            string json = JsonConvert.SerializeObject( new JsonFormat( Code ) );

            QREncoder Encoder = new QREncoder();
            Encoder.Encode( ErrorCorrection.H, json );
            Image image = QRCodeToBitmap.CreateBitmap( Encoder, 4, 8 );
            return image;
        }
    }
}