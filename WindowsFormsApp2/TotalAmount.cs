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
    public partial class TotalAmount : UserControl
    {
        public string Name
        {
            get { return totaltextLbl.Text; }
            set { totaltextLbl.Text = value; }
        }
        public decimal Total
        {
            get { return decimal.Parse(totalamountLbl.Text); }
            set { totalamountLbl.Text = value.ToString(); }
        }
        public TotalAmount()
        {
            InitializeComponent();
            ;
            //this.TotalAmount.BackColor = Color.FromArgb(25, 40, 65);
        }
    }
}
