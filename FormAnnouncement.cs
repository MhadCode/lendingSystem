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
    public partial class FormAnnouncement : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lending_db;Convert Zero Datetime=true");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FormAnnouncement()
        {
            InitializeComponent();
        }
        private void populatelist(string details, string owner, string date, string status, string hidden, string id)
        {
            dataGridView1.Rows.Add(details, status, owner, date, hidden, id);

        }
        private void retrievelist()
        {
            dataGridView1.Rows.Clear();

            string sql = "SELECT * FROM announcement_tbl";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populatelist(row[3].ToString(), row[2].ToString(), row[1].ToString(), row[4].ToString(), row[5].ToString(),row[0].ToString());
                }

                conn.Close();

                //txtListCount.Text = dt.Rows.Count.ToString();
                //txtID.Text = dataGridView1.Rows.Count.ToString();

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
        private void FormAnnouncement_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblCreator.Text = FormHome.username;

            retrievelist();
            dataGridView1.ClearSelection();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "NEW POST")
            {
                ckHid.Checked = false;
                ckStat.Checked = false;
                dataGridView1.ClearSelection();
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                lblCreator.Text = FormHome.username;
                txtDetails.Enabled = true;
                txtDetails.Text = "";
                btnAdd.Text = "POST";
                btnRemove.Text = "CANCEL";
                btnRemove.Enabled = true;
                return;
            }

            if (btnAdd.Text == "POST")
            {
                if (txtDetails.Text == "")
                {
                    MessageBox.Show("Please enter announcement details", "Information Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string stat;
                string hid;

                stat = "Open";
                hid = "No";

                string sql = "INSERT INTO announcement_tbl(ab_date, ab_createdby, ab_details,ab_status,ab_visibility) values('" + lblDate.Text + "','" + lblCreator.Text + "','" + txtDetails.Text + "','" + stat + "','" + hid + "')";
                cmd = new MySqlCommand(sql, conn);

                try
                {
                    conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("New post successfully recorded!", "ANNOUNCEMENT BOARD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    conn.Close();
                    retrievelist();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                    retrievelist();
                }
            }

            txtDetails.Text = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;

            btnRemove.Text = "REMOVE";
            btnRemove.Enabled = true;
            btnAdd.Text = "NEW POST";
            txtDetails.Enabled = false;

            int rowindex;
            rowindex = dataGridView1.CurrentRow.Index;

            if (rowindex == rowCount - 1)
            {
                return;
            }

            string details;
            details = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            txtDetails.Text = details;

            string hid;
            hid = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();

            string stat;
            stat = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();

            string dte;
            dte= dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            lblDate.Text = dte;

            //MessageBox.Show(hid + " " + stat);

            if (hid == "No")
            {
                ckHid.Checked = true;
            }
            else
            {
                ckHid.Checked = false;
            }

            if (stat == "Completed")
            {
                ckStat.Checked = true;
            }
            else
            {
                ckStat.Checked = false;
            }

        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowCount = dataGridView1.Rows.Count;

            //MessageBox.Show(rowCount.ToString());
            //return;

            btnRemove.Text = "REMOVE";
            btnRemove.Enabled = true;
            btnAdd.Text = "NEW POST";
            txtDetails.Enabled = false;

            int rowindex;
            rowindex = dataGridView1.CurrentRow.Index;
            
            if (rowindex==rowCount - 1)
            {
                return;
            }

            string details;
            details = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();

            string hid;
            hid = dataGridView1.Rows[rowindex].Cells[4].Value.ToString();

            string stat;
            stat = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();

            string dte;
            dte = dataGridView1.Rows[rowindex].Cells[3].Value.ToString();
            lblDate.Text = dte;

            if (hid == "No")
            {
                ckHid.Checked = true;
            }
            else
            {
                ckHid.Checked = false;
            }

            if (stat == "Completed")
            {
                ckStat.Checked = true;
            }
            else
            {
                ckStat.Checked = false;
            }

            txtDetails.Text = details;

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (btnRemove.Text == "CANCEL")
            {
                ckHid.Checked = false;
                ckStat.Checked = false;
                btnRemove.Text = "REMOVE";
                btnRemove.Enabled = false;
                btnAdd.Text = "NEW POST";
                retrievelist();
                dataGridView1.ClearSelection();
                txtDetails.Text = "";
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                lblCreator.Text = FormHome.username;
                return;
            }


            int rowindex;
            rowindex = dataGridView1.CurrentRow.Index;

            string del;
            del = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();

            string sql = "DELETE FROM announcement_tbl WHERE ab_id = '" + del +"'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = conn.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Data you selected will be deleted permanently. Do you want to proceed?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Post successfully Deleted!","ANNOUNCEMENT BOARD",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
                retrievelist();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void ckHid_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ckHid_Click(object sender, EventArgs e)
        {
            int rowindex;
            rowindex = dataGridView1.CurrentRow.Index;

            string update;
            update = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();

            string hid;
            string stat;


            if (ckHid.Checked == true)
            {
                hid = "No";
            }
            else
            {
                hid = "Yes";
            }

            if (ckStat.Checked == true)
            {
                stat = "Completed";
            }
            else
            {
                stat = "Open";
            }

            string sql = "UPDATE announcement_tbl SET ab_createdby='" + lblCreator.Text + "',ab_date='" + lblDate.Text + "',ab_details='" + txtDetails.Text + "',ab_status='" + stat + "',ab_visibility='" + hid + "' WHERE ab_id='" + update + "'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();


                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully updated!", "ANNOUNCEMENT BOARD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adapter.UpdateCommand.ExecuteNonQuery();
                }

                conn.Close();
                retrievelist();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                retrievelist();
            }

        }
        private void ckStat_CheckedChanged(object sender, EventArgs e)
        {
         

        }
        private void ckStat_Click(object sender, EventArgs e)
        {
            int rowindex;
            rowindex = dataGridView1.CurrentRow.Index;

            string update;
            update = dataGridView1.Rows[rowindex].Cells[5].Value.ToString();

            string hid;
            string stat;


            if (ckHid.Checked == true)
            {
                hid = "No";
            }
            else
            {
                hid = "Yes";
            }

            if (ckStat.Checked == true)
            {
                stat = "Completed";
            }
            else
            {
                stat = "Open";
            }

            string sql = "UPDATE announcement_tbl SET ab_createdby='" + lblCreator.Text + "',ab_date='" + lblDate.Text + "',ab_details='" + txtDetails.Text + "',ab_status='" + stat + "',ab_visibility='" + hid + "' WHERE ab_id='" + update + "'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();


                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successfully updated!", "ANNOUNCEMENT BOARD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    adapter.UpdateCommand.ExecuteNonQuery();
                }

                conn.Close();
                retrievelist();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                retrievelist();
            }

        }
    }
}
