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
            timer.Interval = 1500;
            timer.Tick += Timer_Tick;
            timer.Start();
        }


        private int imageNumber=1;
        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = String.Format(@"images\{0}.jpg",imageNumber);
            imageNumber++;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void openmenuBtn_MouseEnter(object sender, EventArgs e)
        {
            openmenuBtn.BackColor = Color.Transparent;
            openmenuBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            openmenuBtn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void openmenuBtn_Click(object sender, EventArgs e)
        {
            this.label1.Dispose();
            this.label2.Dispose();
            this.panel1.Dispose();
            this.panel2.Dispose();
            this.slidePic.Dispose();
            this.openmenuBtn.Dispose();
            timer.Stop();
            Restaurant rest = new Restaurant();
           
            this.Hide();
            rest.ShowDialog();
            this.Close();
            
        }
    }
}
