using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using FarsiMessageBox;

namespace Salary
{
    public partial class FrmCity : FrmTemplate
    {
        public FrmCity(string s)
        {
            if (s == "Citysodor" || s == "Citytavalod")
            {
                type = "City";
                city = s;
            }
            else
            {
                type = s;
            }
               
            InitializeComponent();
        }

        public string search;
        public string type;
        public string city;
        public string code;

        SQLiteConnection con = new SQLiteConnection("URI=file:DBLaundry.db");

        public List<CityModel> Frmcity = new List<CityModel>();
        
        private void FrmCity_Load(object sender, EventArgs e)
        {
            if (city == "Citysodor" || city == "Citytavalod")
            {
                LoadCity();
            }
            else if (type=="Country" )
            {
                LoadCountry();
            }
            else if (type == "Job")
            {
                LoadJob();
            }

            txtcity.Focus();
                
        }

        private void LoadCity()
        {
            try
            {

                Frmcity = SqlliteDataAccess.LoadCity("",type);

                dgvcity.DataSource = Frmcity;
                dgvcity.Columns["Code"].HeaderText = "کد";
                dgvcity.Columns["Name"].HeaderText = "نام شهر";

            }
            catch (Exception ex)
            {

                FMessageBox.Show(ex.Message, "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
        }

        private void LoadCountry()
        {
            try
            {

                Frmcity = SqlliteDataAccess.LoadCity("", type);

                dgvcity.DataSource = Frmcity;
                dgvcity.Columns["Code"].HeaderText = "کد";
                dgvcity.Columns["Name"].HeaderText = "نام کشور";

            }
            catch (Exception ex)
            {

                FMessageBox.Show(ex.Message, "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
        }

        private void LoadJob()
        {
            try
            {

                Frmcity = SqlliteDataAccess.LoadCity("", type);

                dgvcity.DataSource = Frmcity;
                dgvcity.Columns["Code"].HeaderText = "کد";
                dgvcity.Columns["Name"].HeaderText = "نام شغل";

            }
            catch (Exception ex)
            {

                FMessageBox.Show(ex.Message, "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
        }

     
   
       

      

        private void txtcity_Click(object sender, EventArgs e)
        {
         
        }

        private void dgvcity_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            city = dgvcity.CurrentRow.Cells[1].Value.ToString();
            code = dgvcity.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                search = txtcity.Text;

                Frmcity = SqlliteDataAccess.LoadCity(search, type);
                dgvcity.DataSource = Frmcity;
            }
            catch (Exception ex)
            {

                FMessageBox.Show(ex.Message, "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
        }
    }
}
