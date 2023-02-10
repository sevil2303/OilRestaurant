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
            invoiceClass.Name = "Hamburger";
            invoiceClass.Price = decimal.Parse(hamburgerpriceLbl.Text);
            if (hamburgerquantityTxb.Text != "")
            {
                invoiceClass.Quantity = int.Parse(hamburgerquantityTxb.Text);
                invoiceClass.Total = decimal.Parse(hamburgerpriceLbl.Text) * (int.Parse(hamburgerquantityTxb.Text));
            }
            else
            {
                invoiceClass.Quantity = 0;
                invoiceClass.Total = 0;
            }
        }

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
                pizza = decimal.Parse(pizzapriceLbl.Text) * (int.Parse(pizzapriceLbl.Text));
                foodamount = hamburger + pizza + frenchfries + redbull + coke + juice;
            }
            foodamountLbl.Text = foodamount.ToString();
            invoiceClass.Name = "Pizza";
            invoiceClass.Price = decimal.Parse(pizzapriceLbl.Text);
            if (hamburgerquantityTxb.Text != "")
            {
                invoiceClass.Quantity = int.Parse(pizzapriceLbl.Text);
                invoiceClass.Total = decimal.Parse(pizzapriceLbl.Text) * (int.Parse(pizzaquantityTxb.Text));
            }
            else
            {
                invoiceClass.Quantity = 0;
                invoiceClass.Total = 0;
            }
        }

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
            foodamountLbl.Text = foodamount.ToString();
            invoiceClass.Name = "French Fries";
            invoiceClass.Price = decimal.Parse(frenchfriespriceLbl.Text);
            if (frenchfriesquantityTxb.Text != "")
            {
                invoiceClass.Quantity = int.Parse(frenchfriespriceLbl.Text);
                invoiceClass.Total = decimal.Parse(frenchfriespriceLbl.Text) * (int.Parse(frenchfriesquantityTxb.Text));
            }
            else
            {
                invoiceClass.Quantity = 0;
                invoiceClass.Total = 0;
            }
        }

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
            invoiceClass.Name = "Coke";
            invoiceClass.Price = decimal.Parse(pizzapriceLbl.Text);
            if (cokequantityTxb.Text != "")
            {
                invoiceClass.Quantity = int.Parse(cokepriceLbl.Text);
                invoiceClass.Total = decimal.Parse(cokepriceLbl.Text) * (int.Parse(cokequantityTxb.Text));
            }
            else
            {
                invoiceClass.Quantity = 0;
                invoiceClass.Total = 0;
            }
        }

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
            invoiceClass.Name = "Red Bull";
            invoiceClass.Price = decimal.Parse(redbullpriceLlbl.Text);
            if (redbullquantityTxb.Text != "")
            {
                invoiceClass.Quantity = int.Parse(redbullpriceLlbl.Text);
                invoiceClass.Total = decimal.Parse(redbullpriceLlbl.Text) * (int.Parse(redbullquantityTxb.Text));
            }
            else
            {
                invoiceClass.Quantity = 0;
                invoiceClass.Total = 0;
            }
        }

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
            invoiceClass.Name = "Fresh Orange Juice";
            invoiceClass.Price = decimal.Parse(juicepriceLbl.Text);
            if (juicequantityTxb.Text != "")
            {
                invoiceClass.Quantity = int.Parse(juicepriceLbl.Text);
                invoiceClass.Total = decimal.Parse(juicepriceLbl.Text) * (int.Parse(juicequantityTxb.Text));
            }
            else
            {
                invoiceClass.Quantity = 0;
                invoiceClass.Total = 0;
            }
        }
        decimal myfood = 0;
        private void oilBtn_Click(object sender, EventArgs e)
        {
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
