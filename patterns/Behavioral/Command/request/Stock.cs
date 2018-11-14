using System;
namespace patterns.Behavioral.Command.request
{
    public class Stock
    {
        private String _name = "ABC";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] bought");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock [ Name: {_name}, Quantity: {_quantity} ] sold");
        }
    }
}
