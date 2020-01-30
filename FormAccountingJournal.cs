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
    public partial class FormAccountingJournal : Form
    {
        public FormAccountingJournal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormViewJournal formViewJournal = new FormViewJournal();
            formViewJournal.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAccountingJournalFilter formJournalOtherFilter = new FormAccountingJournalFilter();
            formJournalOtherFilter.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormViewOpenJournal formViewOpenJournal = new FormViewOpenJournal();
            formViewOpenJournal.ShowDialog();
        }

        private void FormAccountingJournal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAccountingJournalCancel formAccountingJournalCancel = new FormAccountingJournalCancel();
            formAccountingJournalCancel.ShowDialog();
        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            FormViewOpenJournal ff = new FormViewOpenJournal();
            ff.ShowDialog();
        }

        private void textBox11_DoubleClick(object sender, EventArgs e)
        {
            FormViewOpenJournal ff = new FormViewOpenJournal();
            ff.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrint_Click(object sender, EventArgs e)
        {
            FormPrintArea ff = new FormPrintArea();
            ff.ShowDialog();
        }

        private void txtName_DoubleClick(object sender, EventArgs e)
        {
            FormPayeeCustomer ff = new FormPayeeCustomer();
            ff.ShowDialog();
        }

        private void cmboRef_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormViewOpenJournal ff = new FormViewOpenJournal();
            ff.ShowDialog();
        }

        private void cmboRef_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
