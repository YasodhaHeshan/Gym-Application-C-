using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            LogIN obj = new LogIN();
            obj.ShowDialog();
        }

        private void btn_getStarted_Click(object sender, EventArgs e)
        {
            GetStrated obj = new GetStrated();
            obj.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minmized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_membership_Click(object sender, EventArgs e)
        {
            Membership obj = new Membership();
            obj.ShowDialog();
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            Schedules obj = new Schedules();
            obj.ShowDialog();
        }

        private void btn_trainers_Click(object sender, EventArgs e)
        {
            Trainers obj = new Trainers();
            obj.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_aboutUs_Click(object sender, EventArgs e)
        {
            AboutUs obj = new AboutUs();
            obj.ShowDialog();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            Reports obj = new Reports();
            obj.ShowDialog();
        }
    }
}
