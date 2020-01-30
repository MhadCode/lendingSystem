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
    public partial class FormCollection : Form
    {
        public FormCollection()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCollectionRemit formCollectionRemit = new FormCollectionRemit();
            formCollectionRemit.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollectionAdd formCollectionAdd = new FormCollectionAdd();
            formCollectionAdd.ShowDialog();
        }
    }
}
