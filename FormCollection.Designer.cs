namespace Lending_System
{
    partial class FormCollection
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Collection_OR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection_BSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection_Transaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Collection_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(255, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 527);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLLECTION LIST";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 21);
            this.comboBox2.TabIndex = 46;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Collection_OR,
            this.Collection_Date,
            this.Collection_BSID,
            this.Collection_Name,
            this.Collection_Transaction,
            this.Collection_Amount});
            this.dataGridView2.Location = new System.Drawing.Point(6, 90);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(762, 387);
            this.dataGridView2.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 527);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPTIONS";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 449);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(208, 58);
            this.button6.TabIndex = 6;
            this.button6.Text = "REPORTS";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(208, 58);
            this.button5.TabIndex = 5;
            this.button5.Text = "REMIT COLLECTION";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "NEW COLLECTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 24);
            this.button3.TabIndex = 47;
            this.button3.Text = "SEARCH";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "ADJUSTMENT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Collection_OR
            // 
            this.Collection_OR.HeaderText = "OR no.";
            this.Collection_OR.Name = "Collection_OR";
            this.Collection_OR.Width = 80;
            // 
            // Collection_Date
            // 
            this.Collection_Date.HeaderText = "Date";
            this.Collection_Date.Name = "Collection_Date";
            // 
            // Collection_BSID
            // 
            this.Collection_BSID.HeaderText = "BS No.";
            this.Collection_BSID.Name = "Collection_BSID";
            this.Collection_BSID.Width = 80;
            // 
            // Collection_Name
            // 
            this.Collection_Name.HeaderText = "Name";
            this.Collection_Name.Name = "Collection_Name";
            this.Collection_Name.Width = 200;
            // 
            // Collection_Transaction
            // 
            this.Collection_Transaction.HeaderText = "Transaction";
            this.Collection_Transaction.Name = "Collection_Transaction";
            this.Collection_Transaction.Width = 150;
            // 
            // Collection_Amount
            // 
            this.Collection_Amount.HeaderText = "Amount";
            this.Collection_Amount.Name = "Collection_Amount";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(660, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(660, 45);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker2.TabIndex = 51;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 483);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 38);
            this.button4.TabIndex = 52;
            this.button4.Text = "View Details";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(158, 483);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(146, 38);
            this.button7.TabIndex = 53;
            this.button7.Text = "Print Receipt";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "XXXX";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 373);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(208, 58);
            this.button8.TabIndex = 7;
            this.button8.Text = "SETTINGS";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // FormCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 568);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCollection";
            this.Text = "COLLECTION";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection_OR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection_BSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection_Transaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Collection_Amount;
        private System.Windows.Forms.Button button8;
    }
}