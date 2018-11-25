using System.Drawing;

namespace PF1
{
    public abstract class Target
    {
        public abstract bool Check ( string JSON );
        public abstract Image Decode ( string Code );
        public abstract string Encode (Image QR  );
    }
}