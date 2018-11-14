using System;
using patterns.Behavioral.Command.command;
using patterns.Behavioral.Command.invoker;
using patterns.Behavioral.Command.request;

namespace patterns.Behavioral.Command
{
    public class CommandPatternDemo
    {
        public static void Start(){
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}
