using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University.UI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.баллы_по_группамTableAdapter.Fill(this.university_ds.Баллы_по_группам);
            this.reportViewer1.RefreshReport();
        }
    }
}
