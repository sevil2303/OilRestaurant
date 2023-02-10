using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{    
    public partial class Restaurant : Form
    {
       // OilStation oilStation = new OilStation();
        public Restaurant()
        {       
            InitializeComponent();
            this.BackColor = Color.FromArgb(24, 25, 26);
            //hamburgerpanel.BackColor=Color.FromArgb(24, 25, 26);
            Meals.BackColor = Color.FromArgb(24, 25, 26);
            Juices.BackColor = Color.FromArgb(24, 25, 26);
        }
        double foodamount = 0.0;
        double pizza = 0.0;
        double hamburger = 0.0;
        double frenchfries = 0.0;
        double coke = 0.0;
        double redbull = 0.0;
        double juice = 0.0;
        public double total = 0.0;
        public double food = 0.0;
        public double oil = 0.0;

        private void hamburgerquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (hamburgerquantityTxb.Text == "")
            {
                foodamount -= hamburger;
                hamburger = 0;
                foodamountLbl.Text = foodamount.ToString();
            }
            else
            {
                hamburger = double.Parse(hamburgerpriceLbl.Text) * (double.Parse(hamburgerquantityTxb.Text));
                foodamount = hamburger;
                foodamountLbl.Text = foodamount.ToString();
            }
            //total = double.Parse(foodamountLbl.Text) + double.Parse(oilStation.oilamountLbl.Text);
            //totalamountLbl.Text = total.ToString();
        }

        private void pizzaquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (pizzaquantityTxb.Text == "")
            {
                foodamount -= pizza;
                pizza = 0;
                foodamountLbl.Text = foodamount.ToString();
            }
            else
            {
                pizza = double.Parse(pizzapriceLbl.Text) * (double.Parse(pizzaquantityTxb.Text));
                foodamount = hamburger+pizza;
                foodamountLbl.Text = foodamount.ToString();
            }
            //total = double.Parse(foodamountLbl.Text) + double.Parse(oilStation.oilamountLbl.Text);
            //totalamountLbl.Text = total.ToString();
        }

        private void frenchfriesquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (frenchfriesquantityTxb.Text == "")
            {
                foodamount -= frenchfries;
                frenchfries = 0;
                foodamountLbl.Text = foodamount.ToString();
            }
            else
            {
                frenchfries = double.Parse(frenchfriespriceLbl.Text) * (double.Parse(frenchfriesquantityTxb.Text));
                foodamount = hamburger+pizza+frenchfries;
                foodamountLbl.Text = foodamount.ToString();
            }
           // total = double.Parse(foodamountLbl.Text) + double.Parse(oilStation.oilamountLbl.Text);
            //totalamountLbl.Text = total.ToString();
        }

        private void cokequantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (cokequantityTxb.Text == "")
            {
                foodamount -= coke;
                coke = 0;
                foodamountLbl.Text = foodamount.ToString();
            }
            else
            {
                coke = double.Parse(cokepriceLbl.Text) * (double.Parse(cokequantityTxb.Text));
                foodamount = coke;
                foodamountLbl.Text = foodamount.ToString();
            }
           // total = double.Parse(foodamountLbl.Text) + double.Parse(oilStation.oilamountLbl.Text);
            //totalamountLbl.Text = total.ToString();
        }

        private void redbullquantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (redbullquantityTxb.Text == "")
            {
                foodamount -= redbull;
                redbull = 0;
                foodamountLbl.Text = foodamount.ToString();
            }
            else
            {
                redbull = double.Parse(redbullpriceLlbl.Text) * (double.Parse(redbullquantityTxb.Text));
                foodamount = redbull;
                foodamountLbl.Text = foodamount.ToString();
            }
            //total = double.Parse(foodamountLbl.Text) + double.Parse(oilStation.oilamountLbl.Text);
            //totalamountLbl.Text = total.ToString();
        }

        private void juicequantityTxb_TextChanged(object sender, EventArgs e)
        {
            if (juicequantityTxb.Text == "")
            {
                foodamount -= juice;
                juice = 0;
                foodamountLbl.Text = foodamount.ToString();
            }
            else
            {
                juice = double.Parse(juicepriceLbl.Text) * (double.Parse(juicequantityTxb.Text));
                foodamount = juice;
                foodamountLbl.Text = foodamount.ToString();
            }
            //total = double.Parse(foodamountLbl.Text) + double.Parse(oilStation.oilamountLbl.Text);
            //totalamountLbl.Text = total.ToString();
        }

        private void oilBtn_Click(object sender, EventArgs e)
        {
            //this.oilBtn.Dispose();
            //this.exitBtn.Dispose();
            //this.label1.Dispose();
            //this.label2.Dispose();
            //this.label3.Dispose();
            //this.label4.Dispose();
            //this.label5.Dispose();
            //this.label6.Dispose();
            //this.label7.Dispose();
            //this.label8.Dispose();
            //this.cokepriceLbl.Dispose();
            //this.foodamountLbl.Dispose();
            //this.frenchfriespriceLbl.Dispose();
            //this.hamburgerpriceLbl.Dispose();
            //this.juicepriceLbl.Dispose();
            //this.pizzapriceLbl.Dispose();
            //this.cokequantityTxb.Dispose();
            //this.frenchfriesquantityTxb.Dispose();
            //this.hamburgerquantityTxb.Dispose();
            //this.juicequantityTxb.Dispose();
            //this.pizzaquantityTxb.Dispose();
            //this.redbullquantityTxb.Dispose();
            //this.panel1.Dispose();
            //this.panel2.Dispose();
            //this.panel3.Dispose();
            //this.panel4.Dispose();
            //this.panel5.Dispose();
            //this.panel6.Dispose();
            //this.pictureBox1.Dispose();
            //this.pictureBox10.Dispose();
            //this.pictureBox11.Dispose();
            //this.pictureBox2.Dispose();
            //this.pictureBox3.Dispose();
            //this.pictureBox4.Dispose();
            //this.pictureBox5.Dispose();
            //this.pictureBox6.Dispose();
            this.Dispose();
            OilStation oilStation = new OilStation();

            this.Hide();
            oilStation.ShowDialog();
            this.Close();
        }
    }
}
