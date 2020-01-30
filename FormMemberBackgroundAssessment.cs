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
using System.IO;

namespace Lending_System
{
    public partial class FormMemberBackgroundAssessment : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lending_db;Convert Zero Datetime=true");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FormMemberBackgroundAssessment()
        {
            InitializeComponent();
        }
        private void ApplicantsList()
        {
            cbApplicationNo.Items.Clear();
            string sql = "select * FROM customer_db";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {
                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string appno = myReader.GetString("c_id");
                    cbApplicationNo.Items.Add(appno);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void checkifApproved()
        {
            string sql = "select * from memapprove_tbl";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myreader;

            try
            {
                conn.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string appno = myreader.GetString("c_id");
                    string appstat = myreader.GetString("m_membershipstatus");

                    if (cbApplicationNo.Text == appno)
                    {
                        if(appstat=="Active")
                        {
                            rbApprovedMember.Checked = true;
                            tbMemberID.Text = myreader.GetString("m_id");
                        }
                    }
                }

                    conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void retrievelistApproved()
        {
            //ClearFields();

            MessageBox.Show("Member Table");
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
                    //MessageBox.Show(appno.ToString());

                    if (appno == tbMemberID.Text)
                    {
                        //                        byte[] Imagebyte = (byte[])dt.Rows[0]["c_picturelink"];
                        //                        MemoryStream ms = new MemoryStream(Imagebyte);
                        //                        pbApplicantPic.Image = System.Drawing.Image.FromStream(ms);

                        string lastname = myReader.GetString("m_LastName");
                        string firstname = myReader.GetString("m_FirstName");
                        string middlename = myReader.GetString("m_MiddleName");
                        string birthplace = myReader.GetString("m_birthplace");
                        string permanentaddress = myReader.GetString("m_addresspermanent");
                        string presentaddress = myReader.GetString("m_addresscurrent");
                        string sourceincome = myReader.GetString("m_sourceincome");
                        string occupation = myReader.GetString("m_occupation");
                        string businessname = myReader.GetString("m_businessname");
                        string businessplace = myReader.GetString("m_businessaddress");

                        string spousefname = myReader.GetString("m_spousefirstname");
                        string spouselname = myReader.GetString("m_spouselastname");
                        string spousemname = myReader.GetString("m_spousemiddlename");
                        string spousebplace = myReader.GetString("m_spousebirthplace");
                        string spousesourceincome = myReader.GetString("m_spousesourceincome");
                        string spouseoccupation = myReader.GetString("m_spouseoccupation");
                        string spousebusinessname = myReader.GetString("m_spousebusinessname");
                        string spousebusinessplace = myReader.GetString("m_spousebusinessaddress");

                        //personalinformation
                        tbLastName.Text = lastname.ToUpper();
                        tbFirstName.Text = firstname.ToUpper();
                        tbMiddleName.Text = middlename.ToUpper();

                        cbGender.Text = myReader.GetString("m_gender");
                        mtbBirthday.Text = myReader.GetString("m_birthday");
                        tbBirthPlace.Text = birthplace.ToUpper();
                        tbPermanentAddress.Text = permanentaddress.ToUpper();
                        tbPresentAddress.Text = presentaddress.ToUpper();
                        tbDependents.Text = myReader.GetString("m_dependent");

                        string Marstat = myReader.GetString("m_status");
                        if (Marstat.ToString() == "Single")
                        {
                            rbSingle.Checked = true;
                            txtMarStat.Text = "Single";
                        }
                        if (Marstat.ToString() == "Married")
                        {
                            rbMarried.Checked = true;
                            txtMarStat.Text = "Married";
                        }
                        if (Marstat.ToString() == "Widowed")
                        {
                            rbWidowed.Checked = true;
                            txtMarStat.Text = "Widowed";
                        }

                        //workinformation
                        tbSourceIncome.Text = sourceincome.ToUpper();
                        tbOccupation.Text = occupation.ToUpper();
                        tbBusinessName.Text = businessname.ToUpper();
                        tbBusinessAddress.Text = businessplace.ToUpper();

                        //spouseinformation
                        tbSpouseFName.Text = spousefname.ToUpper();
                        tbSpouseLName.Text = spouselname.ToUpper();
                        tbSpouseMName.Text = spousemname.ToUpper();
                        mtbSpouseBirthday.Text = myReader.GetString("m_spousebirthday");
                        tbSpouseBirthPlace.Text = spousebplace.ToUpper();
                        cbSpouseGender.Text = myReader.GetString("m_spousegender");
                        tbSpouseOccupation.Text = spouseoccupation.ToUpper();
                        tbSpouseSourceIncome.Text = spousesourceincome.ToUpper();
                        tbSpouseBusinessName.Text = spousebusinessname.ToUpper();
                        tbSpouseBusinessAddress.Text = spousebusinessplace.ToUpper();
                        tbSpouseCNumber.Text = myReader.GetString("m_spousecnumber");
                        tbSpouseEmailAddress.Text = myReader.GetString("m_spouseemail");

                        //contactinformation
                        tbCNumber.Text = myReader.GetString("m_cnumber");
                        tbEmailAddress.Text = myReader.GetString("m_email");

                        //membershipinformation
                        tbApplicationNo.Text = myReader.GetString("c_id"); ;
                        //string tempdate = myReader.GetString("m_date_application"); 
                        //DateTime mysqldate = DateTime.Parse(tempdate);
                        tbDateApplication.Text = myReader.GetString("m_date_application");
                        tbMembershipDate.Text = myReader.GetString("m_date_approved");
                        tbMemberID.Text = myReader.GetString("m_id");

                        if (myReader.GetString("m_membershipstatus") == "Active")
                        {
                            ckActive.Checked = true;
                        }
                        if (myReader.GetString("m_membershipstatus") == "Cancelled")
                        {
                            ckActive.Checked = false;
                        }
                        if (myReader.GetString("m_coopposition") == "Regular Member")
                        {
                            txtCoopPosition.Text = "Regular Member";
                            rbRegularMember.Checked = true;
                        }
                        if (myReader.GetString("m_coopposition") == "Employee Member")
                        {
                            txtCoopPosition.Text = "Employee Member";
                            rbEmployeeMember.Checked = true;
                        }
                        if (myReader.GetString("m_coopposition") == "Officer Member")
                        {
                            txtCoopPosition.Text = "Officer Member";
                            rbBDMember.Checked = true;
                        }
                        if (myReader.GetString("m_membershipstatus") == "Active")
                        {
                            ckActive.Checked = true;
                        }
                        else
                        {
                            ckActive.Checked = false;
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            //image file
            string folderpath = AppDomain.CurrentDomain.BaseDirectory;
            string ImageCopyPath = folderpath + "localPics\\PicsMember\\" + tbApplicationNo.Text + ".jpg";
            pbApplicantPic.Image = Image.FromFile(ImageCopyPath);

            //MessageBox.Show("Approved member");

        }
        private void retrievelist()
        {
            ClearFields();
            MessageBox.Show("Application Table");

            string sql = "select * FROM customer_db";
            cmd = new MySqlCommand(sql, conn);
            MySqlDataReader myReader;

            try
            {

                conn.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string appno = myReader.GetString("c_id");

                    if (appno == cbApplicationNo.Text)
                    {
                        //                        byte[] Imagebyte = (byte[])dt.Rows[0]["c_picturelink"];
                        //                        MemoryStream ms = new MemoryStream(Imagebyte);
                        //                        pbApplicantPic.Image = System.Drawing.Image.FromStream(ms);

                        string lastname = myReader.GetString("c_LastName");
                        string firstname = myReader.GetString("c_FirstName");
                        string middlename = myReader.GetString("c_MiddleName");
                        string birthplace = myReader.GetString("c_birthplace");
                        string permanentaddress = myReader.GetString("c_addresspermanent");
                        string presentaddress = myReader.GetString("c_addresscurrent");
                        string sourceincome = myReader.GetString("c_sourceincome");
                        string occupation = myReader.GetString("c_occupation");
                        string businessname = myReader.GetString("c_businessname");
                        string businessplace = myReader.GetString("c_businessaddress");

                        string spousefname = myReader.GetString("c_spousefirstname");
                        string spouselname = myReader.GetString("c_spouselastname");
                        string spousemname = myReader.GetString("c_spousemiddlename");
                        string spousebplace = myReader.GetString("c_spousebirthplace");
                        string spousesourceincome = myReader.GetString("c_spousesourceincome");
                        string spouseoccupation = myReader.GetString("c_spouseoccupation");
                        string spousebusinessname = myReader.GetString("c_spousebusinessname");
                        string spousebusinessplace = myReader.GetString("c_spousebusinessaddress");

                        //personalinformation
                        tbLastName.Text = lastname.ToUpper();
                        tbFirstName.Text = firstname.ToUpper();
                        tbMiddleName.Text = middlename.ToUpper();

                        cbGender.Text = myReader.GetString("c_gender");
                        mtbBirthday.Text = myReader.GetString("c_birthday");
                        tbBirthPlace.Text = birthplace.ToUpper();
                        tbPermanentAddress.Text = permanentaddress.ToUpper();
                        tbPresentAddress.Text = presentaddress.ToUpper();
                        tbDependents.Text = myReader.GetString("c_dependent");

                        string Marstat = myReader.GetString("c_status");
                        if (Marstat.ToString() == "Single")
                        {
                            rbSingle.Checked = true;
                            txtMarStat.Text = "Single";
                        }
                        if (Marstat.ToString() == "Married")
                        {
                            rbMarried.Checked = true;
                            txtMarStat.Text = "Married";
                        }
                        if (Marstat.ToString() == "Widowed")
                        {
                            rbWidowed.Checked = true;
                            txtMarStat.Text = "Widowed";
                        }

                        //workinformation
                        tbSourceIncome.Text = sourceincome.ToUpper();
                        tbOccupation.Text = occupation.ToUpper();
                        tbBusinessName.Text = businessname.ToUpper();
                        tbBusinessAddress.Text = businessplace.ToUpper();

                        //spouseinformation
                        tbSpouseFName.Text = spousefname.ToUpper();
                        tbSpouseLName.Text = spouselname.ToUpper();
                        tbSpouseMName.Text = spousemname.ToUpper();
                        mtbSpouseBirthday.Text = myReader.GetString("c_spousebirthday");
                        tbSpouseBirthPlace.Text = spousebplace.ToUpper();
                        cbSpouseGender.Text = myReader.GetString("c_spousegender");
                        tbSpouseOccupation.Text = spouseoccupation.ToUpper();
                        tbSpouseSourceIncome.Text = spousesourceincome.ToUpper();
                        tbSpouseBusinessName.Text = spousebusinessname.ToUpper();
                        tbSpouseBusinessAddress.Text = spousebusinessplace.ToUpper();
                        tbSpouseCNumber.Text = myReader.GetString("c_spousecnumber");
                        tbSpouseEmailAddress.Text = myReader.GetString("c_spouseemail");

                        //contactinformation
                        tbCNumber.Text = myReader.GetString("c_cnumber");
                        tbEmailAddress.Text = myReader.GetString("c_email");

                        //membershipinformation
                        tbApplicationNo.Text = cbApplicationNo.Text;
                        //string tempdate = myReader.GetString("c_date_application"); 
                        //DateTime mysqldate = DateTime.Parse(tempdate);
                        tbDateApplication.Text = myReader.GetString("c_date_application");

                        if (myReader.GetString("c_applicationstatus") == "For Assessment")
                        {
                            txtApplicationStatus.Text = "For Assessment";
                            rbPendingAssesment.Checked = true;
                        }
                        if (myReader.GetString("c_applicationstatus") == "For Approval")
                        {
                            txtApplicationStatus.Text = "For Approval";
                            rbForApproval.Checked = true;
                        }
                        if (myReader.GetString("c_applicationstatus") == "Approved")
                        {
                            txtApplicationStatus.Text = "Approved";
                            rbApprovedMember.Checked = true;
                        }
                        if (myReader.GetString("c_applicationstatus") == "Cancelled")
                        {
                            txtApplicationStatus.Text = "Cancelled";
                            rbCancelledApplication.Checked = true;
                        }
                        if (myReader.GetString("c_coopposition") == "Regular Member")
                        {
                            txtCoopPosition.Text = "Regular Member";
                            rbRegularMember.Checked = true;
                        }
                        if (myReader.GetString("c_coopposition") == "Employee Member")
                        {
                            txtCoopPosition.Text = "Employee Member";
                            rbEmployeeMember.Checked = true;
                        }
                        if (myReader.GetString("c_coopposition") == "Officer Member")
                        {
                            txtCoopPosition.Text = "Officer Member";
                            rbBDMember.Checked = true;
                        }
                        if (myReader.GetString("c_membershipstatus") == "Active")
                        {
                            ckActive.Checked = true;
                        }
                        else
                        {
                            ckActive.Checked = false;
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            //image file
            string folderpath = AppDomain.CurrentDomain.BaseDirectory;
            string ImageCopyPath = folderpath + "localPics\\PicsApplicants\\" + tbApplicationNo.Text + ".jpg";
            pbApplicantPic.Image = Image.FromFile(ImageCopyPath);


        }
        private void checkfields()
        {
            //validate the fields before savings
            if (tbLastName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbLastName.Select();
                return;
            }
            if (tbFirstName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbFirstName.Select();
                return;
            }
            if (tbMiddleName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbMiddleName.Select();
                return;
            }
            if (cbGender.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbGender.Select();
                return;
            }
            if (tbPermanentAddress.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPermanentAddress.Select();
                return;
            }
            if (tbPresentAddress.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPresentAddress.Select();
                return;
            }
            if (mtbBirthday.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbBirthday.Select();
                return;
            }
            if (tbBirthPlace.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbBirthPlace.Select();
                return;
            }
            if (txtMarStat.Text == "")
            {
                MessageBox.Show("Failed to save! Please select marital status.", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tbCNumber.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCNumber.Select();
                return;
            }
            if (tbEmailAddress.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbEmailAddress.Select();
                return;
            }
            if (txtCoopPosition.Text == "")
            {
                MessageBox.Show("Failed to save! Please select position in the cooperative.", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tbOccupation.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbOccupation.Select();
                return;
            }
            if (tbBusinessName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbBusinessName.Select();
                return;
            }
            if (tbBusinessAddress.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbBusinessAddress.Select();
                return;
            }
            if (tbSourceIncome.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSourceIncome.Select();
                return;
            }
            if (tbDependents.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbDependents.Select();
                return;
            }
            if (tbSpouseLName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseLName.Select();
                return;
            }
            if (tbSpouseFName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseFName.Select();
                return;
            }
            if (tbSpouseMName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseMName.Select();
                return;
            }
            if (cbSpouseGender.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbSpouseGender.Select();
                return;
            }
            if (mtbSpouseBirthday.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbSpouseBirthday.Select();
                return;
            }
            if (tbSpouseBirthPlace.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseBirthPlace.Select();
                return;
            }
            if (tbSpouseSourceIncome.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseSourceIncome.Select();
                return;
            }
            if (tbSpouseOccupation.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseOccupation.Select();
                return;
            }
            if (tbSpouseBusinessName.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseBusinessName.Select();
                return;
            }
            if (tbSpouseBusinessAddress.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseBusinessAddress.Select();
                return;
            }
            if (tbSpouseCNumber.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseCNumber.Select();
                return;
            }
            if (tbSpouseEmailAddress.Text == "")
            {
                MessageBox.Show("Failed to save!", "MISSING INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbSpouseEmailAddress.Select();
                return;
            }

        }
        private void addtoMember()
        {
            //app id
            string appno = tbApplicationNo.Text;

            //validate the fields before savings
            checkfields();

            //Application no.
            int lCountList = cbApplicationNo.Items.Count + 1;
            tbApplicationNo.Text = lCountList.ToString();
            
            //date of application
            string appdte = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime sqlappDate = DateTime.Parse(appdte);
            string sqlAppliDate = sqlappDate.ToString("yyyy-MM-dd");

            //set current date. This will be the date of approved application 
            string dte = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime sqlDate = DateTime.Parse(dte);
            string sqlApprovedDate = sqlDate.ToString("yyyy-MM-dd");

            //set application status as 'for assessment'
            string appliStat;
            appliStat = "Active";

            //convert bdate to mysql date format
            string mbday = mtbBirthday.Text;
            DateTime mbdayDate = DateTime.Parse(mbday);
            string sqlBday = mbdayDate.ToString("yyyy-MM-dd");

            //convert spousebdate to mysql date format
            string mspousebday = mtbBirthday.Text;
            DateTime mspousebdayDate = DateTime.Parse(mspousebday);

            string spousesqlBday = mspousebdayDate.ToString("yyyy-MM-dd");

            //insert data to database
            string sql = "INSERT INTO memapprove_tbl" +
                "(c_id,m_date_application, m_date_approved, m_FirstName, m_LastName,m_middlename,m_gender,m_addresspermanent,m_addresscurrent,m_birthday," +
                "m_birthplace,m_status,m_cnumber,m_email,m_coopposition,m_occupation,m_businessname,m_businessaddress,m_sourceincome," +
                "m_dependent,m_spouselastname,m_spousefirstname,m_spousemiddlename,m_spousegender,m_spousebirthday,m_spousebirthplace," +
                "m_spousesourceincome,m_spouseoccupation,m_spousebusinessname,m_spousebusinessaddress,m_spousecnumber,m_spouseemail,m_membershipstatus) " +
                "values('" +appno + "','" + sqlAppliDate + "','" + sqlApprovedDate + "','" + tbFirstName.Text + "','" + tbLastName.Text + "','" + tbMiddleName.Text + "','" + cbGender.Text + "','" + tbPermanentAddress.Text +
                "','" + tbPresentAddress.Text + "','" + sqlBday + "','" + tbBirthPlace.Text + "','" + txtMarStat.Text + "','" + tbCNumber.Text + "','" + tbEmailAddress.Text +
                "','" + txtCoopPosition.Text + "','" + tbOccupation.Text + "','" + tbBusinessName.Text + "','" + tbBusinessAddress.Text + "','" + tbSourceIncome.Text +
                "','" + tbDependents.Text + "','" + tbSpouseLName.Text + "','" + tbSpouseFName.Text + "','" + tbSpouseMName.Text + "','" + cbSpouseGender.Text +
                "','" + spousesqlBday + "','" + tbSpouseBirthPlace.Text + "','" + tbSpouseSourceIncome.Text + "','" + tbSpouseOccupation.Text +
                "','" + tbSpouseBusinessName.Text + "','" + tbSpouseBusinessAddress.Text + "','" + tbSpouseCNumber.Text + "','" + tbSpouseEmailAddress.Text + "','" + appliStat + "')";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                    //    MessageBox.Show("Application successfully recorded!", "MEMBER TAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }
        private void SavePics()
        {
            string folderpath = AppDomain.CurrentDomain.BaseDirectory;
            string ImageCopyPath = folderpath + "localPics\\PicsMember\\" + tbApplicationNo.Text + ".jpg";
            var fInfo = new FileInfo(ImageCopyPath);
            if (!fInfo.Exists)
            {
                File.Copy(txtImageFileLoc.Text, ImageCopyPath);
            }
            else
            {
                MessageBox.Show("File exists! File will be overwrited...");
                File.Delete(ImageCopyPath);
                File.Copy(txtImageFileLoc.Text, ImageCopyPath);
                return;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMemberStatus formMembershipStatus = new FormMemberStatus();
            formMembershipStatus.ShowDialog();
        }
        private void FormMemberBackgroundAssessment_Load(object sender, EventArgs e)
        {
            ApplicantsList();
            assessmentQuestions();
        }
        private void populateAQuestions(string question)
        {
            dgQuestion.Rows.Add(question);
        }
        private void assessmentQuestions()
        {
            dgQuestion.Rows.Clear();

            string sql = "SELECT * FROM backgroundcriteria";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateAQuestions(row[1].ToString());
                }

                conn.Close();

                dt.Rows.Clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int rowIndex;
            rowIndex = dgQuestion.Rows.Count - 1;

            dgQuestion.ClearSelection();
            dgQuestion.Rows[rowIndex].Cells[0].Selected = true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void mtbBirthday_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void mtbBirthday_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

        }
        private void mtbBirthday_Leave(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void rbWidowed_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rbMarried_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnAsseOtherSave_Click(object sender, EventArgs e)
        {
            int rIndex = dgQuestion.CurrentRow.Index;

            dgQuestion.Rows[rIndex].Cells[1].Value = txtAns.Text;
            dgQuestion.Rows[rIndex].Cells[2].Value = txtRemarks.Text;

        }
        private void dgQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rCount = dgQuestion.Rows.Count;
            int rIndex = dgQuestion.CurrentRow.Index;

            if (rIndex == rCount - 1)
            {
                return;
            }

            if (dgQuestion.Rows[rIndex].Cells[1].Value == null)
            {
                return;
            }
            else
            {
                txtAns.Text = dgQuestion.Rows[rIndex].Cells[1].Value.ToString();
            }

            if (dgQuestion.Rows[rIndex].Cells[2].Value == null)
            {
                return;
            }
            else
            {
                txtRemarks.Text = dgQuestion.Rows[rIndex].Cells[2].Value.ToString();
            }

        }
        private void dgQuestion_SelectionChanged(object sender, EventArgs e)
        {
        }
        private void ClearFields()
        {
            //cbApplicationNo.Text = "";

            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbMiddleName.Text = "";

            mtbBirthday.Text = "";
            cbGender.Text = "";
            tbBirthPlace.Text = "";
            tbPermanentAddress.Text = "";
            tbPresentAddress.Text = "";
            tbDependents.Text = "";
            rbMarried.Checked = false;
            rbSingle.Checked = false;
            rbWidowed.Checked = false;

            tbApplicationNo.Text = "";
            tbDateApplication.Text = "";
            tbMemberID.Text = "";
            tbMembershipDate.Text = "";
            ckActive.Checked = false;
            rbPendingAssesment.Checked = false;
            rbForApproval.Checked = false;
            rbApprovedMember.Checked = false;
            rbRegularMember.Checked = false;
            rbEmployeeMember.Checked = false;
            rbBDMember.Checked = false;
            rbNoAccess.Checked = false;
            rbAccessAdmin.Checked = false;
            rbAccessFull.Checked = false;
            rbAccessUpdate.Checked = false;
            rbAccessView.Checked = false;

            tbOccupation.Text = "";
            tbSourceIncome.Text = "";
            tbBusinessAddress.Text = "";
            tbBusinessName.Text = "";

            tbEmailAddress.Text = "";
            tbCNumber.Text = "";

            tbSpouseFName.Text = "";
            tbSpouseLName.Text = "";
            tbSpouseMName.Text = "";
            mtbSpouseBirthday.Text = "";
            tbSpouseBirthPlace.Text = "";
            cbSpouseGender.Text = "";
            tbSpouseOccupation.Text = "";
            tbSpouseSourceIncome.Text = "";
            tbSpouseBusinessAddress.Text = "";
            tbSpouseBusinessName.Text = "";
            tbSpouseCNumber.Text = "";
            tbSpouseEmailAddress.Text = "";

        }
        private void cbApplicationNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkifApproved();
            if (rbApprovedMember.Checked == true)
            {
                retrievelistApproved();
            }
            else
            {
                retrievelist();
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }

        private void tbApplicationNo_Leave(object sender, EventArgs e)
        {
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string dte;

            dte = DateTime.Now.ToString("yy-MM-dd");

            string sql = "Update customer_db set c_date_assessment='" + dte + "',c_applicationstatus='" + "For Approval" + "' WHERE c_ID='" + cbApplicationNo.Text + "'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (MessageBox.Show("Are you sure you want to submit the assessment?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Record successfully updated!", "MEMBER TAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            string appno = tbApplicationNo.Text;
            cbApplicationNo.Text = appno.ToString();
            retrievelist();
        }
        private void btnApproved_Click(object sender, EventArgs e)
        {
            string dte;

            dte = DateTime.Now.ToString("yy-MM-dd");

            string sql = "Update customer_db set c_date_approved='" + dte + "',c_applicationstatus='" + "Approved" + "' WHERE c_ID='" + cbApplicationNo.Text + "'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (MessageBox.Show("Are you sure you want to approve the application?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Application successfully approved!", "MEMBER TAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            addtoMember();
            retrievelist();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
