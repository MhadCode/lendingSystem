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
    public partial class FormMemberStatus : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lending_db;Convert Zero Datetime=true");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FormMemberStatus()
        {
            InitializeComponent();
        }
        private void populateList(string stat, string appno, string dte, string name, string coopposition)
        {
            dataGridView1.Rows.Add(stat, appno, dte, name, coopposition);
        }
        private void retrievelist()
        {
            dataGridView1.Rows.Clear();

            string sql = "SELECT * FROM customer_db";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateList(row[35].ToString(), row[0].ToString(), row[1].ToString(), row[5].ToString() + ", " + row[4].ToString() + " " + row[6].ToString(), row[15].ToString());
                }

                conn.Close();

                dt.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int rowIndex;
            rowIndex = dataGridView1.Rows.Count - 1;

            dataGridView1.ClearSelection();
            dataGridView1.Rows[rowIndex].Cells[0].Selected = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMemberAdd formMember = new FormMemberAdd();
            formMember.ShowDialog();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            FormMemberBackgroundAssessment formApplicationBackgroundAssessment = new FormMemberBackgroundAssessment();
            formApplicationBackgroundAssessment.ShowDialog();
        }

        private void FormMemberStatus_Load(object sender, EventArgs e)
        {
            retrievelist();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Update"));
                m.MenuItems.Add(new MenuItem("Delete"));
                m.MenuItems.Add(new MenuItem("Record Assessment"));

                int cmrow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                MessageBox.Show(cmrow.ToString());

                if (cmrow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", cmrow.ToString())));
                }
                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }
    }
}
