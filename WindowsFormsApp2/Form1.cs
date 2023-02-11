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
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(24, 25, 26);
            //panel1.BackColor = Color.FromArgb(207, 181, 59);
            //panel2.BackColor = Color.FromArgb(207, 181, 59);
           
        }


        private void openmenuBtn_MouseEnter(object sender, EventArgs e)
        {
            openmenuBtn.BackColor = Color.Transparent;
            openmenuBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            openmenuBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void openmenuBtn_Click(object sender, EventArgs e)
        {
            
            timer.Stop();
            Restaurant rest = new Restaurant();
            OilStation oilStation = new OilStation();
            oilStation.oilamountLbl.Text = "";
            this.Hide();
            rest.ShowDialog();
            this.Close();
            
        }
    }
}
