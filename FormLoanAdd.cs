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
    public partial class FormLoanAdd : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lending_db;Convert Zero Datetime=true");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FormLoanAdd()
        {
            InitializeComponent();
        }
        private void FormAddLoan_Load(object sender, EventArgs e)
        {
            loanType();
            MemberInformation();
            CreditAssessment();
            paymentmode();

            txtPreparedBy.Text = FormHome.username;
            //lblusername.Text = FormHome.username;
            //MessageBox.Show(FormHome.username);
        }
        private void clearfields()
        {

        }
        private void checkfields()
        {
            //check loan information
            if (ckRenewLoan.Checked == false)
            {
                if (ckNewLoan.Checked == false)
                {
                    MessageBox.Show("Please select type of loan.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (txtPNno.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check PN field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerLastName.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Last Name field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerMiddleName.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Middle Name field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerFirstName.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check First Name field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerBPlace.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Birthday Place field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (mtxtCoMakerBday.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Birthday field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerBusinessAddress.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Business Address field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerBusinessName.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Business Name or Employer field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerFirstName.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check First Name field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtMarStat.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check martial status field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerOccupation.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Occupation field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerSourceIncome.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Source Income field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerPresentAddress.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Present Address field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerPermanentAddress.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Permanent Address field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerCNumber.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Contact Number field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerEmail.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Email Address field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cmboCoMakerGender.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check Email Address field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerHHExpenses.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check estimated Household Expenses field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCoMakerIncome.Text == "")
            {
                MessageBox.Show("Unavaible to save. Please check estimated Monthly Receipt field.", "MISSING INFO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private void CreditAssessment()
        {
            dgCAQuestion.Rows.Clear();

            string sql = "select * FROM creditassessmentcriteria_tbl";
            cmd = new MySqlCommand(sql, conn);

            
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string LoanDesc = row[1].ToString();
                    dgCAQuestion.Rows.Add(LoanDesc.ToUpper());
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void paymentmode()
        {
            cmboPaymentMode.Items.Clear();

            string sql = "select * FROM paymentmode_tbl";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idNo = myReader.GetString("LMP_id");
                    string LoanDesc = myReader.GetString("LMP_Description");
                    cmboPaymentMode.Items.Add(idNo + " -" + LoanDesc);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void loanType()
        {
            cmboLoanType.Items.Clear();

            string sql = "select * FROM lendinginttype_tbl";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idNo = myReader.GetString("LIT_id");
                    string LoanDesc = myReader.GetString("LIT_Description");
                    cmboLoanType.Items.Add(idNo + " -" + LoanDesc);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void MemberInformation()
        {
            string sql = "select * FROM memapprove_tbl";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string appno = myReader.GetString("m_id");
                    string LastName = myReader.GetString("m_LastName");
                    string FirstName = myReader.GetString("m_FirstName");
                    string MiddleName = myReader.GetString("m_MiddleName");

                    cmboMemID.Items.Add(appno + " -" + LastName + ", " + FirstName + " " + MiddleName);
                    cmboCoMakerMember.Items.Add(appno + " -" + LastName + ", " + FirstName + " " + MiddleName);
                    
                }
                
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances formViewMemberBalances = new FormViewMemberBalances();
            formViewMemberBalances.Show();
         }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
        private void button6_Click_1(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormLoanAmortization formLoanAmortization = new FormLoanAmortization();
            formLoanAmortization.ShowDialog();
        }

        private void txtMemID_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtMemID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cmboMemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string memName = cmboMemID.Text;
            string idNO = new string(memName.Where(char.IsDigit).ToArray());
            txtMemID.Text = idNO.ToString();
        }

        private void cmboLoanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string memName = cmboLoanType.Text;
            string idNO = new string(memName.Where(char.IsDigit).ToArray());
            txtLIT_id.Text = idNO.ToString();

            string sql = "select * FROM lendinginttype_tbl";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idNo = myReader.GetString("LIT_id");
                    if(idNo == txtLIT_id.Text)
                    {
                        txtInterestRate.Text = myReader.GetString("LIT_rate");
                    } 
                
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cmboCoMakerMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            string memName = cmboCoMakerMember.Text;
            string idNO = new string(memName.Where(char.IsDigit).ToArray());
            txtCoMakerMemID.Text = idNO.ToString();

            string sql = "select * FROM memapprove_tbl";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idNo = myReader.GetString("m_id");
                    if (idNo == txtCoMakerMemID.Text)
                    {
                        txtCoMakerLastName.Text = myReader.GetString("m_lastname").ToUpper();
                        txtCoMakerFirstName.Text = myReader.GetString("m_firstname").ToUpper();
                        txtCoMakerMiddleName.Text = myReader.GetString("m_middlename").ToUpper();
                        cmboCoMakerGender.Text = myReader.GetString("m_gender");

                        mtxtCoMakerBday.Text = myReader.GetString("m_birthday");
                        txtCoMakerBPlace.Text = myReader.GetString("m_birthplace").ToUpper();
                        txtCoMakerPermanentAddress.Text = myReader.GetString("m_addresspermanent").ToUpper();
                        txtCoMakerPresentAddress.Text = myReader.GetString("m_addresscurrent").ToUpper();
                        
                        string marstat = myReader.GetString("m_status");
                        if (marstat == "Single")
                        {
                            rbCoMakerSingle.Checked = true;
                        }
                        if (marstat == "Married")
                        {
                            rbCoMakerMarried.Checked = true;
                        }
                        if (marstat == "Widowed")
                        {
                            rbCoMakerWidowed.Checked = true;
                        }

                        //work information
                        txtCoMakerSourceIncome.Text = myReader.GetString("m_sourceincome").ToUpper();
                        txtCoMakerOccupation.Text = myReader.GetString("m_occupation").ToUpper();
                        txtCoMakerBusinessName.Text = myReader.GetString("m_businessname").ToUpper();
                        txtCoMakerBusinessAddress.Text = myReader.GetString("m_businessaddress").ToUpper();

                        //contact information
                        txtCoMakerCNumber.Text = myReader.GetString("m_cnumber");
                        txtCoMakerEmail.Text = myReader.GetString("m_email");

                        //membership information
                        tbMemberID.Text = myReader.GetString("m_id");
                        tbMembershipDate.Text = myReader.GetString("m_date_approved");
                        tbApplicationNo.Text = myReader.GetString("c_id");
                        tbDateApplication.Text = myReader.GetString("m_date_application");

                        string coopPosition = myReader.GetString("m_coopposition");
                        if(coopPosition=="Regular Member")
                        {
                            rbRegularMember.Checked = true;
                        }
                        if(coopPosition=="Employee Member")
                        {
                            rbEmployeeMember.Checked = true;
                        }
                        if(coopPosition=="Officer Member")
                        {
                            rbBDMember.Checked = true;
                        }



                    }

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void mtxtCoMakerBday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void ckNewLoan_CheckedChanged(object sender, EventArgs e)
        {
            if(ckNewLoan.Checked == true)
            {
                ckRenewLoan.Checked = false;
            }
        }
        private void ckRenewLoan_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRenewLoan.Checked == true)
            {
                ckNewLoan.Checked = false;
            }
        }
        private void rbCoMakerSingle_CheckedChanged(object sender, EventArgs e)
        {
            txtMarStat.Text = "Single";
        }
        private void rbCoMakerMarried_CheckedChanged(object sender, EventArgs e)
        {
            txtMarStat.Text = "Married";
        }
        private void rbCoMakerWidowed_CheckedChanged(object sender, EventArgs e)
        {
            txtMarStat.Text = "Widowed";
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            checkfields();

            string loantype = "";
            if (ckNewLoan.Checked == true)
            {
                loantype = "New Loan";
            }
            if (ckRenewLoan.Checked == true)
            {
                loantype = "Renew Loan";
            }

            //convert application date to mysql date format
            string dte = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime mApplicationDate = DateTime.Parse(dte);
            string sqlAppliDate = mApplicationDate.ToString("yyyy-MM-dd");

            string loanStat = "Prepared";

            string sql = "INSERT INTO lending_tbl(L_PN_Ref, L_CreditType, L_Date_Application,L_Term,L_Amount,LMP_ID,L_LoanStatus,L_ApplicantNetIncome," +
                "L_OtherIncome,L_TotalExpenses, m_id,L_preparer,lit_id,l_loanpurpose,l_loanpurposeother) " +    
                "VALUES ('" + txtPNno.Text + "','" + loantype + "','" + sqlAppliDate + "','" + txtMaturity.Text + "','" + txtLoanAmount.Text + 
                "','" + txtPaymentMode.Text + "','" + loanStat + "','" + txtNetIncome.Text + 
                "','" + txtOtherIncome.Text + "','" + txtHHExpense.Text + "','" + txtMemID.Text + "','" + FormHome.username + "','" + txtLIT_id.Text + 
                "','" + cmboPurpose.Text + "','" + txtPurposeOther.Text + "')";
            cmd = new MySqlCommand(sql, conn);
            
            try
            {
                conn.Open();

                if (MessageBox.Show("Are you sure you want to submit the application?", "NEW LOAN", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Application successfully recorded!", "NEW LOAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                conn.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmboPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string memName = cmboPaymentMode.Text;
            string idNO = new string(memName.Where(char.IsDigit).ToArray());
            txtPaymentMode.Text = idNO.ToString();

            string sql = "select * FROM paymentmode_tbl";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idNo = myReader.GetString("LMP_id");
                    if (idNo == txtPaymentMode.Text)
                    {
                        txtPaymenttiming.Text = myReader.GetString("LMP_remarks");
                    }

                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void cmboPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboPurpose.Text == "Other")
            {
                txtPurposeOther.Enabled = true;
                return;
            }
            else
            {
                txtPurposeOther.Text = "";
                txtPurposeOther.Enabled = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnApproveLoan_Click(object sender, EventArgs e)
        {

        }
    }
}
