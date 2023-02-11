using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Order : UserControl
    {
        public string Name
        {
            get { return nameLbl.Text; }
            set { nameLbl.Text = value; }
        }
        public decimal Price
        {
            get { return decimal.Parse(priceLbl.Text); }
            set { priceLbl.Text = value.ToString(); }
        }

        public decimal Quantity
        {
            get { return decimal.Parse(quantityLbl.Text); }
            set { quantityLbl.Text = value.ToString(); }
        }
        public decimal Total
        {
            get { return decimal.Parse(totalLbl.Text); }
            set { totalLbl.Text = value.ToString(); }
        }
        public Order()
        {
            InitializeComponent();

        }
    }
}
