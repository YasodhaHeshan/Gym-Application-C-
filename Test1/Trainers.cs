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
    public partial class Trainers : Form
    {
        public Trainers()
        {
            InitializeComponent();
        }

        private void btn_showTrainers_Click(object sender, EventArgs e)
        {
            SelectTrainer obj=new SelectTrainer();
            obj.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
