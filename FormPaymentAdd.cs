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
    public partial class FormPaymentAdd : Form
    {
        public FormPaymentAdd()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPayee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPayee_DoubleClick(object sender, EventArgs e)
        {
            FormPayeeCustomer ff = new FormPayeeCustomer();
            ff.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPayeeAdd ff = new FormPayeeAdd();
            ff.ShowDialog();

        }
    }
}
