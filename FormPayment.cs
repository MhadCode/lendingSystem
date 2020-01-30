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
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPaymentAdd formPaymentAdd = new FormPaymentAdd();
            formPaymentAdd.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormPaymentAdd formPaymentAdd = new FormPaymentAdd();
            formPaymentAdd.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormPaymentCheckVoucher formPaymentCheckVoucher = new FormPaymentCheckVoucher();
            formPaymentCheckVoucher.ShowDialog();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormPaymentCheckVoucher formPaymentCheckVoucher = new FormPaymentCheckVoucher();
            formPaymentCheckVoucher.ShowDialog();
        }
    }
}
