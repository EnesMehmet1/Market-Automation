using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Concrete;
using Trple1._1.Reports;

namespace Trple1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void satis_btn_Click(object sender, EventArgs e)
        {
            SalesView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Context cs = new Context();
            //cs.Database.Create();
        }

        private void Stok_Btn_Click(object sender, EventArgs e)
        {
            stockView();
        }

        private void bilgisayaraYedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.ExportToXls("C:\\Users\\yildi\\Desktop\\BilgisayarAglari\\Report1.xls");


        }

        private void Rapor_btn_Click(object sender, EventArgs e)
        {
            reportView();
        }

        private void Cari_btn_Click(object sender, EventArgs e)
        {
            cariView();
        }

        private void satışEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesView();
        }
        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportView();
        }

        private void cariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cariView();
        }

        private void stokEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockView();
        }

        public void SalesView()
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
        public void stockView()
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
        public void reportView()
        {
            ReportFrm rf = new ReportFrm();
            rf.ShowDialog();
        }
        public void cariView()
        {
            CariFrm cf = new CariFrm();
            cf.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void interneteYedekAlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
