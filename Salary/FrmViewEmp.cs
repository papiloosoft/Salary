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
    public partial class FrmViewEmp : FrmTemplate
    {
        public FrmViewEmp()
        {
            InitializeComponent();
            InitializeBinding();
        }
        string hokm;
        public string emp;
        public PersonModel p = new PersonModel();
        List<PersonModel> lpm = new List<PersonModel>();

       public void InitializeBinding()
        {
            lpm = SqlliteDataAccess.LoadPerson();
            dgvperson.DataSource = lpm;

            dgvperson.Columns["Name"].HeaderText = "نام";
            dgvperson.Columns["FatherName"].HeaderText = "نام پدر";
            dgvperson.Columns["NationalCode"].HeaderText = "کد ملی";
            dgvperson.Columns["Family"].HeaderText = " نام خانوادگی";
            dgvperson.Columns["Tell"].HeaderText = " تلفن ";
            dgvperson.Columns["Mobile"].HeaderText = " موبایل ";

            dgvperson.Columns["ID"].Visible = false;
            dgvperson.Columns["BimeNum"].Visible = false;
            dgvperson.Columns["EmpCode"].Visible = false;
            dgvperson.Columns["EmpShSh"].Visible = false;
            dgvperson.Columns["EmpMSh1"].Visible = false;
            dgvperson.Columns["EmpMSh2"].Visible = false;
            dgvperson.Columns["CitySodor"].Visible = false;
            dgvperson.Columns["BakhshSodor"].Visible = false;
            dgvperson.Columns["CityTavalod"].Visible = false;
            dgvperson.Columns["CityCodeSodor"].Visible = false;
            dgvperson.Columns["CityTavalodCode"].Visible = false;
            dgvperson.Columns["CountryTavalod"].Visible = false;
            dgvperson.Columns["CountryTavalodCode"].Visible = false;
            dgvperson.Columns["Job"].Visible = false;
            dgvperson.Columns["JobCode"].Visible = false;
            dgvperson.Columns["Sex"].Visible = false;
            dgvperson.Columns["Married"].Visible = false;
            dgvperson.Columns["Child"].Visible = false;
            dgvperson.Columns["National"].Visible = false;
            dgvperson.Columns["Education"].Visible = false;
            dgvperson.Columns["Branch"].Visible = false;
            dgvperson.Columns["UniverCity"].Visible = false;
            dgvperson.Columns["YearEducation"].Visible = false;
            dgvperson.Columns["CodeTell"].Visible = false;
            dgvperson.Columns["Email"].Visible = false;
            dgvperson.Columns["Address"].Visible = false;
            dgvperson.Columns["Post"].Visible = false;
            dgvperson.Columns["JobNum"].Visible = false;
            dgvperson.Columns["JobDate"].Visible = false;
            dgvperson.Columns["BankName"].Visible = false;
            dgvperson.Columns["Banknum"].Visible = false;
            dgvperson.Columns["BankCard"].Visible = false;
            dgvperson.Columns["Pic"].Visible = false;
            dgvperson.Columns["Doc"].Visible = false;
            dgvperson.Columns["TavalodDate"].Visible = false;
        }

        public FrmViewEmp(string s)
        {
            InitializeComponent();
            hokm = s;
        }

        private void FrmViewEmp_Load(object sender, EventArgs e)
        {
            //LoadPerson();
        }

        private void dgvperson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvperson.CurrentRow.Cells[0].Value != null) p.ID = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value.ToString());
            if (dgvperson.CurrentRow.Cells[1].Value != null) p.Name = dgvperson.CurrentRow.Cells[1].Value.ToString();
            if (dgvperson.CurrentRow.Cells[2].Value != null) p.Family = dgvperson.CurrentRow.Cells[2].Value.ToString();
            if (dgvperson.CurrentRow.Cells[3].Value != null) p.BimeNum = dgvperson.CurrentRow.Cells[3].Value.ToString();
            if (dgvperson.CurrentRow.Cells[4].Value != null) p.EmpCode = dgvperson.CurrentRow.Cells[4].Value.ToString();
            if (dgvperson.CurrentRow.Cells[5].Value != null) p.FatherName = dgvperson.CurrentRow.Cells[5].Value.ToString();
            if (dgvperson.CurrentRow.Cells[6].Value != null) p.NationalCode = dgvperson.CurrentRow.Cells[6].Value.ToString();
            if (dgvperson.CurrentRow.Cells[7].Value != null) p.EmpShSh = dgvperson.CurrentRow.Cells[7].Value.ToString();
            if (dgvperson.CurrentRow.Cells[8].Value != null) p.EmpMSh1 = dgvperson.CurrentRow.Cells[8].Value.ToString();
            if (dgvperson.CurrentRow.Cells[9].Value != null) p.EmpMSh2 = dgvperson.CurrentRow.Cells[9].Value.ToString();
            if (dgvperson.CurrentRow.Cells[10].Value != null) p.CitySodor = dgvperson.CurrentRow.Cells[10].Value.ToString();
            if (dgvperson.CurrentRow.Cells[11].Value != null) p.CityCodeSodor = dgvperson.CurrentRow.Cells[11].Value.ToString();
            if (dgvperson.CurrentRow.Cells[12].Value != null) p.BakhshSodor = dgvperson.CurrentRow.Cells[12].Value.ToString();
            if (dgvperson.CurrentRow.Cells[13].Value != null) p.CityTavalod = dgvperson.CurrentRow.Cells[13].Value.ToString();
            if (dgvperson.CurrentRow.Cells[14].Value != null) p.CityTavalodCode = dgvperson.CurrentRow.Cells[14].Value.ToString();
            if (dgvperson.CurrentRow.Cells[15].Value != null) p.CountryTavalod = dgvperson.CurrentRow.Cells[15].Value.ToString();
            if (dgvperson.CurrentRow.Cells[16].Value != null) p.CountryTavalodCode = dgvperson.CurrentRow.Cells[16].Value.ToString();
            if (dgvperson.CurrentRow.Cells[17].Value != null) p.TavalodDate = Convert.ToInt32(dgvperson.CurrentRow.Cells[17].Value.ToString());
            if (dgvperson.CurrentRow.Cells[18].Value != null) p.Job = dgvperson.CurrentRow.Cells[18].Value.ToString();
            if (dgvperson.CurrentRow.Cells[19].Value != null) p.JobCode = dgvperson.CurrentRow.Cells[19].Value.ToString();
            if (dgvperson.CurrentRow.Cells[20].Value != null) p.Sex = dgvperson.CurrentRow.Cells[20].Value.ToString();
            if (dgvperson.CurrentRow.Cells[21].Value != null) p.Married = dgvperson.CurrentRow.Cells[21].Value.ToString();
            if (dgvperson.CurrentRow.Cells[22].Value != null) p.Child = dgvperson.CurrentRow.Cells[22].Value.ToString();
            if (dgvperson.CurrentRow.Cells[23].Value != null) p.National = dgvperson.CurrentRow.Cells[23].Value.ToString();
            if (dgvperson.CurrentRow.Cells[24].Value != null) p.Education = dgvperson.CurrentRow.Cells[24].Value.ToString();
            if (dgvperson.CurrentRow.Cells[25].Value != null) p.Branch = dgvperson.CurrentRow.Cells[25].Value.ToString();
            if (dgvperson.CurrentRow.Cells[26].Value != null) p.UniverCity = dgvperson.CurrentRow.Cells[26].Value.ToString();
            if (dgvperson.CurrentRow.Cells[27].Value != null) p.YearEducation = Convert.ToInt32(dgvperson.CurrentRow.Cells[27].Value.ToString());
            if (dgvperson.CurrentRow.Cells[28].Value != null) p.Tell = dgvperson.CurrentRow.Cells[28].Value.ToString();
            if (dgvperson.CurrentRow.Cells[29].Value != null) p.CodeTell = dgvperson.CurrentRow.Cells[29].Value.ToString();
            if (dgvperson.CurrentRow.Cells[30].Value != null) p.Mobile = dgvperson.CurrentRow.Cells[30].Value.ToString();
            if (dgvperson.CurrentRow.Cells[31].Value != null) p.Email = dgvperson.CurrentRow.Cells[31].Value.ToString();
            if (dgvperson.CurrentRow.Cells[32].Value != null) p.Address = dgvperson.CurrentRow.Cells[32].Value.ToString();
            if (dgvperson.CurrentRow.Cells[33].Value != null) p.Post = dgvperson.CurrentRow.Cells[33].Value.ToString();
            if (dgvperson.CurrentRow.Cells[34].Value != null) p.JobNum = dgvperson.CurrentRow.Cells[34].Value.ToString();
            if (dgvperson.CurrentRow.Cells[35].Value != null) p.JobDate = Convert.ToInt32(dgvperson.CurrentRow.Cells[35].Value.ToString());
            if (dgvperson.CurrentRow.Cells[36].Value != null) p.BankName = dgvperson.CurrentRow.Cells[36].Value.ToString();
            if (dgvperson.CurrentRow.Cells[37].Value != null) p.Banknum = dgvperson.CurrentRow.Cells[37].Value.ToString();
            if (dgvperson.CurrentRow.Cells[38].Value != null) p.BankCard = dgvperson.CurrentRow.Cells[38].Value.ToString();
            if (dgvperson.CurrentRow.Cells[39].Value != null) p.Pic = dgvperson.CurrentRow.Cells[39].Value.ToString();

            if (hokm == "feo")
            {

                emp = dgvperson.CurrentRow.Cells[1].Value.ToString() + " " + dgvperson.CurrentRow.Cells[2].Value.ToString();
                this.Close();
            }
            else
            {
                FrmEmp mp = new FrmEmp(p);
                
                mp.ShowDialog();

                InitializeBinding();
            }
           
        }

    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmEmp fe = new FrmEmp();
            fe.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dgvperson.CurrentRow.Cells[0].Value != null)
            {
                PersonModel pe = new PersonModel();

                pe.ID 
                 = Convert.ToInt32(dgvperson.CurrentRow.Cells[0].Value.ToString());
                SqlliteDataAccess.DeletePerson(pe);
                FMessageBox.Show("با موفقیت حذف شد", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                InitializeBinding();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvperson.DataSource = lpm.Where(x => x.Name.Contains(txtsearch.Text) || x.Family.Contains(txtsearch.Text) || x.NationalCode.Contains(txtsearch.Text)).ToList();

            }
            catch (NullReferenceException ex)
            {
                // Do something with e, please.
            }
        }
    }
}
