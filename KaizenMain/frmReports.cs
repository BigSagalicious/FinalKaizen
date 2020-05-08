using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace KaizenMain
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void tabSales_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void btnCustDets_Click(object sender, EventArgs e)
        {
            var cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\gareth\Source\Repos\BigSagalicious\FinalKaizen\KaizenMain\CustomerContacts.rpt");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
        //VIEW APPOINTMENT REPORT
        private void roundButton1_Click(object sender, EventArgs e)
        {
            var cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\gareth\Source\Repos\BigSagalicious\FinalKaizen\KaizenMain\AppsByMonth.rpt");
            crystalReportViewer2.ReportSource = cryRpt;
            crystalReportViewer2.Refresh();
        }

        private void btnCustPayments_Click(object sender, EventArgs e)
        {
            var cryRpt = new ReportDocument();
            cryRpt.Load(@"C:\Users\gareth\Source\Repos\BigSagalicious\FinalKaizen\KaizenMain\CustomerPayments.rpt");
            crystalReportViewer3.ReportSource = cryRpt;
            crystalReportViewer3.Refresh();
        }
    }
}
