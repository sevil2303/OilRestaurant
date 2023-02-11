using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class InvoiceClass
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Total { get; set; }

        public override string ToString()
        {
            return $"{Name} {Price} {Quantity} {Price * Quantity}";
        }

    }
}
