//
// CTA Ridership Analysis.
//
// Alex Viznytsya
// Fall 2017
//

using System;
using System.Data;
using System.Windows.Forms;

namespace CTA_Analysis
{
    public partial class Top10Form : Form
    {
        public Top10Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setDataGrid(DataTable dt)
        {
            this.dataGrid.DataSource = dt;
            this.dataGrid.Refresh();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
