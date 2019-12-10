namespace Salary
{
    partial class UCCity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcity = new System.Windows.Forms.TextBox();
            this.dgvcity = new System.Windows.Forms.DataGridView();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(91, 9);
            this.txtcity.Name = "txtcity";
            this.txtcity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtcity.Size = new System.Drawing.Size(192, 20);
            this.txtcity.TabIndex = 3;
            this.txtcity.TextChanged += new System.EventHandler(this.txtcity_TextChanged);
            // 
            // dgvcity
            // 
            this.dgvcity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvcity.Location = new System.Drawing.Point(0, 41);
            this.dgvcity.Name = "dgvcity";
            this.dgvcity.ReadOnly = true;
            this.dgvcity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvcity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcity.Size = new System.Drawing.Size(286, 234);
            this.dgvcity.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(10, 7);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "تایید";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // UCCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.dgvcity);
            this.Name = "UCCity";
            this.Size = new System.Drawing.Size(286, 275);
            this.Load += new System.EventHandler(this.UCCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcity;
        public System.Windows.Forms.DataGridView dgvcity;
        private System.Windows.Forms.Button btnOk;
    }
}
