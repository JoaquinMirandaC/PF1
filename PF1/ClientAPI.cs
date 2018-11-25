using System.Drawing;

namespace PF1
{
    public class ClientAPI
    {
        public bool Check( string a)
        {
            var Adapt = new Adapter();
            return Adapt.Check( a );
        }

        public Store Decode ( Image QR )
        {
            var Adapt = new Adapter();
            return Adapt.Decode( QR );
        }

        public Image Encode ( Store Code )
        {
            var Adapt = new Adapter();
            return Adapt.Encode( Code );
        }   

    }
}