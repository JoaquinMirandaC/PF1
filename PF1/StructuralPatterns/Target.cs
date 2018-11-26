using System.Drawing;

namespace PF1
{
    public abstract class Target
    {
        public abstract bool Check ( string JSON );
        public abstract Store Decode ( Image QR );
        public abstract Image Encode ( Store Code );
    }
}