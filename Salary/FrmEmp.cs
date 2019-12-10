using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarsiMessageBox;

namespace Salary
{
    public partial class FrmEmp : FrmTemplate
    {
        public string city = "";

        int ID;

        RandomNumbers rnd = new RandomNumbers();

        string pic = "defult.png", doc;

        public FrmEmp()
        {
            InitializeComponent();
            InitializeBinding();

        }

        public void InitializeBinding()
        {

        }

        public FrmEmp(PersonModel p)
        {
            InitializeComponent();
            btnsave.Text = "ویرایش";
            ID = p.ID;
            txtname.Text = p.Name;
            txtfamily.Text = p.Family;
            txtbimenum.Text = p.BimeNum;
            txtempcode.Text = p.EmpCode;
            txtfathername.Text = p.FatherName;
            txtnationalcode.Text = p.NationalCode;
            txtshsh.Text = p.EmpShSh;
            txtmsh1.Text = p.EmpMSh1;
            txtmsh2.Text = p.EmpMSh2;
            txtcitysodor.Text = p.CitySodor;
            txtcodecitysodor.Text = p.CityCodeSodor;
            txtbakhshsodor.Text = p.BakhshSodor;
            txtcitytavalod.Text = p.CityTavalod;
            txtcodetavalod.Text = p.CityTavalodCode;
            txtcountry.Text = p.CountryTavalod;
            txtcodecountry.Text = p.CountryTavalodCode;
            txttavaloddate.Text = p.TavalodDate.ToString();
            txtjobname.Text = p.Job;
            txtjobcode.Text = p.JobCode;
            if (p.Sex == "مرد")
            {
                cmbSex.SelectedItem = "مرد";
            }
            else if (p.Sex == "زن")
            {
                cmbSex.SelectedItem = "زن";
            }

            if (p.Married == "متاهل")
            {
                cmbMarrid.SelectedItem = "متاهل";
            }
            else if (p.Married == "مجرد")
            {
                cmbMarrid.SelectedItem = "مجرد";
            }
            txtchild.Value = Convert.ToInt32(p.Child);

            if (p.National == "ایرانی")
            {
                cmbNation.SelectedItem = "ایرانی";
            }
            else if (p.National == "غیر ایرانی")
            {
                cmbNation.SelectedItem = "غیر ایرانی";
            }

            cmbEducation.SelectedValue=p.Education;
            txtbranch.Text = p.Branch;
            txtunivercity.Text = p.UniverCity;
            txtyear.Text = p.YearEducation.ToString();
            txttell.Text = p.Tell;
            txttellcode.Text = p.CodeTell;
            txtmobile.Text = p.Mobile;
            txtemail.Text = p.Email;
            txtaddress.Text = p.Address;
            txtpost.Text = p.Post;
            txtjobnum.Text = p.JobNum;
            txtjobdate.Text = p.JobDate.ToString();
            txtbankname.Text = p.BankName;
            txtbanknum.Text = p.Banknum;
            txtbankcard.Text = p.BankCard;
            pic = p.Pic;
            if (File.Exists(Application.StartupPath + "\\Photo\\" + pic))
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\Photo\\" + pic);

            }


        }

        private void FrmEmp_Load(object sender, EventArgs e)
        {
            LoadEducation();
        }

