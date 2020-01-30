namespace Lending_System
{
    partial class FormAccountingJournal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmboRef = new System.Windows.Forms.ComboBox();
            this.dateJV = new System.Windows.Forms.DateTimePicker();
            this.txtJVref = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdioBtnCancelledVoucher = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAcctName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.txtAcctCode = new System.Windows.Forms.TextBox();
            this.txtDR = new System.Windows.Forms.TextBox();
            this.txtTrans = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtaGridDetails = new System.Windows.Forms.DataGridView();
            this.JournalAcctCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JournalAcctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JournalDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JournalCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGL = new System.Windows.Forms.Button();
            this.txtPrint = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmboRef);
            this.groupBox4.Controls.Add(this.dateJV);
            this.groupBox4.Controls.Add(this.txtJVref);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.rdioBtnCancelledVoucher);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txtTrans);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dtaGridDetails);
            this.groupBox4.Location = new System.Drawing.Point(5, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(691, 575);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ENTRY";
            this.groupBox4.UseCompatibleTextRendering = true;
            // 
            // cmboRef
            // 
            this.cmboRef.FormattingEnabled = true;
            this.cmboRef.Location = new System.Drawing.Point(109, 26);
            this.cmboRef.Name = "cmboRef";
            this.cmboRef.Size = new System.Drawing.Size(125, 21);
            this.cmboRef.TabIndex = 29;
            this.cmboRef.SelectedIndexChanged += new System.EventHandler(this.cmboRef_SelectedIndexChanged);
            this.cmboRef.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cmboRef_MouseDoubleClick);
            // 
            // dateJV
            // 
            this.dateJV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJV.Location = new System.Drawing.Point(570, 64);
            this.dateJV.Name = "dateJV";
            this.dateJV.Size = new System.Drawing.Size(97, 20);
            this.dateJV.TabIndex = 28;
            // 
            // txtJVref
            // 
            this.txtJVref.Location = new System.Drawing.Point(535, 26);
            this.txtJVref.Multiline = true;
            this.txtJVref.Name = "txtJVref";
            this.txtJVref.Size = new System.Drawing.Size(132, 29);
            this.txtJVref.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Journal Voucher no.";
            // 
            // rdioBtnCancelledVoucher
            // 
            this.rdioBtnCancelledVoucher.AutoSize = true;
            this.rdioBtnCancelledVoucher.Location = new System.Drawing.Point(21, 546);
            this.rdioBtnCancelledVoucher.Name = "rdioBtnCancelledVoucher";
            this.rdioBtnCancelledVoucher.Size = new System.Drawing.Size(116, 17);
            this.rdioBtnCancelledVoucher.TabIndex = 25;
            this.rdioBtnCancelledVoucher.Text = "Cancelled Voucher";
            this.rdioBtnCancelledVoucher.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(607, 623);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "XXXXXX";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(510, 623);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "XXXXXX";
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(459, 541);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 22);
            this.label14.TabIndex = 22;
            this.label14.Text = "0.00";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(562, 541);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 22);
            this.label13.TabIndex = 15;
            this.label13.Text = "0.00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Report reference";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtAcctName);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtCR);
            this.groupBox5.Controls.Add(this.txtAcctCode);
            this.groupBox5.Controls.Add(this.txtDR);
            this.groupBox5.Location = new System.Drawing.Point(18, 148);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(649, 137);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Credit";
            // 
            // txtAcctName
            // 
            this.txtAcctName.Location = new System.Drawing.Point(99, 78);
            this.txtAcctName.Multiline = true;
            this.txtAcctName.Name = "txtAcctName";
            this.txtAcctName.Size = new System.Drawing.Size(315, 33);
            this.txtAcctName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Account Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Debit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Account Code";
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(498, 78);
            this.txtCR.Multiline = true;
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(145, 33);
            this.txtCR.TabIndex = 22;
            // 
            // txtAcctCode
            // 
            this.txtAcctCode.Location = new System.Drawing.Point(99, 39);
            this.txtAcctCode.Multiline = true;
            this.txtAcctCode.Name = "txtAcctCode";
            this.txtAcctCode.Size = new System.Drawing.Size(130, 33);
            this.txtAcctCode.TabIndex = 17;
            // 
            // txtDR
            // 
            this.txtDR.Location = new System.Drawing.Point(498, 39);
            this.txtDR.Multiline = true;
            this.txtDR.Name = "txtDR";
            this.txtDR.Size = new System.Drawing.Size(145, 33);
            this.txtDR.TabIndex = 21;
            // 
            // txtTrans
            // 
            this.txtTrans.Location = new System.Drawing.Point(107, 104);
            this.txtTrans.Multiline = true;
            this.txtTrans.Name = "txtTrans";
            this.txtTrans.Size = new System.Drawing.Size(390, 23);
            this.txtTrans.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Transaction";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 72);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 26);
            this.txtName.TabIndex = 16;
            this.txtName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.txtName.DoubleClick += new System.EventHandler(this.txtName_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtaGridDetails
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaGridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JournalAcctCode,
            this.JournalAcctName,
            this.JournalDebit,
            this.JournalCredit});
            this.dtaGridDetails.Location = new System.Drawing.Point(19, 291);
            this.dtaGridDetails.Name = "dtaGridDetails";
            this.dtaGridDetails.Size = new System.Drawing.Size(648, 248);
            this.dtaGridDetails.TabIndex = 14;
            // 
            // JournalAcctCode
            // 
            this.JournalAcctCode.HeaderText = "Code";
            this.JournalAcctCode.Name = "JournalAcctCode";
            this.JournalAcctCode.Width = 80;
            // 
            // JournalAcctName
            // 
            this.JournalAcctName.HeaderText = "Account Name";
            this.JournalAcctName.Name = "JournalAcctName";
            this.JournalAcctName.Width = 320;
            // 
            // JournalDebit
            // 
            this.JournalDebit.HeaderText = "Debit";
            this.JournalDebit.Name = "JournalDebit";
            // 
            // JournalCredit
            // 
            this.JournalCredit.HeaderText = "Credit";
            this.JournalCredit.Name = "JournalCredit";
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnErase.Location = new System.Drawing.Point(702, 194);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(145, 53);
            this.btnErase.TabIndex = 26;
            this.btnErase.Tag = "";
            this.btnErase.Text = "Erase";
            this.btnErase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(702, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 53);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "Add/Update";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOpen.Location = new System.Drawing.Point(702, 312);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(145, 53);
            this.btnOpen.TabIndex = 17;
            this.btnOpen.Tag = "";
            this.btnOpen.Text = "Open Journal";
            this.btnOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(702, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 53);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Tag = "";
            this.btnCancel.Text = "Cancel Voucher";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(702, 17);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 53);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Tag = "";
            this.btnSubmit.Text = "Submit Journal";
            this.btnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnGL
            // 
            this.btnGL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGL.Location = new System.Drawing.Point(702, 253);
            this.btnGL.Name = "btnGL";
            this.btnGL.Size = new System.Drawing.Size(145, 53);
            this.btnGL.TabIndex = 12;
            this.btnGL.Tag = "";
            this.btnGL.Text = "General Ledger";
            this.btnGL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGL.UseVisualStyleBackColor = false;
            this.btnGL.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtPrint
            // 
            this.txtPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrint.Location = new System.Drawing.Point(702, 534);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(145, 53);
            this.txtPrint.TabIndex = 13;
            this.txtPrint.Tag = "";
            this.txtPrint.Text = "Print Voucher";
            this.txtPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtPrint.UseVisualStyleBackColor = false;
            this.txtPrint.Click += new System.EventHandler(this.txtPrint_Click);
            // 
            // FormAccountingJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(852, 593);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnGL);
            this.Controls.Add(this.txtPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAccountingJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOURNAL ENTRY";
            this.Load += new System.EventHandler(this.FormAccountingJournal_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button txtPrint;
        private System.Windows.Forms.Button btnGL;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAcctCode;
        private System.Windows.Forms.TextBox txtTrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dtaGridDetails;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.TextBox txtDR;
        private System.Windows.Forms.TextBox txtAcctName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dateJV;
        private System.Windows.Forms.TextBox txtJVref;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rdioBtnCancelledVoucher;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn JournalAcctCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn JournalAcctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn JournalDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn JournalCredit;
        private System.Windows.Forms.ComboBox cmboRef;
    }
}