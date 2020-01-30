namespace Lending_System
{
    partial class FormPayeeCustomer
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
            this.listName = new System.Windows.Forms.ListView();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.rdioBtnMember = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listName
            // 
            this.listName.HideSelection = false;
            this.listName.Location = new System.Drawing.Point(12, 82);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(340, 377);
            this.listName.TabIndex = 0;
            this.listName.UseCompatibleStateImageBehavior = false;
            this.listName.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(12, 39);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(340, 37);
            this.txtSearchName.TabIndex = 2;
            // 
            // rdioBtnMember
            // 
            this.rdioBtnMember.AutoSize = true;
            this.rdioBtnMember.Location = new System.Drawing.Point(280, 16);
            this.rdioBtnMember.Name = "rdioBtnMember";
            this.rdioBtnMember.Size = new System.Drawing.Size(72, 17);
            this.rdioBtnMember.TabIndex = 3;
            this.rdioBtnMember.TabStop = true;
            this.rdioBtnMember.Text = "MEMBER";
            this.rdioBtnMember.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "&SELECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(234, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "&ADD PAYEE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPayeeCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdioBtnMember);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.listName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPayeeCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAYEE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.RadioButton rdioBtnMember;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}