        public void DigitNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        public void LoadEducation()
        {
            List<EducationModel> e = new List<EducationModel>();

            e = SqlliteDataAccess.LoadEducation();

            cmbEducation.DataSource = e;
            cmbEducation.DisplayMember = "Name";
            //cmbEducation.SelectedValue = "Code";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog1.Filter = "All Files|*.*|jpg Files|*.jpg|png Files|*.png|gif Files|*.gif|bmp Files|*.bmp";
                openFileDialog1.FileName = String.Empty;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    pic = txtempcode.Text + (rnd.rand(000, 999) + ".jpg").ToString();
                    File.Copy(openFileDialog1.FileName, Application.StartupPath + "\\Photo\\" + pic);

                }

            }
            catch (Exception )
            {
                MessageBox.Show("لطفا یک فایل با پسوندمعتبر انتخاب نمایید", "فایل نا معتبر است", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bPersianCalenderTextBox1_TextChanged(object sender, EventArgs e)
        {
            txttavaloddate.Text = bPersianCalenderTextBox1.Text;
        }

        private void tarikh_TextChanged(object sender, EventArgs e)
        {
            txtjobdate.Text = tarikh.Text;
        }

        private void btnShahreMahleTavalod_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //try
            //{

                PersonModel p = new PersonModel();

                p.Name = txtname.Text;
                p.Family = txtfamily.Text;
                p.BimeNum = txtbimenum.Text;                //3
                p.EmpCode = txtempcode.Text;                //4
                p.FatherName = txtfathername.Text;          //5
                p.NationalCode = txtnationalcode.Text;      //6
                p.EmpShSh = txtshsh.Text;                   //7
                p.EmpMSh1 = txtmsh1.Text;                   //8
                p.EmpMSh2 = txtmsh2.Text;                   //9
                p.CitySodor = txtcitysodor.Text;            //10
                p.CityCodeSodor = txtcodecitysodor.Text;    //11
                p.BakhshSodor = txtbakhshsodor.Text;        //12
                p.CityTavalod = txtcitytavalod.Text;        //13
                p.CityTavalodCode = txtcodetavalod.Text;    //14
                p.CountryTavalod = txtcountry.Text;         //15
                p.CountryTavalodCode = txtcodecountry.Text; //16
                //p.TavalodDate = Convert.ToInt32(txttavaloddate.Text.Replace("/",""));  //17
                p.Job = txtjobname.Text;            //18
                p.JobCode = txtjobcode.Text;        //19
                //p.Sex = cmbSex.SelectedItem.ToString();     //20
                //p.Married = cmbMarrid.SelectedItem.ToString();  //21
                p.Child = txtchild.Value.ToString();    //22
                //p.National = cmbNation.SelectedItem.ToString();     //23
                p.Education=cmbEducation.SelectedValue.ToString()  ;//FMessageBox.Show(cmbEducation.SelectedValue.ToString());    //24
                p.Branch = txtbranch.Text;      //25
                p.UniverCity = txtunivercity.Text;      //26
                //p.YearEducation = Convert.ToInt32(txtyear.Text);       //27
                p.Tell = txttell.Text;      //28
                p.CodeTell = txttellcode.Text;  //29
                p.Mobile = txtmobile.Text;      //30
                     
            
                try
                {
                    //var eMailValidator = new System.Net.Mail.MailAddress(txtemail.Text);
                    //p.Email = eMailValidator.ToString();
            }
            catch (FormatException ex)
                {
                    FMessageBox.Show("آدرس ایمیل درست وارد کنید");
                    return;
                }

                p.Address = txtaddress.Text;    //32
                p.Post = txtpost.Text;          //33
                p.JobNum = txtjobnum.Text;      //34
                //p.JobDate = Convert.ToInt32(txtjobdate.Text.Replace("/", ""));  //35
                p.BankName = txtbankname.Text;      //36
                p.Banknum = txtbanknum.Text;        //37
                p.BankCard = txtbankcard.Text;      //38
                p.Pic = pic;                        //39
    

                if (btnsave.Text=="ویرایش")
                {
                    p.ID = ID;
                    SqlliteDataAccess.EditPerson(p);
                    FMessageBox.Show("با موفقیت ویرایش شد", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);

                }
                else
                {
                    SqlliteDataAccess.SavePerson(p);
                    FMessageBox.Show("با موفقیت ثبت شد", "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Information);
                }
                FrmViewEmp vm = new FrmViewEmp();
                vm.InitializeBinding();
                
                this.Close();

     
            //}
            //catch (Exception ex)
            //{

            //    FMessageBox.Show(ex.Message, "پیام", FMessageBoxButtons.OK, FMessageBoxIcons.Warning);

            //}
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
          

        }

      

        private void txtyear_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);
        }

        private void txttellcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txttell_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtnationalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtbimenum_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtempcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtpost_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtbankcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtbanknum_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

        private void txtshsh_KeyPress(object sender, KeyPressEventArgs e)
        {
            DigitNumber(sender, e);

        }

    
        private void txtemail_Validating(object sender, CancelEventArgs e)

        {

            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtemail.Text.Length > 0)

            {

                if (!rEMail.IsMatch(txtemail.Text))

                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtemail.SelectAll();

                    e.Cancel = true;

                }

            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string s = "Citysodor";
            FrmCity fc = new FrmCity(s);
            fc.ShowDialog();
            txtcitysodor.Text = fc.city;
            txtcodecitysodor.Text = fc.code;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string s = "Citytavalod";
            FrmCity fc = new FrmCity(s);
            fc.ShowDialog();
            txtcitytavalod.Text = fc.city;
            txtcodetavalod.Text = fc.code;

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            string s = "Country";
            FrmCity fc = new FrmCity(s);
            fc.ShowDialog();
            txtcountry.Text = fc.city;
            txtcodecountry.Text = fc.code;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            string s = "Job";
            FrmCity fc = new FrmCity(s);
            fc.ShowDialog();
            txtjobname.Text = fc.city;
            txtjobcode.Text = fc.code;
        }

        private void btn_madarek_Click(object sender, EventArgs e)
        {
            try
            {

                openFileDialog2.Filter = "All Files|*.*|jpg Files|*.jpg|png Files|*.png|gif Files|*.gif|bmp Files|*.bmp";
                openFileDialog2.FileName = String.Empty;
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    doc = txtempcode.Text + rnd.rand(000, 999) + ".jpg";
                    pictureBox2.Image = Image.FromFile(openFileDialog2.FileName);
                    txtdoc.Text = openFileDialog2.FileName;
                    File.Copy(openFileDialog2.FileName, Application.StartupPath + "\\Madarek\\" + doc);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("لطفا یک فایل با پسوندمعتبر انتخاب نمایید", "فایل نا معتبر است", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
