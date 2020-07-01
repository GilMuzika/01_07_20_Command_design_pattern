using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace _01_07_20_Command_design_pattern
{
    public class Broker
    {
        private List<Order> _orderList = new List<Order>();

        public void TakeOrder(Order order)
        {
            _orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach(Order order in _orderList)
            {
                order.Execute();
            }
            _orderList.Clear();
        }
    }
}
