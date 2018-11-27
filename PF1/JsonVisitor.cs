﻿namespace PF1
{
    public class JsonVisitor : Visitor
    {
        public string OrderString { get; set; }

        public JsonVisitor ( )
        {
            OrderString = "";
        }
        public override void Visit ( Product product )
        {
            OrderString += $"{product.Id},{product.Name},{product.Price},{product.Quantity} ";
        }
    }
}
