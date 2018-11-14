using System;
using patterns.Behavioral.Command.request;

namespace patterns.Behavioral.Command.command
{
    public class SellStock : Order
    {
        private Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            this._abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}
