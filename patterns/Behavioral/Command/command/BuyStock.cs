using System;
using patterns.Behavioral.Command.request;

namespace patterns.Behavioral.Command.command
{
    public class BuyStock : Order
    {
        private Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            this._abcStock = abcStock;
        }

        public void Execute() => _abcStock.Buy();
    }
}
