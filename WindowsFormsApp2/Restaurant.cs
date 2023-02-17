using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Restaurant : Form
    {
        FileHelper fileHelper = new FileHelper();
        InvoiceClass invoiceClass = new InvoiceClass();
        List<InvoiceClass> invoices = new List<InvoiceClass> { };
        public Restaurant()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(24, 25, 26);
            Meals.BackColor = Color.FromArgb(24, 25, 26);
            Juices.BackColor = Color.FromArgb(24, 25, 26);
        }
        decimal foodamount = 0;
        decimal pizza = 0;
        decimal hamburger = 0;
        decimal frenchfries = 0;
        decimal coke = 0;
        decimal redbull = 0;
        decimal juice = 0;
        public decimal total = 0;
        int hamburgertotal = 0;
        private void hamburgerquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (hamburgerquantityTxb.Text == "")
            {
                foodamount -= hamburger;
                if (foodamount < 0)
                {
                    foodamount = 0;
                }
                hamburger = 0;
            }
            else
            {
                hamburger = decimal.Parse(hamburgerpriceLbl.Text) * (int.Parse(hamburgerquantityTxb.Text));
                foodamount = hamburger + pizza + frenchfries + redbull + coke + juice;
            }
            foodamountLbl.Text = foodamount.ToString();
            if (hamburgerquantityTxb.Text != "")
            {
                hamburgertotal = int.Parse(hamburgerquantityTxb.Text);
                invoiceClass.Total = decimal.Parse(hamburgerpriceLbl.Text) * hamburgertotal;
            }
            else
            {
                hamburgertotal = 0;
                invoiceClass.Total = 0;
            }           
        }
        int pizzatotal = 0;
        private void pizzaquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (pizzaquantityTxb.Text == "")
            {
                foodamount -= pizza;
                if (foodamount < 0)
                {
                    foodamount = 0;
                }
                pizza = 0;
            }
            else
            {
                pizza = decimal.Parse(pizzapriceLbl.Text) * (int.Parse(pizzaquantityTxb.Text));
                foodamount = hamburger + pizza + frenchfries + redbull + coke + juice;
            }
            foodamountLbl.Text = foodamount.ToString();
            if (pizzaquantityTxb.Text != "")
            {
                pizzatotal = int.Parse(pizzaquantityTxb.Text);
                invoiceClass.Total = decimal.Parse(pizzapriceLbl.Text) * pizzatotal;               
            }
            else
            {
                pizzatotal = 0;
                invoiceClass.Total = 0;
                invoices.Remove(new InvoiceClass
                {
                    Name = "Pizza",
                    Price = decimal.Parse(pizzapriceLbl.Text),
                    Quantity = pizzatotal,
                    Total = pizzatotal * decimal.Parse(pizzapriceLbl.Text)
                });
            }

        }
        int frenchfriestotal = 0;
        private void frenchfriesquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (frenchfriesquantityTxb.Text == "")
            {
                foodamount -= frenchfries;
                if (foodamount < 0)
                {
                    foodamount = 0;
                }
                frenchfries = 0;
            }
            else
            {
                frenchfries = decimal.Parse(frenchfriespriceLbl.Text) * (int.Parse(frenchfriesquantityTxb.Text));
                foodamount = hamburger + pizza + frenchfries + redbull + coke + juice;
            }
            foodamountLbl.Text = foodamount.ToString();
            if (frenchfriesquantityTxb.Text != "")
            {
                frenchfriestotal = int.Parse(frenchfriesquantityTxb.Text);
                invoiceClass.Total = decimal.Parse(frenchfriespriceLbl.Text) * frenchfriestotal;
            }
            else
            {
                frenchfriestotal = 0;
                invoiceClass.Total = 0;
                invoices.Remove(new InvoiceClass
                {
                    Name = "French Fries",
                    Price = decimal.Parse(frenchfriespriceLbl.Text),
                    Quantity = frenchfriestotal,
                    Total = frenchfriestotal * decimal.Parse(frenchfriespriceLbl.Text)
                });
            }
        }
        int coketotal = 0;
        private void cokequantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (cokequantityTxb.Text == "")
            {
                foodamount -= coke;
                if (foodamount < 0)
                {
                    foodamount = 0;
                }
                coke = 0;
            }
            else
            {
                coke = decimal.Parse(cokepriceLbl.Text) * (int.Parse(cokequantityTxb.Text));
                foodamount = hamburger + pizza + frenchfries + redbull + coke + juice;
            }
            foodamountLbl.Text = foodamount.ToString();
            if (cokequantityTxb.Text != "")
            {
                coketotal = int.Parse(cokequantityTxb.Text);
                invoiceClass.Total = decimal.Parse(cokepriceLbl.Text) * coketotal;
            }
            else
            {
                coketotal = 0;
                invoiceClass.Total = 0;
                invoices.Remove(new InvoiceClass
                {
                    Name = "Coke",
                    Price = decimal.Parse(cokepriceLbl.Text),
                    Quantity = coketotal,
                    Total = coketotal * decimal.Parse(cokepriceLbl.Text)
                });
            }
        }
        int redbulltotal = 0;
        private void redbullquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (redbullquantityTxb.Text == "")
            {
                foodamount -= redbull;
                if (foodamount < 0)
                {
                    foodamount = 0;
                }
                redbull = 0;
            }
            else
            {
                redbull = decimal.Parse(redbullpriceLlbl.Text) * (int.Parse(redbullquantityTxb.Text));
                foodamount = hamburger + pizza + frenchfries + redbull + coke + juice;
            }
            foodamountLbl.Text = foodamount.ToString();
            if (redbullquantityTxb.Text != "")
            {
                redbulltotal = int.Parse(redbullquantityTxb.Text);
                invoiceClass.Total = decimal.Parse(redbullpriceLlbl.Text) * redbulltotal;
            }
            else
            {
                redbulltotal = 0;
                invoiceClass.Total = 0;
                invoices.Remove(new InvoiceClass
                {
                    Name = "Red Bull",
                    Price = decimal.Parse(redbullpriceLlbl.Text),
                    Quantity = redbulltotal,
                    Total = redbulltotal * decimal.Parse(redbullpriceLlbl.Text)
                });
            }
        }
        int juicetotal = 0;
        private void juicequantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (juicequantityTxb.Text == "")
            {
                foodamount -= juice;
                if (foodamount < 0)
                {
                    foodamount = 0;
                }
                juice = 0;
            }
            else
            {
                juice = decimal.Parse(juicepriceLbl.Text) * (int.Parse(juicequantityTxb.Text));
                foodamount = hamburger + pizza + frenchfries + redbull + coke + juice;
            }
            foodamountLbl.Text = foodamount.ToString();
            if (juicequantityTxb.Text != "")
            {
                juicetotal = int.Parse(juicequantityTxb.Text);
                invoiceClass.Total = decimal.Parse(juicepriceLbl.Text) * juicetotal;
            }
            else
            {
                juicetotal = 0;
                invoiceClass.Total = 0;
                invoices.Remove(new InvoiceClass
                {
                    Name = "Red Bull",
                    Price = decimal.Parse(juicepriceLbl.Text),
                    Quantity = juicetotal,
                    Total = juicetotal * decimal.Parse(juicepriceLbl.Text)
                });
            }
        }
        decimal myfood = 0;
        private void oilBtn_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if (hamburger > 0)
            {
                counter++;
                invoices.Add(new InvoiceClass
                {
                    Name = "Hamburger",
                    Price = decimal.Parse(hamburgerpriceLbl.Text),
                    Quantity = hamburgertotal,
                    Total = hamburgertotal * decimal.Parse(hamburgerpriceLbl.Text)
                });
                fileHelper.WriteInvoice(invoices);
            }
            if (pizza > 0)
            {
                counter++;
                invoices.Add(new InvoiceClass
                {
                    Name = "Pizza",
                    Price = decimal.Parse(pizzapriceLbl.Text),
                    Quantity = pizzatotal,
                    Total = pizzatotal * decimal.Parse(pizzapriceLbl.Text)
                });
                fileHelper.WriteInvoice(invoices);
            }
            if (frenchfries > 0)
            {
                counter++;
                invoices.Add(new InvoiceClass
                {
                    Name = "French Fries",
                    Price = decimal.Parse(frenchfriespriceLbl.Text),
                    Quantity = frenchfriestotal,
                    Total = frenchfriestotal * decimal.Parse(frenchfriespriceLbl.Text)
                });
                fileHelper.WriteInvoice(invoices);
            }
            if (coke > 0)
            {
                counter++;
                invoices.Add(new InvoiceClass
                {
                    Name = "Coke",
                    Price = decimal.Parse(cokepriceLbl.Text),
                    Quantity = coketotal,
                    Total = coketotal * decimal.Parse(cokepriceLbl.Text)
                });
                fileHelper.WriteInvoice(invoices);
            }
            if (redbull > 0)
            {
                counter++;
                invoices.Add(new InvoiceClass
                {
                    Name = "Red Bull",
                    Price = decimal.Parse(redbullpriceLlbl.Text),
                    Quantity = redbulltotal,
                    Total = redbulltotal * decimal.Parse(redbullpriceLlbl.Text)
                });
                fileHelper.WriteInvoice(invoices);
            }
            if (juice > 0)
            {
                counter++;
                invoices.Add(new InvoiceClass
                {
                    Name = "Fresh Orange Juice",
                    Price = decimal.Parse(juicepriceLbl.Text),
                    Quantity = juicetotal,
                    Total = juicetotal * decimal.Parse(juicepriceLbl.Text)
                });
                fileHelper.WriteInvoice(invoices);
            }
            if (counter == 0)
            {
                fileHelper.WriteInvoice(invoices);
            }
            if (foodamountLbl.Text == "")
            {
                myfood = 0;
            }
            else
            {
                myfood = decimal.Parse(foodamountLbl.Text);
            }
            total = myfood;
            fileHelper.Write(myfood);
            this.Dispose();
            OilStation oilStation = new OilStation();
            this.Hide();
            oilStation.ShowDialog();
            this.Close();
        }


    }
}
