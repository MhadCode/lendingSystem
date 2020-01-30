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
    public partial class FormMemberAdd : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=lending_db;Convert Zero Datetime=true");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FormMemberAdd()
        {
            InitializeComponent();
            ApplicantsList();
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
        private void InputFields()
        {
            btnNewMember.Text = "SUBMIT";
            btnDeleteMember.Enabled = true;
            btnUpdateInformation.Enabled = false;
            btnBackgroundAssesment.Enabled = false;
            btnViewAssesmentRec.Enabled = false;
            cbApplicationNo.Enabled = false;

            tbFirstName.Enabled = true;
            tbLastName.Enabled = true;
            tbMiddleName.Enabled = true;

            mtbBirthday.Enabled = true;
            cbGender.Enabled = true;
            tbBirthPlace.Enabled = true;
            tbPermanentAddress.Enabled = true;
            tbPresentAddress.Enabled = true;
            rbMarried.Enabled = true;
            rbSingle.Enabled = true;
            rbWidowed.Enabled = true;
            tbDependents.Enabled = true;
            tbApplicationNo.Enabled = false;
            tbDateApplication.Enabled = false;
            tbMemberID.Enabled = false;
            tbMembershipDate.Enabled = false;
            ckActive.Enabled = false;
            rbPendingAssesment.Enabled = false;
            rbForApproval.Enabled = false;
            rbApprovedMember.Enabled = false;
            rbCancelledApplication.Enabled = true;
            rbRegularMember.Enabled = true;
            rbEmployeeMember.Enabled = true;
            rbBDMember.Enabled = true;
            rbNoAccess.Checked = false;
            rbAccessAdmin.Checked = false;
            rbAccessFull.Checked = false;
            rbAccessUpdate.Checked = false;
            rbAccessView.Checked = false;

            tbOccupation.Enabled = true;
            tbSourceIncome.Enabled = true;
            tbBusinessAddress.Enabled = true;
            tbBusinessName.Enabled = true;

            tbEmailAddress.Enabled = true;
            tbCNumber.Enabled = true;

            tbSpouseFName.Enabled = true;
            tbSpouseLName.Enabled = true;
            tbSpouseMName.Enabled = true;
            mtbSpouseBirthday.Enabled = true;
            tbSpouseBirthPlace.Enabled = true;
            cbSpouseGender.Enabled = true;
            tbSpouseOccupation.Enabled = true;
            tbSpouseSourceIncome.Enabled = true;
            tbSpouseBusinessAddress.Enabled = true;
            tbSpouseBusinessName.Enabled = true;
            tbSpouseCNumber.Enabled = true;
            tbSpouseEmailAddress.Enabled = true;
        }
        private void resetFields()
        {
            ApplicantsList();
            cbApplicationNo.Text = "";

            btnNewMember.Text = "NEW";
            btnUpdateInformation.Text = "UPDATE";
            btnNewMember.Enabled = true;
            btnDeleteMember.Enabled = false;
            btnUpdateInformation.Enabled = false;
            btnBackgroundAssesment.Enabled = false;
            btnViewAssesmentRec.Enabled = false;
            cbApplicationNo.Enabled = true;

            tbFirstName.Enabled = false;
            tbLastName.Enabled = false;
            tbMiddleName.Enabled = false;

            mtbBirthday.Enabled = false;
            cbGender.Enabled = false;
            tbBirthPlace.Enabled = false;
            tbPermanentAddress.Enabled = false;
            tbPresentAddress.Enabled = false;
            rbMarried.Enabled = false;
            rbSingle.Enabled = false;
            rbWidowed.Enabled = false;
            tbDependents.Enabled = false;
            tbApplicationNo.Enabled = false;
            tbDateApplication.Enabled = false;
            tbMemberID.Enabled = false;
            tbMembershipDate.Enabled = false;
            ckActive.Enabled = false;
            rbPendingAssesment.Enabled = false;
            rbForApproval.Enabled = false;
            rbApprovedMember.Enabled = false;
            rbCancelledApplication.Enabled = false;
            rbRegularMember.Enabled = false;
            rbEmployeeMember.Enabled = false;
            rbBDMember.Enabled = false;
            rbNoAccess.Checked = false;
            rbAccessAdmin.Checked = false;
            rbAccessFull.Checked = false;
            rbAccessUpdate.Checked = false;
            rbAccessView.Checked = false;

            tbOccupation.Enabled = false;
            tbSourceIncome.Enabled = false;
            tbBusinessAddress.Enabled = false;
            tbBusinessName.Enabled = false;

            tbEmailAddress.Enabled = false;
            tbCNumber.Enabled = false;

            tbSpouseFName.Enabled = false;
            tbSpouseLName.Enabled = false;
            tbSpouseMName.Enabled = false;
            mtbSpouseBirthday.Enabled = false;
            tbSpouseBirthPlace.Enabled = false;
            cbSpouseGender.Enabled = false;
            tbSpouseOccupation.Enabled = false;
            tbSpouseSourceIncome.Enabled = false;
            tbSpouseBusinessAddress.Enabled = false;
            tbSpouseBusinessName.Enabled = false;
            tbSpouseCNumber.Enabled = false;
            tbSpouseEmailAddress.Enabled = false;

            string folderpath = AppDomain.CurrentDomain.BaseDirectory;
            string ImageCopyPath = folderpath + "localPics\\Unknown.jpg";
            pbApplicantPic.Image = Image.FromFile(ImageCopyPath);
            txtImageFileLoc.Text = ImageCopyPath;

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
        private void CheckFields()
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

            //if single or widowed, dont need to fill in spouse information
            if(rbSingle.Checked == true)
            {
                return;
            }
            if (rbWidowed.Checked == true)
            {
                return;
            }

            //spouse information
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
                        if (appstat == "Active")
                        {
                            rbApprovedMember.Checked = true;
                            tbMemberID.Text = myreader.GetString("m_id");
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
        private void retrieveinfo()
        {
            ClearFields();

            btnBackgroundAssesment.Enabled = true;
            btnViewAssesmentRec.Enabled = true;
            btnDeleteMember.Enabled = true;

            string sql = "select * FROM customer_db";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == cbApplicationNo.Text)
                    {
                        //                        byte[] Imagebyte = (byte[])dt.Rows[0]["c_picturelink"];
                        //                        MemoryStream ms = new MemoryStream(Imagebyte);
                        //                        pbApplicantPic.Image = System.Drawing.Image.FromStream(ms);

                        string lastname = row[5].ToString();
                        string firtname = row[4].ToString();
                        string middlename = row[6].ToString();
                        string birthplace = row[11].ToString();
                        string permanentaddress = row[8].ToString();
                        string presentaddress = row[9].ToString();
                        string sourceincome = row[19].ToString();
                        string occupation = row[16].ToString();
                        string businessname = row[17].ToString();
                        string businessplace = row[18].ToString();

                        string spousefname = row[22].ToString();
                        string spouselname = row[21].ToString();
                        string spousemname = row[23].ToString();
                        string spousebplace = row[26].ToString();
                        string spousesourceincome = row[27].ToString();
                        string spouseoccupation = row[28].ToString();
                        string spousebusinessname = row[29].ToString();
                        string spousebusinessplace = row[30].ToString();

                        //personalinformation
                        tbLastName.Text = lastname.ToUpper();
                        tbFirstName.Text = firtname.ToUpper();
                        tbMiddleName.Text = middlename.ToUpper();

                        cbGender.Text = row[7].ToString();
                        mtbBirthday.Text = row[10].ToString();
                        tbBirthPlace.Text = birthplace.ToUpper();
                        tbPermanentAddress.Text = permanentaddress.ToUpper();
                        tbPresentAddress.Text = presentaddress.ToUpper();
                        tbDependents.Text = row[20].ToString();

                        if (row[12].ToString() == "Single")
                        {
                            rbSingle.Checked = true;
                        }
                        if (row[12].ToString() == "Married")
                        {
                            rbMarried.Checked = true;
                        }
                        if (row[12].ToString() == "Widowed")
                        {
                            rbWidowed.Checked = true;
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
                        mtbSpouseBirthday.Text = row[26].ToString();
                        tbSpouseBirthPlace.Text = spousebplace.ToUpper();
                        cbSpouseGender.Text = row[24].ToString();
                        tbSpouseOccupation.Text = spouseoccupation.ToUpper();
                        tbSpouseSourceIncome.Text = spousesourceincome.ToUpper();
                        tbSpouseBusinessName.Text = spousebusinessname.ToUpper();
                        tbSpouseBusinessAddress.Text = spousebusinessplace.ToUpper();
                        tbSpouseCNumber.Text = row[31].ToString();
                        tbSpouseEmailAddress.Text = row[32].ToString();

                        //contactinformation
                        tbCNumber.Text = row[13].ToString();
                        tbEmailAddress.Text = row[14].ToString();

                        //membershipinformation
                        tbApplicationNo.Text = cbApplicationNo.Text;
                        //                        tempdate = row[1].ToString();
                        //                        DateTime mysqldate = DateTime.Parse(tempdate);
                        tbDateApplication.Text = row[1].ToString();

                        if (row[35].ToString() == "For Assessment")
                        {
                            txtApplicationStatus.Text = "For Assessment";
                            rbPendingAssesment.Checked = true;
                        }
                        if (row[35].ToString() == "For Approval")
                        {
                            txtApplicationStatus.Text = "For Approval";
                            rbForApproval.Checked = true;
                        }
                        if (row[35].ToString() == "Approved")
                        {
                            txtApplicationStatus.Text = "Approved";
                            rbApprovedMember.Checked = true;
                        }
                        if (row[35].ToString() == "Cancelled")
                        {
                            txtApplicationStatus.Text = "Cancelled";
                            rbCancelledApplication.Checked = true;
                        }
                        if (row[15].ToString() == "Regular Member")
                        {
                            txtCoopPosition.Text = "Regular Member";
                            rbRegularMember.Checked = true;
                        }
                        if (row[15].ToString() == "Employee Member")
                        {
                            txtCoopPosition.Text = "Employee Member";
                            rbEmployeeMember.Checked = true;
                        }
                        if (row[15].ToString() == "Officer Member")
                        {
                            txtCoopPosition.Text = "Officer Member";
                            rbBDMember.Checked = true;
                        }

                        if (row[36].ToString() == "Active")
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

            btnUpdateInformation.Enabled = true;

        }
        private void retriveinfoApproved()
        {
            btnBackgroundAssesment.Enabled = true;
            btnViewAssesmentRec.Enabled = true;
            btnDeleteMember.Enabled = true;

            string sql = "select * FROM memapprove_tbl";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == cbApplicationNo.Text)
                    {
                        //                        byte[] Imagebyte = (byte[])dt.Rows[0]["c_picturelink"];
                        //                        MemoryStream ms = new MemoryStream(Imagebyte);
                        //                        pbApplicantPic.Image = System.Drawing.Image.FromStream(ms);

                        string lastname = row[5].ToString();
                        string firtname = row[4].ToString();
                        string middlename = row[6].ToString();
                        string birthplace = row[11].ToString();
                        string permanentaddress = row[8].ToString();
                        string presentaddress = row[9].ToString();
                        string sourceincome = row[19].ToString();
                        string occupation = row[16].ToString();
                        string businessname = row[17].ToString();
                        string businessplace = row[18].ToString();

                        string spousefname = row[22].ToString();
                        string spouselname = row[21].ToString();
                        string spousemname = row[23].ToString();
                        string spousebplace = row[26].ToString();
                        string spousesourceincome = row[27].ToString();
                        string spouseoccupation = row[28].ToString();
                        string spousebusinessname = row[29].ToString();
                        string spousebusinessplace = row[30].ToString();

                        //personalinformation
                        tbLastName.Text = lastname.ToUpper();
                        tbFirstName.Text = firtname.ToUpper();
                        tbMiddleName.Text = middlename.ToUpper();

                        cbGender.Text = row[7].ToString();
                        mtbBirthday.Text = row[10].ToString();
                        tbBirthPlace.Text = birthplace.ToUpper();
                        tbPermanentAddress.Text = permanentaddress.ToUpper();
                        tbPresentAddress.Text = presentaddress.ToUpper();
                        tbDependents.Text = row[20].ToString();

                        if (row[12].ToString() == "Single")
                        {
                            rbSingle.Checked = true;
                        }
                        if (row[12].ToString() == "Married")
                        {
                            rbMarried.Checked = true;
                        }
                        if (row[12].ToString() == "Widowed")
                        {
                            rbWidowed.Checked = true;
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
                        mtbSpouseBirthday.Text = row[26].ToString();
                        tbSpouseBirthPlace.Text = spousebplace.ToUpper();
                        cbSpouseGender.Text = row[24].ToString();
                        tbSpouseOccupation.Text = spouseoccupation.ToUpper();
                        tbSpouseSourceIncome.Text = spousesourceincome.ToUpper();
                        tbSpouseBusinessName.Text = spousebusinessname.ToUpper();
                        tbSpouseBusinessAddress.Text = spousebusinessplace.ToUpper();
                        tbSpouseCNumber.Text = row[31].ToString();
                        tbSpouseEmailAddress.Text = row[32].ToString();

                        //contactinformation
                        tbCNumber.Text = row[13].ToString();
                        tbEmailAddress.Text = row[14].ToString();

                        //membershipinformation
                        tbApplicationNo.Text = cbApplicationNo.Text;
                        //                        tempdate = row[1].ToString();
                        //                        DateTime mysqldate = DateTime.Parse(tempdate);
                        tbDateApplication.Text = row[1].ToString();

                        if (row[35].ToString() == "For Assessment")
                        {
                            txtApplicationStatus.Text = "For Assessment";
                            rbPendingAssesment.Checked = true;
                        }
                        if (row[35].ToString() == "For Approval")
                        {
                            txtApplicationStatus.Text = "For Approval";
                            rbForApproval.Checked = true;
                        }
                        if (row[35].ToString() == "Approved")
                        {
                            txtApplicationStatus.Text = "Approved";
                            rbApprovedMember.Checked = true;
                        }
                        if (row[35].ToString() == "Cancelled")
                        {
                            txtApplicationStatus.Text = "Cancelled";
                            rbCancelledApplication.Checked = true;
                        }
                        if (row[15].ToString() == "Regular Member")
                        {
                            txtCoopPosition.Text = "Regular Member";
                            rbRegularMember.Checked = true;
                        }
                        if (row[15].ToString() == "Employee Member")
                        {
                            txtCoopPosition.Text = "Employee Member";
                            rbEmployeeMember.Checked = true;
                        }
                        if (row[15].ToString() == "Officer Member")
                        {
                            txtCoopPosition.Text = "Officer Member";
                            rbBDMember.Checked = true;
                        }

                        if (row[36].ToString() == "Active")
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

            btnUpdateInformation.Enabled = true;
        }
        private void SavePics()
        {
            string folderpath = AppDomain.CurrentDomain.BaseDirectory;
            string ImageCopyPath = folderpath + "localPics\\PicsApplicants\\" + tbApplicationNo.Text + ".jpg";
            var fInfo = new FileInfo(ImageCopyPath);

            if (!fInfo.Exists)
            {
                File.Copy(txtImageFileLoc.Text, ImageCopyPath);
                return;
            }

            else
            {
                MessageBox.Show("File exists! File will be overwrited...");
                File.Delete(ImageCopyPath);
                File.Copy(txtImageFileLoc.Text, ImageCopyPath);
                return;
            }
        }
        private void FormAddMember_Load(object sender, EventArgs e)
        {
            txtApplicationStatus.Visible = false;
            txtCoopPosition.Visible = false;
            txtMarStat.Visible = false;

            lblMembershipDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            resetFields();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FormMemberBackgroundAssessment ff = new FormMemberBackgroundAssessment();
            ff.ShowDialog();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            FormMemberStatus formMembershipStatus = new FormMemberStatus();
            formMembershipStatus.ShowDialog();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            FormLoanAdd formAddLoan = new FormLoanAdd();
            formAddLoan.ShowDialog();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            FormViewMemberLoan formViewMemberLoan = new FormViewMemberLoan();
            formViewMemberLoan.ShowDialog();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            FormMemberStatus ff = new FormMemberStatus();
            ff.ShowDialog();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog pics = new OpenFileDialog();
                pics.Filter = "Image(.jpg,.png)| *.jpg;*.png";
                if (pics.ShowDialog() == DialogResult.OK)
                {

                    txtImageFileLoc.Text = pics.FileName;
                    pbApplicantPic.Image = Image.FromFile(pics.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnNewMember_Click(object sender, EventArgs e)
        {
            
            //prepare fields for input
            if (btnNewMember.Text == "NEW")
            {
                cbApplicationNo.Text = "";
                ClearFields();
                InputFields();
                return;
            }

            //validate the fields before savings
            CheckFields();

            //Application no.
            int lCountList = cbApplicationNo.Items.Count + 1;
            tbApplicationNo.Text = lCountList.ToString();

            //set current date. This will be the date of application 
            string dte = DateTime.Now.ToString("yyyy-MM-dd");
            DateTime sqlDate = DateTime.Parse(dte);
            string sqlAppliDate = sqlDate.ToString("yyyy-MM-dd");
            
            //set application status as 'for assessment'
            string appliStat;
            appliStat = "For Assessment";

            //convert bdate to mysql date format
            string mbday = mtbBirthday.Text;
            DateTime mbdayDate = DateTime.Parse(mbday);
            string sqlBday = mbdayDate.ToString("yyyy-MM-dd");

            //convert spousebdate to mysql date format
            string mspousebday = mtbBirthday.Text;
            DateTime mspousebdayDate = DateTime.Parse(mspousebday);
            string spousesqlBday = mspousebdayDate.ToString("yyyy-MM-dd");

            //insert data to database
            string sql = "INSERT INTO customer_db" +
                "(c_date_application, c_FirstName, c_LastName,c_middlename,c_gender,c_addresspermanent,c_addresscurrent,c_birthday," +
                "c_birthplace,c_status,c_cnumber,c_email,c_coopposition,c_occupation,c_businessname,c_businessaddress,c_sourceincome," +
                "c_dependent,c_spouselastname,c_spousefirstname,c_spousemiddlename,c_spousegender,c_spousebirthday,c_spousebirthplace," +
                "c_spousesourceincome,c_spouseoccupation,c_spousebusinessname,c_spousebusinessaddress,c_spousecnumber,c_spouseemail,c_applicationstatus) " +
                "values('" + sqlAppliDate + "','" + tbFirstName.Text + "','" + tbLastName.Text + "','" + tbMiddleName.Text + "','" + cbGender.Text + "','" + tbPermanentAddress.Text +
                "','" + tbPresentAddress.Text + "','" + sqlBday + "','" + tbBirthPlace.Text + "','" + txtMarStat.Text + "','" + tbCNumber.Text + "','" + tbEmailAddress.Text +
                "','" + txtCoopPosition.Text + "','" + tbOccupation.Text + "','" + tbBusinessName.Text + "','" + tbBusinessAddress.Text + "','" + tbSourceIncome.Text +
                "','" + tbDependents.Text + "','" + tbSpouseLName.Text + "','" + tbSpouseFName.Text + "','" + tbSpouseMName.Text + "','" + cbSpouseGender.Text +
                "','" + spousesqlBday + "','" + tbSpouseBirthPlace.Text + "','" + tbSpouseSourceIncome.Text + "','" + tbSpouseOccupation.Text +
                "','" + tbSpouseBusinessName.Text + "','" + tbSpouseBusinessAddress.Text + "','" + tbSpouseCNumber.Text + "','" + tbSpouseEmailAddress.Text + "','" + appliStat + "')";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                if(MessageBox.Show("Are you sure you want to submit the record?", "SUBMIT", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Application successfully recorded!", "MEMBER TAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            SavePics();
            ApplicantsList();
            ClearFields();
            resetFields();
        }
        private void rbSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSingle.Checked == true)
            {
                txtMarStat.Text = "Single";
                rbWidowed.Checked = false;
                rbMarried.Checked = false;
            }
        }
        private void rbMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMarried.Checked == true)
            {
                txtMarStat.Text = "Married";
                rbSingle.Checked = false;
                rbWidowed.Checked = false;
            }
        }
        private void rbWidowed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWidowed.Checked == true)
            {
                txtMarStat.Text = "Widowed";
                rbSingle.Checked = false;
                rbMarried.Checked = false;
            }
        }
        private void cbApplicationNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbApprovedMember.Checked == true)
            {
                retriveinfoApproved();
            }
            else
            {
                retrieveinfo();
            }
        }
        private void rbRegularMember_CheckedChanged(object sender, EventArgs e)
        {
            txtCoopPosition.Text = "Regular Member";
            rbBDMember.Checked = false;
            rbEmployeeMember.Checked = false;
        }
        private void rbEmployeeMember_CheckedChanged(object sender, EventArgs e)
        {
            txtCoopPosition.Text = "Employee Member";
            rbBDMember.Checked = false;
            rbRegularMember.Checked = false;
        }
        private void rbBDMember_CheckedChanged(object sender, EventArgs e)
        {
            txtCoopPosition.Text = "Officer Member";
            rbRegularMember.Checked = false;
            rbEmployeeMember.Checked = false;

        }
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

            if(btnNewMember.Text == "SUBMIT")
            {
                cbApplicationNo.Text = "";
                ClearFields();
                resetFields();
                return;
            }
            if(btnUpdateInformation.Text == "SAVE")
            {
                cbApplicationNo.Text = "";
                ClearFields();
                resetFields();
                return;
            }
            if (rbCancelledApplication.Checked == true)
            {
                MessageBox.Show("The application is already marked as cancelled!", "CANCEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "Update customer_db set c_applicationstatus='" + "Cancelled" + "' WHERE c_ID='" + cbApplicationNo.Text + "'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();

                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = conn.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (MessageBox.Show("Are you sure you want to cancel the application?", "CANCEL", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Application marked as cancelled!", "MEMBER TAB", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            ClearFields();
            resetFields();
        }
        private void btnUpdateInformation_Click(object sender, EventArgs e)
        {
            if (btnUpdateInformation.Text == "UPDATE")
            {
                CheckFields();
                cbApplicationNo.Enabled = false;
                InputFields();
                btnNewMember.Enabled = false;
                btnDeleteMember.Enabled = true;
                btnUpdateInformation.Enabled = true;
                btnUpdateInformation.Text = "SAVE";
                return;
            }

            if (btnUpdateInformation.Text == "SAVE")
            {
                CheckFields();

                //convert bdate to mysql date format
                string mbday = mtbBirthday.Text;
                DateTime mbdayDate = DateTime.Parse(mbday);

                string sqlBday = mbdayDate.ToString("yyyy-MM-dd");

                //convert spousebdate to mysql date format
                string mspousebday = mtbBirthday.Text;
                DateTime mspousebdayDate = DateTime.Parse(mspousebday);

                string spousesqlBday = mspousebdayDate.ToString("yyyy-MM-dd");

                //update image to sql
                
                string sql = "Update customer_db set c_date_application='" + tbDateApplication.Text + "', c_FirstName='" + tbFirstName.Text +
                 "',c_LastName='" + tbLastName.Text + "',c_middlename='" + tbMiddleName.Text +
                 "',c_gender='" + cbGender.Text + "',c_addresspermanent='" + tbPermanentAddress.Text +
                 "',c_addresscurrent='" + tbPresentAddress.Text + "',c_birthday='" + sqlBday +
                 "',c_birthplace='" + tbBirthPlace.Text + "',c_status='" + txtMarStat.Text + "',c_cnumber='" + tbCNumber.Text +
                 "',c_email='" + tbEmailAddress.Text + "',c_coopposition='" + txtCoopPosition.Text + "',c_occupation='" + tbOccupation.Text +
                 "',c_businessname='" + tbBusinessName.Text + "',c_businessaddress='" + tbBusinessAddress.Text +
                 "',c_sourceincome='" + tbSourceIncome.Text + "',c_dependent='" + tbDependents.Text + "',c_spouselastname='" + tbSpouseLName.Text +
                 "',c_spousefirstname='" + tbSpouseFName.Text + "',c_spousemiddlename='" + tbSpouseMName.Text +
                 "',c_spousegender='" + cbSpouseGender.Text + "',c_spousebirthday='" + spousesqlBday + "',c_spousebirthplace='" + tbSpouseBirthPlace.Text +
                 "',c_spousesourceincome='" + tbSpouseSourceIncome.Text + "',c_spouseoccupation='" + tbSpouseOccupation.Text +
                 "',c_spousebusinessname='" + tbSpouseBusinessName.Text + "',c_spousebusinessaddress='" + tbSpouseBusinessAddress.Text +
                 "',c_spousecnumber='" + tbSpouseCNumber.Text + "',c_spouseemail='" + tbSpouseEmailAddress.Text + "',c_applicationstatus='" + txtApplicationStatus.Text +
                 "' WHERE c_ID='" + cbApplicationNo.Text + "'";
                cmd = new MySqlCommand(sql, conn);

                try
                {
                    conn.Open();

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.UpdateCommand = conn.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    
                    if(MessageBox.Show("Are you sure you want to update the record?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

                SavePics();
//                ClearFields();
//                btnUpdateInformation.Text = "UPDATE";
            }

        }
        private void rbPendingAssesment_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPendingAssesment.Checked == true)
            {
                txtApplicationStatus.Text = "For Assessment";
            }
        }
        private void rbForApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPendingAssesment.Checked == true)
            {
                txtApplicationStatus.Text = "For Approval";
            }
        }
        private void rbCancelledApplication_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCancelledApplication.Checked == true)
            {
                txtApplicationStatus.Text = "Cancelled";
            }
        }
        private void rbApprovedMember_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApprovedMember.Checked == true)
            {
                txtApplicationStatus.Text = "Approved";
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            string sql = "select * FROM customer_db Where c_id ='"+tbApplicationNo.Text+"'";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                
                byte[] Imagebyte = (byte[])dt.Rows[0]["c_picturelink"];
                MemoryStream ms = new MemoryStream(Imagebyte);
                pbApplicantPic.Image = System.Drawing.Image.FromStream(ms);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }//trial code to retrieve pics to mysql
        private void tabPage3_Enter(object sender, EventArgs e)
        {
            if (rbMarried.Checked == false)
            {
                MessageBox.Show("You have selected single or widowed. Cannot load fields for spouse.", "MEMBER TAB", MessageBoxButtons.OK);
                TabPage t = tabControl1.TabPages[1];
                tabControl1.SelectedTab = t;
            }

        }
    }
}
