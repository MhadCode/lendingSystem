using Lending_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lending_System
{
    public partial class FormHome : Form
    {
        public static string username;
        public FormHome()
        {

            InitializeComponent();    
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Mouseenter(object sender, EventArgs e)
        {
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            lblDate.Text = DateTime.Now.ToString("mm-dd-yyy h:mmtt");
            lblUsername.Text = "Dondon Ordas";

            lvAnnouncement.View = View.Details;
            lvSpecialTask.View = View.Details;
            
        }

        private void listAnnouncement(string createdby, string details)
        {

        }

        private void listActivity(string createdby, string details, string status)
        {

        }


        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseHover_1(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 0;
            button1.BackColor = Color.Chocolate;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 1;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.Chocolate;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SaddleBrown;
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 1;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.Chocolate;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 2;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.Chocolate;
            button8.BackColor = Color.SaddleBrown;
        }

        private void button9_MouseEnter_1(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 2;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.Chocolate;
            button8.BackColor = Color.SaddleBrown;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.SaddleBrown;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnLendingTab_MouseHover(object sender, EventArgs e)
        {
            btnLendingTab.ForeColor = Color.Gold;
            btnLendingTab.Font = new Font("Arial",12,FontStyle.Bold);

        }

        private void btnLendingTab_MouseLeave(object sender, EventArgs e)
        {
            btnLendingTab.ForeColor = Color.White;
            btnLendingTab.Font = new Font("Arial", 10, FontStyle.Bold);

        }

        private void btnLendingTab_Click(object sender, EventArgs e)
        {
            FormLoanManager ff = new FormLoanManager();
            ff.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 3;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.Chocolate;
        }

        private void btnLendingAdd_MouseHover(object sender, EventArgs e)
        {
            btnLendingAdd.ForeColor = Color.Gold;
            btnLendingAdd.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingAdd_MouseLeave(object sender, EventArgs e)
        {
            btnLendingAdd.ForeColor = Color.White;
            btnLendingAdd.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnLendingPending_MouseHover(object sender, EventArgs e)
        {
            btnLendingPending.ForeColor = Color.Gold;
            btnLendingPending.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingPending_MouseLeave(object sender, EventArgs e)
        {
            btnLendingPending.ForeColor = Color.White;
            btnLendingPending.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnLendingCAssessment_MouseHover(object sender, EventArgs e)
        {
            btnLendingCAssessment.ForeColor = Color.Gold;
            btnLendingCAssessment.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingCAssessment_MouseLeave(object sender, EventArgs e)
        {
            btnLendingCAssessment.ForeColor = Color.White;
            btnLendingCAssessment.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnLendingApproved_MouseHover(object sender, EventArgs e)
        {
            btnLendingApproved.ForeColor = Color.Gold;
            btnLendingApproved.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingApproved_MouseLeave(object sender, EventArgs e)
        {
            btnLendingApproved.ForeColor = Color.White;
            btnLendingApproved.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnLendingOS_MouseHover(object sender, EventArgs e)
        {
            btnLendingOS.ForeColor = Color.Gold;
            btnLendingOS.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingOS_MouseLeave(object sender, EventArgs e)
        {
            btnLendingOS.ForeColor = Color.White;
            btnLendingOS.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnLendingSetting_MouseHover(object sender, EventArgs e)
        {
            btnLendingSetting.ForeColor = Color.Gold;
            btnLendingSetting.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingSetting_MouseLeave(object sender, EventArgs e)
        {
            btnLendingSetting.ForeColor = Color.White;
            btnLendingSetting.Font = new Font("Arial", 10, FontStyle.Bold); 
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
        }

        private void listView1_MouseEnter(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
        }

        private void btnMemberView_Click(object sender, EventArgs e)
        {
            FormMemberList ff = new FormMemberList();
            ff.ShowDialog();
        }

        private void tabPage1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Chocolate;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;

        }

        private void tabPage2_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.Chocolate;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
        }

        private void tabPage3_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.Chocolate;
            button8.BackColor = Color.SaddleBrown;
        }

        private void tabPage4_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.Chocolate;

        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.SaddleBrown;
        }

        private void btnMemberTab_MouseHover(object sender, EventArgs e)
        {
            btnMemberTab.ForeColor = Color.Gold;
            btnMemberTab.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberTab_MouseLeave(object sender, EventArgs e)
        {
            btnMemberTab.ForeColor = Color.White;
            btnMemberTab.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnMemberTab_Click(object sender, EventArgs e)
        {
            FormMemberManager ff = new FormMemberManager();
            ff.ShowDialog();
        }

        private void btnMemberNew_MouseHover(object sender, EventArgs e)
        {
            btnMemberNew.ForeColor = Color.Gold;
            btnMemberNew.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberNew_MouseLeave(object sender, EventArgs e)
        {
            btnMemberNew.ForeColor = Color.White;
            btnMemberNew.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnMemberPending_MouseHover(object sender, EventArgs e)
        {
            btnMemberPending.ForeColor = Color.Gold;
            btnMemberPending.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberPending_MouseLeave(object sender, EventArgs e)
        {
            btnMemberPending.ForeColor = Color.White;
            btnMemberPending.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnBAssessment_MouseHover(object sender, EventArgs e)
        {
            btnBAssessment.ForeColor = Color.Gold;
            btnBAssessment.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnBAssessment_MouseLeave(object sender, EventArgs e)
        {
            btnBAssessment.ForeColor = Color.White;
            btnBAssessment.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnMemberView_MouseHover(object sender, EventArgs e)
        {
            btnMemberView.ForeColor = Color.Gold;
            btnMemberView.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberView_MouseLeave(object sender, EventArgs e)
        {
            btnMemberView.ForeColor = Color.White;
            btnMemberView.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnBalances_MouseHover(object sender, EventArgs e)
        {
            btnMemberBalances.ForeColor = Color.Gold;
            btnMemberBalances.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnBalances_MouseLeave(object sender, EventArgs e)
        {
            btnMemberBalances.ForeColor = Color.White;
            btnMemberBalances.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnMemberSettings_MouseHover(object sender, EventArgs e)
        {
            btnMemberSettings.ForeColor = Color.Gold;
            btnMemberSettings.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberSettings_MouseLeave(object sender, EventArgs e)
        {
            btnMemberSettings.ForeColor = Color.White;
            btnMemberSettings.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAcctgTab_MouseHover(object sender, EventArgs e)
        {
            btnAcctgTab.ForeColor = Color.Gold;
            btnAcctgTab.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgTab_MouseLeave(object sender, EventArgs e)
        {
            btnAcctgTab.ForeColor = Color.White;
            btnAcctgTab.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAcctgCreate_MouseHover(object sender, EventArgs e)
        {
            btnAcctgCreate.ForeColor = Color.Gold;
            btnAcctgCreate.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgCreate_MouseLeave(object sender, EventArgs e)
        {
            btnAcctgCreate.ForeColor = Color.White;
            btnAcctgCreate.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAcctgPending_MouseHover(object sender, EventArgs e)
        {
            btnAcctgPending.ForeColor = Color.Gold;
            btnAcctgPending.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgPending_MouseLeave(object sender, EventArgs e)
        {
            btnAcctgPending.ForeColor = Color.White;
            btnAcctgPending.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAcctgApproved_MouseHover(object sender, EventArgs e)
        {
            btnAcctgApproved.ForeColor = Color.Gold;
            btnAcctgApproved.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgApproved_MouseLeave(object sender, EventArgs e)
        {
            btnAcctgApproved.ForeColor = Color.White;
            btnAcctgApproved.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAcctgMemo_MouseHover(object sender, EventArgs e)
        {
            btnAcctgMemo.ForeColor = Color.Gold;
            btnAcctgMemo.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgMemo_MouseLeave(object sender, EventArgs e)
        {
            btnAcctgMemo.ForeColor = Color.White;
            btnAcctgMemo.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAcctgBalances_MouseHover(object sender, EventArgs e)
        {
            btnAcctgBalances.ForeColor = Color.Gold;
            btnAcctgBalances.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgBalances_MouseLeave(object sender, EventArgs e)
        {
            btnAcctgBalances.ForeColor = Color.White;
            btnAcctgBalances.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnAcctgSettings_MouseEnter(object sender, EventArgs e)
        {
         }

        private void btnAcctgSettings_MouseHover(object sender, EventArgs e)
        {
            btnAcctgSettings.ForeColor = Color.Gold;
            btnAcctgSettings.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgSettings_MouseLeave(object sender, EventArgs e)
        {
            btnAcctgSettings.ForeColor = Color.White;
            btnAcctgSettings.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnReportsFS_MouseHover(object sender, EventArgs e)
        {
            btnReportsFS.ForeColor = Color.Gold;
            btnReportsFS.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsFS_MouseLeave(object sender, EventArgs e)
        {
            btnReportsFS.ForeColor = Color.White;
            btnReportsFS.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnReportsOSLoaans_MouseHover(object sender, EventArgs e)
        {
            btnReportsOSLoaans.ForeColor = Color.Gold;
            btnReportsOSLoaans.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsOSLoaans_MouseLeave(object sender, EventArgs e)
        {
            btnReportsOSLoaans.ForeColor = Color.White;
            btnReportsOSLoaans.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnReportsSavings_MouseHover(object sender, EventArgs e)
        {
            btnReportsSavings.ForeColor = Color.Gold;
            btnReportsSavings.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsSavings_MouseLeave(object sender, EventArgs e)
        {
            btnReportsSavings.ForeColor = Color.White;
            btnReportsSavings.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnReportsCapital_MouseHover(object sender, EventArgs e)
        {
            btnReportsCapital.ForeColor = Color.Gold;
            btnReportsCapital.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsCapital_MouseLeave(object sender, EventArgs e)
        {
            btnReportsCapital.ForeColor = Color.White;
            btnReportsCapital.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnReportsCollection_MouseHover(object sender, EventArgs e)
        {
            btnReportsCollection.ForeColor = Color.Gold;
            btnReportsCollection.Font = new Font("Arila", 12, FontStyle.Bold);
        }

        private void btnReportsCollection_MouseLeave(object sender, EventArgs e)
        {
            btnReportsCollection.ForeColor = Color.White;
            btnReportsCollection.Font = new Font("Arila", 10, FontStyle.Bold);
        }

        private void btnReportsDividends_MouseHover(object sender, EventArgs e)
        {
            btnReportsDividends.ForeColor = Color.Gold;
            btnReportsDividends.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsDividends_MouseLeave(object sender, EventArgs e)
        {
            btnReportsDividends.ForeColor = Color.White;
            btnReportsDividends.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnReportsOther_MouseHover(object sender, EventArgs e)
        {
            btnReportsOther.ForeColor = Color.Gold;
            btnReportsOther.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsOther_MouseLeave(object sender, EventArgs e)
        {
            btnReportsOther.ForeColor = Color.White;
            btnReportsOther.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        private void btnMemberNew_Click(object sender, EventArgs e)
        {
            FormMemberAdd ff = new FormMemberAdd();
            ff.ShowDialog();
        }

        private void btnMemberPending_Click(object sender, EventArgs e)
        {
            FormMemberStatus ff = new FormMemberStatus();
            ff.ShowDialog();
        }

        private void btnBAssessment_Click(object sender, EventArgs e)
        {
            FormMemberBackgroundAssessment ff = new FormMemberBackgroundAssessment();
            ff.ShowDialog();
        }

        private void button3_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void button3_MouseLeave_1(object sender, EventArgs e)
        {
            button3.BackColor = Color.SaddleBrown;
        }

        private void btnMemberTab_MouseEnter(object sender, EventArgs e)
        {
            btnMemberTab.ForeColor = Color.Gold;
            btnMemberTab.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberNew_MouseEnter(object sender, EventArgs e)
        {
            btnMemberNew.ForeColor = Color.Gold;
            btnMemberNew.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberPending_MouseEnter(object sender, EventArgs e)
        {
            btnMemberPending.ForeColor = Color.Gold;
            btnMemberPending.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnBAssessment_MouseEnter(object sender, EventArgs e)
        {
            btnBAssessment.ForeColor = Color.Gold;
            btnBAssessment.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberView_MouseEnter(object sender, EventArgs e)
        {
            btnMemberView.ForeColor = Color.Gold;
            btnMemberView.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberBalances_Click(object sender, EventArgs e)
        {

        }

        private void btnMemberBalances_MouseEnter(object sender, EventArgs e)
        {
            btnMemberBalances.ForeColor = Color.Gold;
            btnMemberBalances.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingTab_MouseEnter(object sender, EventArgs e)
        {
            btnLendingTab.ForeColor = Color.Gold;
            btnLendingTab.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingAdd_MouseEnter(object sender, EventArgs e)
        {
            btnLendingAdd.ForeColor = Color.Gold;
            btnLendingAdd.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingPending_MouseEnter(object sender, EventArgs e)
        {
            btnLendingPending.ForeColor = Color.Gold;
            btnLendingPending.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingCAssessment_MouseEnter(object sender, EventArgs e)
        {
            btnLendingCAssessment.ForeColor = Color.Gold;
            btnLendingCAssessment.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingApproved_MouseEnter(object sender, EventArgs e)
        {
            btnLendingApproved.ForeColor = Color.Gold;
            btnLendingApproved.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingOS_MouseEnter(object sender, EventArgs e)
        {
            btnLendingOS.ForeColor = Color.Gold;
            btnLendingOS.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgTab_MouseEnter(object sender, EventArgs e)
        {
            btnAcctgTab.ForeColor = Color.Gold;
            btnAcctgTab.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgCreate_MouseEnter(object sender, EventArgs e)
        {
            btnAcctgCreate.ForeColor = Color.Gold;
            btnAcctgCreate.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgPending_MouseEnter(object sender, EventArgs e)
        {
            btnAcctgPending.ForeColor = Color.Gold;
            btnAcctgPending.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgApproved_MouseEnter(object sender, EventArgs e)
        {
            btnAcctgApproved.ForeColor = Color.Gold;
            btnAcctgApproved.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgMemo_MouseEnter(object sender, EventArgs e)
        {
            btnAcctgMemo.ForeColor = Color.Gold;
            btnAcctgMemo.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgBalances_MouseEnter(object sender, EventArgs e)
        {
            btnAcctgBalances.ForeColor = Color.Gold;
            btnAcctgBalances.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsFS_MouseEnter(object sender, EventArgs e)
        {
            btnReportsFS.ForeColor = Color.Gold;
            btnReportsFS.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsOSLoaans_MouseEnter(object sender, EventArgs e)
        {
            btnReportsOSLoaans.ForeColor = Color.Gold;
            btnReportsOSLoaans.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsSavings_MouseEnter(object sender, EventArgs e)
        {
            btnReportsSavings.ForeColor = Color.Gold;
            btnReportsSavings.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsCapital_MouseEnter(object sender, EventArgs e)
        {
            btnReportsCapital.ForeColor = Color.Gold;
            btnReportsCapital.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsCollection_MouseEnter(object sender, EventArgs e)
        {
            btnReportsCollection.ForeColor = Color.Gold;
            btnReportsCollection.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsDividends_MouseEnter(object sender, EventArgs e)
        {
            btnReportsDividends.ForeColor = Color.Gold;
            btnReportsDividends.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnReportsOther_MouseEnter(object sender, EventArgs e)
        {
            btnReportsOther.ForeColor = Color.Gold;
            btnReportsOther.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnMemberSettings_MouseEnter(object sender, EventArgs e)
        {
            btnMemberSettings.ForeColor = Color.Gold;
            btnMemberSettings.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnLendingSetting_MouseEnter(object sender, EventArgs e)
        {
            btnLendingSetting.ForeColor = Color.Gold;
            btnLendingSetting.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        private void btnAcctgTab_Click(object sender, EventArgs e)
        {
            FormAccounting ff = new FormAccounting();
            ff.ShowDialog();
        }

        private void btnAcctgCreate_Click(object sender, EventArgs e)
        {
            FormAccountingJournal ff = new FormAccountingJournal();
            ff.ShowDialog();
        }

        private void btnAcctgPending_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAcctgMemo_Click(object sender, EventArgs e)
        {
            FormAccountingMemo ff = new FormAccountingMemo();
            ff.ShowDialog();
        }

        private void btnAcctgBalances_Click(object sender, EventArgs e)
        {
            FormViewJournal ff = new FormViewJournal();
            ff.ShowDialog();
        }

        private void btnAcctgSettings_Click(object sender, EventArgs e)
        {
            SetupForm ff = new SetupForm();
            ff.ShowDialog();
        }

        private void btnLendingAdd_Click(object sender, EventArgs e)
        {
            username = lblUsername.Text;

            FormLoanAdd ff = new FormLoanAdd();
            ff.ShowDialog();
        }

        private void btnLendingSetting_Click(object sender, EventArgs e)
        {
            SetupForm ff = new SetupForm();
            ff.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            button1.BackColor = Color.SaddleBrown;
            button3.BackColor = Color.SaddleBrown;
            button9.BackColor = Color.SaddleBrown;
            button8.BackColor = Color.SaddleBrown;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            FormAccountingBS ff = new FormAccountingBS();
            ff.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            FormCollectionAdd ff = new FormCollectionAdd();
            ff.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPaymentAdd ff = new FormPaymentAdd();
            ff.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void financilaStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
            FormViewMemberBalances ff = new FormViewMemberBalances();
            ff.ShowDialog();
        }

        private void AddUpdateUsersAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserAccount ff = new FormUserAccount();
            ff.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            username = lblUsername.Text;

            FormAnnouncement ff = new FormAnnouncement();
            ff.ShowDialog();
        }

        private void generalSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetupForm ff = new SetupForm();
            ff.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAnnouncementSpecialTask ff = new FormAnnouncementSpecialTask();
            ff.ShowDialog();
        }
    }
}