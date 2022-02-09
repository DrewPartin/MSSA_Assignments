using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignment_4._4
{
    public abstract class Beverages
    {
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string DrinkName { get; set; }
        public enum Size { Small, Medium, Large }
        public enum Temp { Hot, Cold }
        public decimal UnitPrice { get; set; }
        public abstract decimal Tax { get; set; }
        public abstract decimal TotalPrice { get; set; }
        public abstract decimal CalculateTax(decimal taxrate);
        public abstract decimal CalculateCost(decimal taxrate);
                
    }

    class Coffee : Beverages
    {
        public override decimal TotalPrice { get; set; }
        public bool Cream { get; set; }
        public bool Sugar { get; set; }
        public bool Own_Cup { get; set; }
        public Size size { get; set; }
        public Temp temp { get; set; }
        public override decimal Tax { get; set; }
        public decimal Discount { get; set; }
        public override decimal CalculateTax(decimal taxrate)
        {            
            return Math.Round(this.UnitPrice * taxrate, 2);
        }
        public override decimal CalculateCost(decimal taxrate)
        {                      
            if(Own_Cup == false)
            {                
                Discount = Math.Round(0.00M, 2);
                return Math.Round(this.UnitPrice + (this.UnitPrice * taxrate), 2);               
            }
            else
            {
                Discount = Math.Round(0.50M, 2);
                return Math.Round(this.UnitPrice + (this.UnitPrice * taxrate) - Discount, 2);                
            }
        }
    }
}
