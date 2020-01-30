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
    public partial class FormLoanManager : Form
    {
        public FormLoanManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLoanAdd formAddLoan = new FormLoanAdd();
            formAddLoan.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormCollectionAddNew formCollectionAdd = new FormCollectionAddNew();
            formCollectionAdd.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormLoanAdd formLoanAdd = new FormLoanAdd();
            formLoanAdd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void FormLoanManager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLoanAdd formAddLoan = new FormLoanAdd();
            formAddLoan.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLoanAdd formAddLoan = new FormLoanAdd();
            formAddLoan.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormPaymentAdd formPaymentAdd = new FormPaymentAdd();
            formPaymentAdd.ShowDialog();
        }
    }
}
