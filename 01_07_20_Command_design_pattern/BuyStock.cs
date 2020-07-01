using System;
using System.Collections.Generic;
using System.Text;

namespace _01_07_20_Command_design_pattern
{
    public class BuyStock : Order
    {
        private Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute()
        {
            _abcStock.Buy();
        }
    }
}
