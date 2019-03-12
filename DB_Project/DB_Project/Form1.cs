using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB_Project.Forms;

namespace DB_Project
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        Timer tmr;
        private void frmSplash_Shown(object sender, EventArgs e)
        {
            // Remve Border Of Splash Screen
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ControlBox = false;
            this.Text = "";

            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;

        }

        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            frmDashboard mf = new frmDashboard();

            mf.Show();

            //hide this form

            this.Hide();

            

        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
