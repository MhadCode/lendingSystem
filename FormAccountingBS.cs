using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lending_System
{
    public partial class FormAccountingBS : Form
    {
        public FormAccountingBS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormViewBillingStatement fform = new FormViewBillingStatement();
            fform.ShowDialog();
        }
    }
}
