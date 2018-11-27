namespace PF1
{
    public class Bread : Product
    {
        public Bread ( int Quantity, double Price ) : base( Quantity, Price )
        {
            Id = 1;
            Name = "Bread";
        }
    }
}
