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

        Exit exit = new Exit();
        Restaurant rest = new Restaurant();
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
        public void Test()
        {
            if (exit.totalamountLbl.Text == "")
            {
                rest.total = 0;
            }
            else
            {
                rest.total = double.Parse(exit.totalamountLbl.Text);
            }
            if (rest.foodamountLbl.Text == "")
            {
                rest.food = 0;
            }
            else
            {
                rest.food = double.Parse(rest.foodamountLbl.Text);
            }
            if (oilamountLbl.Text == "")
            {
                rest.oil = 0;
            }
            else
            {
                rest.oil = double.Parse(oilamountLbl.Text);
            }
        }

        private void oilcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceLblBox.Text = oilcomboBox.SelectedItem.ToString();
        }
        public bool Quantity { get; set; } = false;
        public bool Quantum { get; set; } = false;

        private void quantityBtn_TextChanged(object sender, EventArgs e)
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

        private void quantumBtn_TextChanged(object sender, EventArgs e)
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
        double amount = 0.0;
        double quantity = 0.0;
        double quantum = 0.0;

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
                    quantity = double.Parse(quantityTxb.Text) * double.Parse(priceLblBox.Text);
                    amount = quantity;
                }
                oilamountLbl.Text = amount.ToString();
                Test();
                rest.total = rest.food + rest.oil;
                exit.totalamountLbl.Text = rest.total.ToString();
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
                    quantum = double.Parse(quantumTxb.Text) * double.Parse(priceLblBox.Text);
                    amount = quantum;
                }
                oilamountLbl.Text = amount.ToString();
                Test();
                rest.total = rest.food + rest.oil;
                exit.totalamountLbl.Text = rest.total.ToString();
            }
            catch { }
        }
    }
}
