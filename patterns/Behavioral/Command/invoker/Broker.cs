using System;
using System.Collections.Generic;
using patterns.Behavioral.Command.command;

namespace patterns.Behavioral.Command.invoker
{
    public class Broker
    {
        private List<Order> orderList = new List<Order>();

        public void TakeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            orderList.ForEach(order => order.Execute());
            orderList.Clear();
        }
    }
}
