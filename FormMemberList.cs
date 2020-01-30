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
    public partial class FormMemberList : Form
    {
        

        public FormMemberList()
        {
            InitializeComponent();
        }

        private void populateMemList (string ID, string Name, string Status)
        {
            dataGridView1.Rows.Add(ID, Name,Status);
        }

        private void FormMemberList_Load(object sender, EventArgs e)
        {
            string connectionstring = "datasource=localhost;port=3306;username=root;password=;database=lending_db;Convert Zero Datetime=true";

            string mysql = "SELECT * FROM memapprove_tbl";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand command = new MySqlCommand(mysql, conn);

            try
            {
                conn.Open();

                MySqlDataAdapter dtb = new MySqlDataAdapter(command);
                DataTable dtable = new DataTable();
                dtb.Fill(dtable);

                foreach (DataRow row in dtable.Rows)
                {
                    populateMemList(row[0].ToString(),row[3].ToString() + ", " + row[4].ToString() + " " + row[5].ToString(), row[35].ToString());                 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
