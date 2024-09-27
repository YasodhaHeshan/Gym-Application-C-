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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btn_membership_Click(object sender, EventArgs e)
        {
            MembershipReport obj = new MembershipReport();
            obj.ShowDialog();
        }

        private void btn_schedule_Click(object sender, EventArgs e)
        {
            ScheduleReport obj = new ScheduleReport();
            obj.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_trainers_Click(object sender, EventArgs e)
        {
            TrainersReport obj = new TrainersReport();
            obj.ShowDialog();
        }
    }
}
