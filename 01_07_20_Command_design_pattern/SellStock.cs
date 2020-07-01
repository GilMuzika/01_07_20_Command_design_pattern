using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07_20_Command_design_pattern
{
    public class SellStock : Order
    {
        private Stock _abcStock;

        public SellStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Sell();
        }
    }
}
