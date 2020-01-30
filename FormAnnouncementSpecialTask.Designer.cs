namespace Lending_System
{
    partial class FormAnnouncementSpecialTask
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
            this.ckStat = new System.Windows.Forms.CheckBox();
            this.ckHid = new System.Windows.Forms.CheckBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboVisibleto = new System.Windows.Forms.ComboBox();
            this.txtVisibleto = new System.Windows.Forms.TextBox();
            this.ab_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_hidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.at_visibleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ckStat
            // 
            this.ckStat.AutoSize = true;
            this.ckStat.Location = new System.Drawing.Point(563, 84);
            this.ckStat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckStat.Name = "ckStat";
            this.ckStat.Size = new System.Drawing.Size(76, 17);
            this.ckStat.TabIndex = 19;
            this.ckStat.Text = "Completed";
            this.ckStat.UseVisualStyleBackColor = true;
            this.ckStat.CheckedChanged += new System.EventHandler(this.ckStat_CheckedChanged);
            // 
            // ckHid
            // 
            this.ckHid.AutoSize = true;
            this.ckHid.Location = new System.Drawing.Point(505, 84);
            this.ckHid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckHid.Name = "ckHid";
            this.ckHid.Size = new System.Drawing.Size(48, 17);
            this.ckHid.TabIndex = 17;
            this.ckHid.Text = "Hide";
            this.ckHid.UseVisualStyleBackColor = true;
            this.ckHid.CheckedChanged += new System.EventHandler(this.ckHid_CheckedChanged);
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(110, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 26);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "xxxxxxxxxxxx";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Date:";
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(110, 19);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(144, 34);
            this.lblCreator.TabIndex = 20;
            this.lblCreator.Text = "xxxxxxxxxxxx";
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(482, 176);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(156, 36);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(114, 176);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "POST";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Activities:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Created by:";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(114, 102);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(524, 66);
            this.txtDetails.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ab_details,
            this.ab_status,
            this.ab_creator,
            this.ab_date,
            this.ab_hidden,
            this.at_visibleto,
            this.ab_id});
            this.dataGridView1.Location = new System.Drawing.Point(114, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(924, 203);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Visible to:";
            // 
            // cmboVisibleto
            // 
            this.cmboVisibleto.FormattingEnabled = true;
            this.cmboVisibleto.Items.AddRange(new object[] {
            "Everyone",
            "Specific User"});
            this.cmboVisibleto.Location = new System.Drawing.Point(482, 18);
            this.cmboVisibleto.Name = "cmboVisibleto";
            this.cmboVisibleto.Size = new System.Drawing.Size(156, 21);
            this.cmboVisibleto.TabIndex = 24;
            this.cmboVisibleto.SelectedIndexChanged += new System.EventHandler(this.cmboVisibleto_SelectedIndexChanged);
            // 
            // txtVisibleto
            // 
            this.txtVisibleto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVisibleto.Location = new System.Drawing.Point(482, 40);
            this.txtVisibleto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVisibleto.Name = "txtVisibleto";
            this.txtVisibleto.Size = new System.Drawing.Size(156, 24);
            this.txtVisibleto.TabIndex = 25;
            this.txtVisibleto.DoubleClick += new System.EventHandler(this.txtVisibleto_DoubleClick);
            // 
            // ab_details
            // 
            this.ab_details.HeaderText = "Details";
            this.ab_details.Name = "ab_details";
            this.ab_details.Width = 380;
            // 
            // ab_status
            // 
            this.ab_status.HeaderText = "Status";
            this.ab_status.Name = "ab_status";
            // 
            // ab_creator
            // 
            this.ab_creator.HeaderText = "Created by";
            this.ab_creator.Name = "ab_creator";
            this.ab_creator.Width = 200;
            // 
            // ab_date
            // 
            this.ab_date.HeaderText = "Date";
            this.ab_date.Name = "ab_date";
            this.ab_date.Width = 75;
            // 
            // ab_hidden
            // 
            this.ab_hidden.HeaderText = "Visible";
            this.ab_hidden.Name = "ab_hidden";
            this.ab_hidden.Width = 75;
            // 
            // at_visibleto
            // 
            this.at_visibleto.HeaderText = "Visible to";
            this.at_visibleto.Name = "at_visibleto";
            // 
            // ab_id
            // 
            this.ab_id.HeaderText = "ID";
            this.ab_id.Name = "ab_id";
            this.ab_id.Width = 5;
            // 
            // FormAnnouncementSpecialTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 474);
            this.Controls.Add(this.txtVisibleto);
            this.Controls.Add(this.cmboVisibleto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckStat);
            this.Controls.Add(this.ckHid);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormAnnouncementSpecialTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAnnouncementSpecialTask";
            this.Load += new System.EventHandler(this.FormAnnouncementSpecialTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox ckStat;
        private System.Windows.Forms.CheckBox ckHid;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboVisibleto;
        private System.Windows.Forms.TextBox txtVisibleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_hidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn at_visibleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_id;
    }
}