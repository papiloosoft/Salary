using MetroFramework.Forms;
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
    public partial class FrmTemplate : MetroForm
    {
        public FrmTemplate()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void FrmTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
