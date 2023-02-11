using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Invoice : Form
    {
        int x = 10;
        int y = 207;
        FileHelper fileHelper = new FileHelper();
        //InvoiceClass invoiceClass = new InvoiceClass();
        public Invoice()
        {
            InitializeComponent();
            var myinvoice = fileHelper.ReadInvoice("invoice.json");
            int y = 137;
            foreach (var myorder in myinvoice)
            {
                var uc = new Order();
                uc.Name = myorder.Name;
                uc.Price = myorder.Price;
                uc.Quantity = myorder.Quantity;
                uc.Total = myorder.Total;
                uc.Location = new Point(56, y);
                y += 28;
                this.Controls.Add(uc);
            }
            var total = fileHelper.Read("foodtotal.json");
            var totalUc = new TotalAmount();
            totalUc.Name = "Total";
            totalUc.Total = total;
            totalUc.Location = new Point(56, y);
            this.Controls.Add(totalUc);
            foreach (var item in Controls)
            {
                if(item is UserControl)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(".");
            foreach (var item in files)
            {
                if (item.Equals(".\\invoice.json"))
                {
                    File.Delete(item);
                }
            }
            Application.Exit();
        }
    }
}
