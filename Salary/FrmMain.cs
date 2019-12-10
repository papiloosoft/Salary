using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class FrmMain: FrmTemplate
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection("URI=file:DBLaundry.db");

  

     

        private void metroTile2_Click(object sender, EventArgs e)
        {
          
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
          
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmEmp mp = new FrmEmp();
            mp.ShowDialog();
        }

      

        private void dgvperson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void پرسنلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewEmp ve = new FrmViewEmp();
            ve.ShowDialog();
        }

        private void حکمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpOrder eo = new FrmEmpOrder();
            eo.ShowDialog();
        }

        private void حکمToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHokm fh = new FrmHokm();
            fh.ShowDialog();
        }
    }
}
