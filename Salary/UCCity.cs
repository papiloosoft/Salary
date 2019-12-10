using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarsiMessageBox;

namespace Salary
{
    public partial class UCCity : UserControl
    {
        public UCCity()
        {
            InitializeComponent();
        }

        public List<CityModel> Frmcity = new List<CityModel>();
        private void UCCity_Load(object sender, EventArgs e)
        {
            LoadCity();
        }

        public string Cityu()
        {
            return txtcity.Text;
        }

        private void LoadCity()
        {
            try
            {

                Frmcity = SqlliteDataAccess.LoadCity();

                dgvcity.DataSource = Frmcity;
                dgvcity.Columns["Code"].HeaderText = "کد";
                dgvcity.Columns["Name"].HeaderText = "نام گروه";

            }
            catch (Exception ex)
            {

                FMessageBox.Show(ex.Message, "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
        }

        private void txtcity_TextChanged(object sender, EventArgs e)
        {
            try
            {
               //search= txtcity.Text;
               // Frmcity = SqlliteDataAccess.LoadCity(g);
               // dgvcity.DataSource = Frmcity;
            }
            catch (Exception ex)
            {

                FMessageBox.Show(ex.Message, "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmEmp em = new FrmEmp();
            //em.fill();
            FMessageBox.Show("d");
            this.Visible = false;
        }
    }
}
