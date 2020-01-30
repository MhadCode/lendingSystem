using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lending_System
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
            DBCon.open();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void ULogin()
        {
            try
            {
                MessageBox.Show(DBCon.Login("Select * from useracc_tbl").ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ULogin();

            //Formlogin ffLog = new Formlogin();
            //ffLog.Close();

            //FormEnter ffEnt = new FormEnter();
            //ffEnt.Close();


            //FormHome ff = new FormHome();
            //ff.ShowDialog();

        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
   //         if (e.KeyChar == (char)Keys.Enter)
   //         {
   //             ULogin();
   //         }
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formlogin ffLog = new Formlogin();
            ffLog.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            FormUserAccountLogin ff = new FormUserAccountLogin();
            ff.ShowDialog();
        }
    }
}
