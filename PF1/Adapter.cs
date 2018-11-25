using QRCodeEncoderDecoderLibrary;
using System.Drawing;

namespace PF1
{
    class Adapter : Target
    {

        public override bool Check ( string JSON )
        {
            ;
        }

        public override Image Decode ( string Code )
        {
            QREncoder Encoder = new QREncoder();
            Encoder.Encode( ErrorCorrection.H, Code );
            Image image = QRCodeToBitmap.CreateBitmap( Encoder, 4, 8 );
            return image;
        }

        public override string Encode ( Image QR )
        {
            QRDecoder Decoder = new QRDecoder();
            byte [] [] Data = Decoder.ImageDecoder( (Bitmap) QR );
            if (Data == null)
                return null;
            string code = QRCode.ByteArrayToStr( Data [0] );
            return code;
        }


    }
}