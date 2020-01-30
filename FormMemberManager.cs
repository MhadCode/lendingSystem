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
    public partial class FormMemberManager : Form
    {
        public FormMemberManager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMemberAdd formMemberAdd = new FormMemberAdd();
            formMemberAdd.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.ShowDialog();
        }

        private void FormMemberManager_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormMemberBackgroundAssessment formMemberBackgroundAssessment = new FormMemberBackgroundAssessment();
            formMemberBackgroundAssessment.ShowDialog();
        }
    }
}
