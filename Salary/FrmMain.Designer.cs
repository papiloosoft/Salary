namespace Salary
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.تعاریفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.پرسنلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حکمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حکمToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعاریفToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // تعاریفToolStripMenuItem
            // 
            this.تعاریفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.پرسنلToolStripMenuItem,
            this.حکمToolStripMenuItem1,
            this.حکمToolStripMenuItem});
            this.تعاریفToolStripMenuItem.Name = "تعاریفToolStripMenuItem";
            this.تعاریفToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.تعاریفToolStripMenuItem.Text = "تعاریف";
            // 
            // پرسنلToolStripMenuItem
            // 
            this.پرسنلToolStripMenuItem.Name = "پرسنلToolStripMenuItem";
            this.پرسنلToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.پرسنلToolStripMenuItem.Text = "پرسنل";
            this.پرسنلToolStripMenuItem.Click += new System.EventHandler(this.پرسنلToolStripMenuItem_Click);
            // 
            // حکمToolStripMenuItem
            // 
            this.حکمToolStripMenuItem.Name = "حکمToolStripMenuItem";
            this.حکمToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.حکمToolStripMenuItem.Text = "حکم پرسنل";
            this.حکمToolStripMenuItem.Click += new System.EventHandler(this.حکمToolStripMenuItem_Click);
            // 
            // حکمToolStripMenuItem1
            // 
            this.حکمToolStripMenuItem1.Name = "حکمToolStripMenuItem1";
            this.حکمToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.حکمToolStripMenuItem1.Text = "حکم";
            this.حکمToolStripMenuItem1.Click += new System.EventHandler(this.حکمToolStripMenuItem1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Papiloo.ir";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem تعاریفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem پرسنلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حکمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حکمToolStripMenuItem1;
    }
}