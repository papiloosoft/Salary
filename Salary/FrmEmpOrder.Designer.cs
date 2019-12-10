namespace Salary
{
    partial class FrmEmpOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpOrder));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtemp = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(450, 91);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(28, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.UseSelectable = true;
           
            // 
            // txtemp
            // 
            // 
            // 
            // 
            this.txtemp.CustomButton.Image = null;
            this.txtemp.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtemp.CustomButton.Name = "";
            this.txtemp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtemp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtemp.CustomButton.TabIndex = 1;
            this.txtemp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtemp.CustomButton.UseSelectable = true;
            this.txtemp.CustomButton.Visible = false;
            this.txtemp.Lines = new string[] {
        "انتخاب پرسنل"};
            this.txtemp.Location = new System.Drawing.Point(484, 91);
            this.txtemp.MaxLength = 32767;
            this.txtemp.Name = "txtemp";
            this.txtemp.PasswordChar = '\0';
            this.txtemp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtemp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemp.SelectedText = "";
            this.txtemp.SelectionLength = 0;
            this.txtemp.SelectionStart = 0;
            this.txtemp.ShortcutsEnabled = true;
            this.txtemp.Size = new System.Drawing.Size(118, 23);
            this.txtemp.TabIndex = 2;
            this.txtemp.Text = "انتخاب پرسنل";
            this.txtemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtemp.UseSelectable = true;
            this.txtemp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtemp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtemp.Click += new System.EventHandler(this.txtemp_Click);
            // 
            // FrmEmpOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 476);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtemp);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmEmpOrder";
            this.Text = "حکم کارگزینی";
            this.Load += new System.EventHandler(this.FrmEmpOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        public MetroFramework.Controls.MetroTextBox txtemp;
    }
}