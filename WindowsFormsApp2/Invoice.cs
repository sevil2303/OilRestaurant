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
            int y = 157;
            foreach (var myorder in myinvoice)
            {
                var uc = new Order();
                uc.Name = myorder.Name;
                uc.Price = myorder.Price;
                uc.Quantity = myorder.Quantity;
                uc.Total = myorder.Total;
                uc.Location = new Point(0, y);
                y += 45;
                this.Controls.Add(uc);
            }
            var total = fileHelper.Read("foodtotal.json");
            //Label label = new Label();
            //label.Location = new Point(500, y);
            //label.Text = total.ToString();
            //this.Controls.Add(label);
            var totalUc = new TotalAmount();
            totalUc.Name = "Total";
            totalUc.Total = total;
            totalUc.Location = new Point(0, y + 100);
            this.Controls.Add(totalUc);
            foreach (var item in Controls)
            {
                if(item is UserControl)
                {

                }
            }
            //for (int i = 0; i < myinvoice.Count; i++)
            //{
            //    Label label = new Label();
            //    label.Location = new Point(10, y);
            //    label.ForeColor = Color.Black;
            //    label.Text = myinvoice[i].Name;
            //    label.Show();
            //    y += 100;
            //}
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
