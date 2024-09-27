using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Test1
{
    public partial class MembershipReport : Form
    {
        public MembershipReport()
        {
            InitializeComponent();
        }

        private void MembershipReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-NK2RF8T;Initial Catalog=PowerFit;Integrated Security=True");


        private void btn_load_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select*from MembershipPlans where MembershipName='"+cmb_mPlans.Text+"'", con);
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource sourse=new ReportDataSource("DataSet1",dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\DELL\Desktop\BackUp\7\Test1\Membership_Plans.rdlc";
            reportViewer1.LocalReport.DataSources.Add(sourse);
            reportViewer1.RefreshReport();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
