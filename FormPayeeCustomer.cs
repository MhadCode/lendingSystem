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
    public partial class FormPayeeCustomer : Form
    {
        public FormPayeeCustomer()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            FormAccountingJournal ff = new FormAccountingJournal();
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPayeeAdd ff = new FormPayeeAdd();
            ff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPayeeCustomer.ActiveForm.Close();

        }
    }
}
