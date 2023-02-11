using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class OilStation : Form
    {
        InvoiceClass invoiceClass = new InvoiceClass();
        FileHelper fileHelper = new FileHelper();
        decimal oilprice = 0;
        public double total = 0.0;
        public OilStation()
        {
            InitializeComponent();
            quantityTxb.Enabled = false;
            quantumTxb.Enabled = false;

            List<Oil> oils = new List<Oil>()
            {
                new Oil()
                {
                    Name="AI-92",
                    Price=1
                },
                new Oil()
                {
                    Name="AI-95",
                    Price=2
                },
                new Oil()
                {
                    Name="AI-98",
                    Price=2.3
                },
                new Oil()
                {
                    Name="Diesel",
                    Price=0.8
                }
            };
            oilcomboBox.DisplayMember = nameof(Oil.Name);
            oilcomboBox.Items.AddRange(oils.ToArray());
            oilcomboBox.SelectedIndex = 0;
        }

        private void oilcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceLblBox.Text = oilcomboBox.SelectedItem.ToString();
        }
        public bool Quantity { get; set; } = false;
        public bool Quantum { get; set; } = false;

        private void quantityBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Quantity)
            {
                quantityTxb.Enabled = true;
            }
            else
            {
                quantityTxb.Enabled = false;
            }
            Quantity = !Quantity;
        }
        private void quantumBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!Quantum)
            {
                quantumTxb.Enabled = true;
            }
            else
            {
                quantumTxb.Enabled = false;
            }
            Quantum = !Quantum;
        }
        decimal amount = 0;
        decimal quantity = 0;
        decimal quantum = 0;

        private void quantityTxb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantityTxb.Text == "")
                {
                    amount -= quantity;
                    quantity = 0;
                }
                else
                {
                    quantity = decimal.Parse(quantityTxb.Text) * decimal.Parse(priceLblBox.Text);
                    amount = quantity;
                }
                invoiceClass.Quantity = quantity;
                oilamountLbl.Text = amount.ToString();
            }
            catch
            {

            }
        }

        private void quantumTxb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (quantumTxb.Text == "")
                {
                    amount -= quantum;
                    quantum = 0;
                }
                else
                {
                    quantum = decimal.Parse(quantumTxb.Text);
                    quantityTxb.Text = (double.Parse(quantumTxb.Text) / double.Parse(priceLblBox.Text)).ToString();
                    amount = quantum;
                }
                oilamountLbl.Text = amount.ToString();
            }
            catch { }
        }
        private void oilcomboBox_TextUpdate(object sender, EventArgs e)
        {
            quantityTxb_TextChanged(sender, e);
            quantumTxb_TextChanged(sender, e);
        }

        private void oilcomboBox_TextChanged(object sender, EventArgs e)
        {
            priceLblBox.Text = oilcomboBox.SelectedItem.ToString();
            if (quantityTxb.Enabled)
            {
                quantityTxb_TextChanged(oilcomboBox, e);
            }
            else
            {
                quantumTxb_TextChanged(oilcomboBox, e);
            }
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            
            //Restaurant rest = new Restaurant();
            if (oilamountLbl.Text == "")
            {
                oilprice = 0;
            }
            else
            {
                oilprice = decimal.Parse(oilamountLbl.Text);
            }
            
            if (oilprice != 0) {
                var mylist = fileHelper.ReadInvoice("invoice.json");
                mylist.Add(new InvoiceClass
                {
                    Name = oilcomboBox.Text,
                    Price = decimal.Parse(priceLblBox.Text),
                    Quantity = decimal.Parse(quantityTxb.Text),
                    Total = decimal.Parse(oilamountLbl.Text)
                });
                fileHelper.WriteInvoice(mylist);
            }
            
            var mytotal = fileHelper.Read("foodtotal.json");
            mytotal += oilprice;
            Exit exit = new Exit();
            this.Dispose();
            exit.totalamountLbl.Text = mytotal.ToString();
            fileHelper.Write(mytotal);
            this.Close();
            exit.Enabled = true;
            exit.ShowDialog();

        }
    }

}
