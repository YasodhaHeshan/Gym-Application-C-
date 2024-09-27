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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btn_getStart_Click(object sender, EventArgs e)
        {
            Hide();
            GetStrated obj= new GetStrated();
            obj.ShowDialog();
        }

        private void btn_logIn1_Click(object sender, EventArgs e)
        {
            Hide();
            LogIN obj= new LogIN();
            obj.ShowDialog();
        }

        private void btn_continuewithoutlogin_Click(object sender, EventArgs e)
        {
            Hide();
            Home obj= new Home();
            obj.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
