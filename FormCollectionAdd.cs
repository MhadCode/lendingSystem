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
    public partial class FormCollectionAdd : Form
    {
        public FormCollectionAdd()
        {
            InitializeComponent();
        }

        private void FormCollection_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormCollectionAddNew formCollectionAdd = new FormCollectionAddNew();
            formCollectionAdd.ShowDialog();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormViewBillingStatement formViewBillingStatement = new FormViewBillingStatement();
            formViewBillingStatement.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCollectionSummary formCollectionSummary = new FormCollectionSummary();
            formCollectionSummary.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCollectionRemit formCollectionRemit = new FormCollectionRemit();
            formCollectionRemit.ShowDialog();
        }
    }
}
