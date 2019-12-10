using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarsiMessageBox;

namespace Salary
{
    public partial class FrmType : FrmTemplate
    {
        public FrmType()
        {
            InitializeComponent();
            InitializeBinding();
        }

        public TypeSalaryModel ts = new TypeSalaryModel();
        List<TypeSalaryModel> lt = new List<TypeSalaryModel>();

        public void InitializeBinding()
        {
            lt = SqlliteDataAccess.LoadType();
            dgvhokm.DataSource = lt;

            dgvhokm.Columns[0].Visible = false;
            dgvhokm.Columns[1].HeaderText = "نام";
    
        }
      

       

        private void button1_Click(object sender, EventArgs e)
        {
            TypeSalaryModel t = new TypeSalaryModel();
            t.Name = txtname.Text;
            SqlliteDataAccess.SaveType(t);
            FMessageBox.Show("با موفقیت ذخیره شد", "پیام");
            InitializeBinding();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TypeSalaryModel t = new TypeSalaryModel();
            t.ID = Convert.ToInt32(dgvhokm.CurrentRow.Cells[0].Value);
            SqlliteDataAccess.DeleteType(t);
            FMessageBox.Show("با موفقیت حذف شد", "پیام");
            txtname.ResetText();
            InitializeBinding();

        }

        private void dgvhokm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dgvhokm.CurrentRow.Cells[1].Value.ToString();
            ts.ID = Convert.ToInt32(dgvhokm.CurrentRow.Cells[0].Value);
            ts.Name = dgvhokm.CurrentRow.Cells[1].ToString();
        }

        private void dgvhokm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             txtname.Text = dgvhokm.CurrentRow.Cells[1].Value.ToString();
            ts.ID = Convert.ToInt32(dgvhokm.CurrentRow.Cells[0].Value);
            ts.Name = dgvhokm.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
            dgvhokm.DataSource = lt.Where(x => x.Name.Contains(txtname.Text)).ToList();
            
        }

        private void FrmType_Load(object sender, EventArgs e)
        {

        }
    }
}
