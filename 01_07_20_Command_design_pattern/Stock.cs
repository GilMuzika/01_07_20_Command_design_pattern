using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _01_07_20_Command_design_pattern
{
    public class Stock
    {
        private String _name = "ABC";
        private int _quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock [Name: {_name}, Quantity: {_quantity}] bought");
        }

        public void Sell()
        {
            Console.WriteLine($"Stock [Name: {_name}, Quantity: {_quantity}] sold");
        }
            
        
            
        
    }
}
