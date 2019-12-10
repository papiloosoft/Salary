using FarsiMessageBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class FrmHokm : FrmTemplate
    {
        public FrmHokm()
        {
            InitializeComponent();
            InitializeBinding();
        }

        PersonModel p = new PersonModel();
        TypeSalaryModel t = new TypeSalaryModel();
        List<TypeSalaryModel> st = new List<TypeSalaryModel>();
       
        public string[] arr;

        public void InitializeBinding()
        {
            List<HokmModel> h = new List<HokmModel>();
          
         
                h = SqlliteDataAccess.LoadHokme();

            dgvhokm.DataSource = h.Where(x => x.PersonID == p.ID).ToList();
            


            dgvhokm.Columns["ID"].Visible = false;
            dgvhokm.Columns["PersonID"].Visible = false;
            dgvhokm.Columns["Name"].HeaderText = "نام";
            dgvhokm.Columns["Price"].HeaderText = "مبلغ";


            st = SqlliteDataAccess.LoadType();
            arr = new string[st.Count];
            for (int i = 0; i < st.Count; i++)
            {
                arr[i] = st[i].Name.ToString();
            }

           
        }

        



      

        private void button1_Click(object sender, EventArgs e)
        {
            HokmModel h = new HokmModel();

            h.Name = txtname.Text;
            h.Price= Convert.ToInt32(txtprice.Text);
            h.PersonID = p.ID;

            SqlliteDataAccess.SaveHokm(h);
            InitializeBinding();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            HokmModel h = new HokmModel();

            h.ID = Convert.ToInt32(dgvhokm.CurrentRow.Cells[0].Value.ToString());

            SqlliteDataAccess.DeleteHokm(h);
            FMessageBox.Show("با موفقیت حذف شد", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

            InitializeBinding();
        }

        private void dgvhokm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dgvhokm.CurrentRow.Cells[1].Value.ToString();
            txtprice.Text = dgvhokm.CurrentRow.Cells[2].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
           
                string s = "feo";
                FrmViewEmp ev = new FrmViewEmp(s);
                ev.ShowDialog();
                txtemp.Text = ev.emp;
                p = ev.p;
                InitializeBinding();


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            FrmType ft = new FrmType();
            ft.ShowDialog();
            txtname.Text = ft.ts.Name;
            t = ft.ts;
            
        }

        void predict()
        {

            txtname.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();

            col.AddRange(arr);
            
            txtname.AutoCompleteCustomSource = col;
        }



        private void txtname_TextChanged(object sender, EventArgs e)
        {
            predict();
        }
    }
}
