namespace Lending_System
{
    partial class FormAnnouncement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.ckHid = new System.Windows.Forms.CheckBox();
            this.ckStat = new System.Windows.Forms.CheckBox();
            this.lblCreator = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ab_details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_hidden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ab_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ab_details,
            this.ab_status,
            this.ab_creator,
            this.ab_date,
            this.ab_hidden,
            this.ab_id});
            this.dataGridView1.Location = new System.Drawing.Point(114, 254);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(524, 203);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(114, 102);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(524, 66);
            this.txtDetails.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created by:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Announcement:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(114, 176);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "POST";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(482, 176);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(156, 36);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ckHid
            // 
            this.ckHid.AutoSize = true;
            this.ckHid.Location = new System.Drawing.Point(491, 74);
            this.ckHid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckHid.Name = "ckHid";
            this.ckHid.Size = new System.Drawing.Size(52, 20);
            this.ckHid.TabIndex = 4;
            this.ckHid.Text = "Hide";
            this.ckHid.UseVisualStyleBackColor = true;
            this.ckHid.CheckedChanged += new System.EventHandler(this.ckHid_CheckedChanged);
            this.ckHid.Click += new System.EventHandler(this.ckHid_Click);
            // 
            // ckStat
            // 
            this.ckStat.AutoSize = true;
            this.ckStat.Location = new System.Drawing.Point(549, 74);
            this.ckStat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckStat.Name = "ckStat";
            this.ckStat.Size = new System.Drawing.Size(89, 20);
            this.ckStat.TabIndex = 5;
            this.ckStat.Text = "Completed";
            this.ckStat.UseVisualStyleBackColor = true;
            this.ckStat.CheckedChanged += new System.EventHandler(this.ckStat_CheckedChanged);
            this.ckStat.Click += new System.EventHandler(this.ckStat_Click);
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(110, 19);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(144, 34);
            this.lblCreator.TabIndex = 9;
            this.lblCreator.Text = "xxxxxxxxxxxx";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date:";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(110, 45);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 26);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "xxxxxxxxxxxx";
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
            // ab_id
            // 
            this.ab_id.HeaderText = "ID";
            this.ab_id.Name = "ab_id";
            this.ab_id.Width = 5;
            // 
            // FormAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 474);
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
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAnnouncement";
            this.Text = "ANNOUNCEMENT";
            this.Load += new System.EventHandler(this.FormAnnouncement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.CheckBox ckHid;
        private System.Windows.Forms.CheckBox ckStat;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_details;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_hidden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ab_id;
    }
}