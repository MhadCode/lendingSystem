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
    public partial class FormAccounting : Form
    {
        public FormAccounting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 0;
            lblTrans.Text = "RECEIVABLES";
            dtaGridAcctRec.SelectedIndex = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 1;
            lblTrans.Text = "SAVINGS";
            dtaGridAcctRec.SelectedIndex = 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormAccountingJournal formAccountingJournal = new FormAccountingJournal();
            formAccountingJournal.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormViewOpenJournal formViewOpenJournal = new FormViewOpenJournal();
            formViewOpenJournal.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormViewJournal formViewJournal = new FormViewJournal();
            formViewJournal.ShowDialog();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormAccountingJournal formAccountingJournal = new FormAccountingJournal();
            formAccountingJournal.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dtaGridAcctRec.SelectedIndex = 3;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            FormViewLoansDetails formViewLoansDetails = new FormViewLoansDetails();
            formViewLoansDetails.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            FormLoanAdd formLoanAdd = new FormLoanAdd();
            formLoanAdd.ShowDialog();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            FormAccountingJournal formAccountingJournal = new FormAccountingJournal();
            formAccountingJournal.ShowDialog();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            FormViewOpenJournal formViewOpenJournal = new FormViewOpenJournal();
            formViewOpenJournal.ShowDialog();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            FormViewOpenJournal formViewOpenJournal = new FormViewOpenJournal();
            formViewOpenJournal.ShowDialog();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            FormCollectionAdd formCollectionAdd = new FormCollectionAdd();
            formCollectionAdd.ShowDialog();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            FormPaymentAdd formPaymentAdd = new FormPaymentAdd();
            formPaymentAdd.ShowDialog();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            FormAccountingMemo formAccountingMemo = new FormAccountingMemo();
            formAccountingMemo.ShowDialog();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            FormAccountingMemo formAccountingMemo = new FormAccountingMemo();
            formAccountingMemo.ShowDialog();

        }

        private void button47_Click(object sender, EventArgs e)
        {
            FormCollectionAdd formCollectionAdd = new FormCollectionAdd();
            formCollectionAdd.ShowDialog();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            FormPaymentAdd formPaymentAdd = new FormPaymentAdd();
            formPaymentAdd.ShowDialog();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            FormAccountingMemo formAccountingMemo = new FormAccountingMemo();
            formAccountingMemo.ShowDialog();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            FormPaymentAdd formPaymentAdd = new FormPaymentAdd();
            formPaymentAdd.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            FormAccountingMemo formAccountingMemo = new FormAccountingMemo();
            formAccountingMemo.ShowDialog();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.ShowDialog();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.ShowDialog();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.ShowDialog();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.ShowDialog();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.ShowDialog();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.ShowDialog();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void button59_Click(object sender, EventArgs e)
        {
            FormAccountingJournal fform = new FormAccountingJournal();
            fform.ShowDialog();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            FormAccountingDividends fform = new FormAccountingDividends();
            fform.ShowDialog();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            FormAccountingBS fform = new FormAccountingBS();
            fform.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dtaGridAcctRec.SelectedIndex = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dtaGridAcctRec.SelectedIndex = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dtaGridAcctRec.SelectedIndex = 2;
        }

        private void FormAccounting_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            dtaGridAcctRec.Appearance = TabAppearance.FlatButtons;
            dtaGridAcctRec.ItemSize = new Size(0, 1);
            dtaGridAcctRec.SizeMode = TabSizeMode.Fixed;

            tabControl1.Visible = true;
            lblTrans.Text = "JOURNAL";
            tabControl1.SelectedIndex = 5;

            dtaGridAcctRec.SelectedIndex = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblTrans.Text = "CONTRIBUTION";
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            lblTrans.Text = "DIVIDENDS";
            tabControl1.SelectedIndex = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            lblTrans.Text = "NET SURPLUS";
            tabControl1.SelectedIndex = 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            lblTrans.Text = "JOURNAL";
            tabControl1.SelectedIndex = 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
        }

        private void tabPage13_Click(object sender, EventArgs e)
        {

        }
    }
}
