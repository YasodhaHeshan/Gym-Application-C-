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
    public partial class Schedules : Form
    {
        public Schedules()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_MassGain_Click(object sender, EventArgs e)
        {
            MassGain obj = new MassGain();
            obj.ShowDialog();
        }

        private void btn_fatLoss_Click(object sender, EventArgs e)
        {
            FatLoss obj = new FatLoss();
            obj.ShowDialog();
        }
    }
}
